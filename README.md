# flexibleJoystickInUnity

The math in other ones is poorly maded, new Vector2 resulting in going through walls, weirdly acting Collider2Ds...

I looked at many tutorials (5-7~), but couldn't find a correct math solution, so here I am ^^


 You can define an area where the joystick can move. Not a static and boring joystick ;)

For the joystick visuals, you can search in the asset store for "Joystick Pack", it's free.

 1. Set Collision Detection of your player to "Continuous".

 2. If not, set your canvas to "scale with screen size" and add your reference resolution.

 3. Make a new panel named JoystickArea (area where the joystick can move).

 4. Source image : default square

 5. Give a color to it to ease developpement of the joystick. The panel will later be invisible so the color doesn't matter.

 6. Make 2 UI images (feel free to resize as your needs):
    - Joystick outer circle : PosX -650 / PosY -300 / Width 250 / Height 250
    - Joystick inner circle : PosX -650 / PosY -300

 7. Resize your area to your needs.

 8. On the panel, add Joystick.cs.

 9. Still on him, an Event Trigger component.

 10. Add event tpyes :
    - Pointer Down
    - Drag
    - Pointer Up

11. Add a new Event on each list, and add to the empty field the Joystick.cs component.

12. Add the corresponding functions to the element of each list 
    (Drag -) Joystick.Drag)

14. Create a new script named MovePlayer in your project files. Paste the code founded in this github repo.

13. Add references in inspector.
 