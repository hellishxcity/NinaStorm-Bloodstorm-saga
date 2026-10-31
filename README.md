# NinaStorm: The Bloodstorm

A Unity-based, full 3D third-person dark medieval fantasy action RPG for mobile.

## Starter-kit status
This repository is the beginning of the project. The scripts below are a **prototype foundation**, not a finished game or a tested Android build. They use Unity built-in components and primitives so the first scene can be assembled without imported art assets.

## Current starter systems
- 3D graybox world builder: terrain-like ground, castle, village, forest, dungeon entrance and encounter markers.
- Third-person player movement using a CharacterController.
- Basic melee attack and health/damage foundation.
- Enemy pursuit and attack prototype.
- Blood Essence and three starter Blood Magic abilities.
- Mobile UI hookup instructions for Unity UI Buttons and joystick packages.

## Unity setup
1. Install a current Unity LTS release with **3D Core** (URP is fine; this prototype uses built-in components).
2. Open or create a Unity project.
3. Copy the `Assets/NinaStorm` folder from this repository into the project's `Assets` folder.
4. In Unity, create an empty scene and an empty GameObject named `NinaStormWorld`; add `Nina3DWorldBuilder`.
5. Create a Capsule named `Nina`, add a `CharacterController`, then add `NinaPlayerController` and `NinaCombatController`. Assign the camera to the player controller.
6. Create a Cube or Capsule enemy, add a `NinaHealth` component and `NinaEnemyAI`. Assign Nina as its target.
7. Add `NinaBloodMagic` to Nina. Link UI buttons to its public methods in the Inspector.
8. Use Unity's Play button to test in-editor first. Add Android Build Support before building to a device.

## Prototype controls
- Desktop testing: WASD / arrow keys to move; Space to jump; Left Shift to dodge; left mouse button or J to attack.
- Mobile: connect a virtual joystick to `SetMoveInput(Vector2)` and UI Buttons to `Attack()`, `Dodge()`, `Jump()`, and Blood Magic methods.
- Assign a camera to `NinaPlayerController` for camera-relative movement.

## Planned next milestones
1. Import and rig Nina's character, weapons and animations.
2. Add lock-on targeting, combo timing, hit reactions, parry windows and boss telegraphs.
3. Add quest state, save/load, inventory, merchants, Queendom upgrades and raid events.
4. Replace graybox primitives with optimized mobile-ready art and lighting.
5. Test performance and input on actual Android hardware.

## Important limitations
- This is source code, not an APK and not a complete Unity project export.
- Unity compilation, scene setup, animation, touch controls, balancing and Android device testing have not yet been verified.
- Do not treat placeholder primitives as final visual assets.
