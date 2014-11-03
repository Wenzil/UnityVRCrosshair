UnityVRCrosshair
===============

General-purpose VR enabled crosshair powered by Unity 4.6 UI

## About This Project
I want to make a VR enabled crosshair and open source it to the Unity and Oculus community. My goal is to reach the level of quality and polish of the crosshair implementation in the game TimeRifters.

It is just an empty project shell now, but I intend to start working on it this week. Anyone interested to work with me is welcome.

Some more details about what I want to accomplish:
- The crosshair should be able to interact any uGUI element or gameobject in the scene through raycasting
- The crosshair image should be appear at the depth of the object it is pointing at
- Eventually I want to support a handful of control schemes like head aim, keyhole, decouple pitch, etc.
- Mouse and eventually gamepad support

The crosshair should be suitable for first-person shooters as well as general 3D UI and world interaction. It should integrate well with the New UI system in Unity 4.6.

## Project Dependencies and Requirements
- The latest beta version of Unity 4.6 is required (currently b21). [Link](http://unity3d.com/unity/beta/4.6)
- The latest Unity 4 Integration package of the Oculus VR SDK is required (currently 0.4.3). [Link](https://developer.oculusvr.com/?action=dl)
- Once Unity 4.6 and Unity 5.0 are out of beta, both will be supported as soon as possible.
- Oculus Rift DK2 hardware is required.
- Support for GearVR and CV1 should follow eventually.
