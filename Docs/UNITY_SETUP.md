# Unity Setup — NinaStorm: The Bloodstorm

## What is in this repository?
This is an early source-code starter kit. It is not a complete Unity project yet: Unity's generated project files, packages, scenes, prefabs, character models, animations and audio are not included. No Unity compilation or Android build has been run from this repository.

## Create a Unity project
1. On a Windows or Mac computer, install a current Unity LTS editor and the Android Build Support module (SDK/NDK tools and OpenJDK).
2. Create a new 3D project. URP is optional for this prototype.
3. Download this repository as a ZIP or clone it.
4. Copy the repository's `Assets/NinaStorm` directory into the Unity project's `Assets` directory.
5. In **Edit → Project Settings → Player → Active Input Handling**, select **Input Manager (Old)** or **Both** for the prototype keyboard controls. If prompted, restart Unity.
6. Save a new scene as `Assets/NinaStorm/Scenes/AshenMarches.unity`.

## Build the graybox scene
1. Create an empty GameObject called `WorldBuilder`.
2. Add the `NinaStormWorldBuilder` component. Keep **Build On Start** enabled.
3. Press Play. The script creates a temporary primitive-based landscape, Blackthorn Castle, a village, the Veilfall Tunnels entrance, forest props and location markers.
4. These are placeholder primitives. The builder is a graybox and not final art. Tune counts and scale for mobile performance.

## Create Nina for a first movement test
1. Create a Capsule and rename it `Nina`.
2. Add `CharacterController`, `NinaPlayerController`, `NinaCombatController`, `NinaHealth`, and `NinaBloodMagic`.
3. Position Nina above the ground.
4. Tag the camera `MainCamera`, and assign its Transform to `cameraTransform` on `NinaPlayerController`. The prototype uses the assigned camera's orientation for movement; add a camera-follow rig separately.
5. Press Play and test WASD/arrow keys, Space, Left Shift, and left mouse/J for attacks.

## Create an enemy test
1. Create a Capsule and name it `AshenKnight`.
2. Add `NinaHealth` and `NinaEnemyAI`.
3. Assign Nina's Transform to the enemy's `target` field.
4. Position the enemy a short distance from Nina.
5. Test basic pursuit and damage. This is placeholder AI; it does not yet include navigation meshes, animation, telegraphs, stagger, or boss phases.

## Mobile controls
The controller exposes public methods that Unity UI Buttons can call:
- `NinaPlayerController.SetMoveInput(Vector2)`
- `NinaPlayerController.Jump()`
- `NinaPlayerController.Dodge()`
- `NinaCombatController.Attack()`
- `NinaBloodMagic.BloodSpike()`
- `NinaBloodMagic.BadBlood()`
- `NinaBloodMagic.BloodTimes()`

A virtual joystick needs a UI drag handler that passes its normalized X/Y values to `SetMoveInput` and resets to zero on release. UI Buttons can invoke the other methods via their OnClick events. A proper touch HUD still needs to be created.

## Before an Android release
- Fix and verify all compiler warnings/errors in the chosen Unity version.
- Add real character rigs, animation clips, sound, UI and input handling.
- Implement camera collision, lock-on, combat states, robust enemy navigation and save/load.
- Profile on actual Android hardware; reduce draw calls, materials, shadows and spawned objects.
- Set package name, orientation, icon, version and signing key in Player Settings.
- Build and test an APK/AAB in Unity. This repository has not yet produced a build.
