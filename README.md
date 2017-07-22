# HoloLens with Vuforia Sample (HLVuforiaSample)

Sample Code using Vuforia Image Target to designate a world postion without the need for continuous marker tracking on HoloLens.
Vuforia and Web Camera is turned-off after the image target/marker is located and HoloLens spatial tracking manages position tracking.

## Software Versions

1. Visual Studio 2017
2. Unity 2017.1.0f3
3. Microsoft Unity HoloToolkit v1.5.8.0
4. Vuforia 6.2.10 Unity SDK
5. Vuforia 6.2.10 Unity Core Samples Image Targets

## Setup Notes

1. Configure workstation for [HoloLens development](https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools)
2. Clone the Project (Contains HoloToolkit and Notes 3D Model and animation components)
3. Download Vuforia .unitypackage SDK dependencies
4. Import the Vuforia Unity SDK
5. Import the Vuforia Unity Sample Image Target Stones and Chips
6. Print the "Stones" target image on paper (A4 or USLetter)
7. Create an Eyewear App License Key and apply on the Vuforia ARCamera
7. Build and Deploy on HoloLens

## Usage

1. On HoloLens application Start-up, a rotating cube is displayed in front to indicate running application
2. Voice Command "Scan Marker" to enable Vuforia and Web Cam to detect the "Stones" printed image
3. When the marker is detected, an animated 3D Note is displayed and Vuforia + Web Camera is turned off
4. Move the "Stones" Printout and voice command "Scan Marker" again to re-position the 3D model
5. Additional voice command "Stop Scan" to turn off Vuforia + Web Camera   

## Notes

1. Vuforia SDK Components need to be installed separately due to account registration requirements
2. Only the sixteenth_note 3D Model and animation in the Free Unity Asset "The Notes" is included

## Software Dependencies

### Installation Required: 
**vuforia-unity-6-2-10.unitypackage**
https://developer.vuforia.com/downloads/sdk
(Account Registration Required)

**Vuforia Unity Core Samples - Image Targets**
vuforia-samples-core-unity-6-2-10.zip
https://developer.vuforia.com/downloads/samples
(Account Registration Required)

**"The Notes" by SaladMix Studio (FREE Download)**
Unity Asset Store 3D Note Model 
3D Models/Characters/Toons
https://www.assetstore.unity3d.com/en/#!/content/17964

**Microsoft HoloToolkit-Unity**
HoloToolKit 1.5.8.0
https://github.com/Microsoft/HoloToolkit-Unity
