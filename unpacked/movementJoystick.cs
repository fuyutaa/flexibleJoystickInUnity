using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJoystick : MonoBehaviour
{
    public GameObject innerCircle;
    public GameObject outerCircle;
    public Vector2 joystickVec;
    public Vector2 joystickTouchPos;
    public Vector2 joystickOriginalPos;
    public float joystickRadius;

    // used for the acting function of the joystick
    public bool isPointerDown;

    public DialogueUI dialogueUI;

    void Start()
    {
        joystickOriginalPos = outerCircle.transform.position;
        joystickRadius = outerCircle.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    public void PointerDown()
    {
        innerCircle.transform.position = outerCircle.transform.position;
        outerCircle.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if(joystickDist < joystickRadius)
        {
            innerCircle.transform.position = joystickTouchPos + joystickVec * joystickDist;
        }

        else
        {
            innerCircle.transform.position = joystickTouchPos + joystickVec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        innerCircle.transform.position = joystickOriginalPos;
        outerCircle.transform.position = joystickOriginalPos;
    }

}
