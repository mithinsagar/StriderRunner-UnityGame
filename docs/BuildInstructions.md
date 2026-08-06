# Build Instructions

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

Strider Runner is a standard Unity project. It can be built to any target
supported by your Unity Editor install. This document covers the common
targets.

## Prerequisites

- Unity Hub.
- A Unity Editor version compatible with the value in
  `ProjectSettings/ProjectVersion.txt` (2022 LTS or later recommended).
- The build support modules for your intended target platform, installed
  through Unity Hub.

## Common Steps

1. Open Unity Hub and click "Open". Choose the project root folder.
2. When the Editor finishes importing, open `File -> Build Settings`.
3. Confirm the "Scenes In Build" list contains, in order:
   - `Assets/Scenes/Start Screen.unity`
   - `Assets/Scenes/Level1.unity`
   - `Assets/Scenes/Level2.unity`
   - `Assets/Scenes/Level3.unity`
   - `Assets/Scenes/Level4.unity`
   - `Assets/Scenes/Level5.unity`
   - `Assets/Scenes/Level6.unity`
   - `Assets/Scenes/Level7.unity`
   - `Assets/Scenes/End Screen.unity`
   If any scene is missing, drag it from the Project window into that list.
4. Select the target platform, click "Switch Platform" if not already active.
5. Click "Build" and choose an output directory.

## Windows Standalone

- Target platform: Windows.
- Architecture: x86_64.
- The build produces an executable and a `_Data` folder. Ship both.

## macOS Standalone

- Target platform: macOS.
- The build produces a `.app` bundle.
- Code signing is not configured in this repository. If you plan to ship on
  macOS, sign and notarise the build separately.

## Linux Standalone

- Target platform: Linux.
- Architecture: x86_64.
- The build produces an executable, a `_Data` folder, and a shared object.

## WebGL

- Target platform: WebGL.
- In `Player Settings -> Publishing Settings` set Compression to Gzip and
  disable Development Build for a release deploy.
- Serve the output through a static host that supports the right MIME types.

## Android

- Install the Android Build Support module including the SDK, NDK, and JDK.
- Set a keystore in `Player Settings -> Publishing Settings` for signed
  release builds.
- Build to APK for direct install or AAB for Google Play.

## iOS

- Requires macOS with Xcode installed.
- Build produces an Xcode project. Open it in Xcode and archive from there.

## Troubleshooting

- Missing package errors: delete `Library/` and reopen the project so Unity
  re-imports.
- Input actions not firing: verify the Input System is enabled in
  `Player Settings -> Configuration -> Active Input Handling` set to either
  `Input System Package (New)` or `Both`.
- TextMesh Pro warning about missing essentials: use
  `Window -> TextMeshPro -> Import TMP Essential Resources`.
