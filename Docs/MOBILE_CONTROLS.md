# Mobile Touch Controls

The prototype includes a joystick bridge, but the HUD still needs to be created in a Unity scene.

## Create a joystick
1. Add a **Canvas** and an **EventSystem** to the scene.
2. Inside the Canvas, create a UI Image on the bottom-left of the screen (for example 180 x 180) and name it `MoveJoystick`.
3. Add a child UI Image named `Knob` (for example 70 x 70) and center its anchors and position.
4. Add `NinaMobileJoystick` to `MoveJoystick`.
5. Assign the parent RectTransform to **Joystick Area**, the child RectTransform to **Knob**, and Nina's `NinaPlayerController` to **Player Controller**.
6. Make sure the joystick background Image has **Raycast Target** enabled.

## Create action buttons
Add UI Buttons on the right side of the Canvas and connect each Button's **On Click()** event:
- Attack → Nina's `NinaCombatController.Attack`
- Dodge → Nina's `NinaPlayerController.Dodge`
- Jump → Nina's `NinaPlayerController.Jump`
- Blood Spike → Nina's `NinaBloodMagic.BloodSpike`
- Bad Blood → Nina's `NinaBloodMagic.BadBlood`
- Blood Times → Nina's `NinaBloodMagic.BloodTimes`

Use large, spaced buttons for phone screens. Keep the joystick away from Android system gesture edges. The script expects a Canvas and EventSystem to be present.

## Prototype limitations
- This is a simple virtual joystick, not a polished production HUD.
- The camera-follow system, lock-on targeting, animation-driven attacks and touch interaction testing are not included yet.
- The current movement controller's desktop input uses Unity's legacy Input Manager; enable **Input Manager (Old)** or **Both** under Active Input Handling when testing with keyboard.
