# Audio Stream Generator
This tool is used to create a consistent stream of music and ambiance! The sound effects and music are to be provided. It randomly delays the effects as the user desires. It is relatively easy to use, with many parameters to tune and create the perfect random ambiance.
I suggest familiarizing oneself with the Unity Audio Mixer, but technically it is not required.
## How to Use
### Installation
1. Download the above ASG.unitypackage
<img width="903" height="275" alt="image" src="https://github.com/user-attachments/assets/3a3a491c-9ec4-4628-820d-11f09ba86b27" />
2. Import it into your unity project of choice.
3. Drag the AudioStreamGenerator prefab into your scene. Note that it does NOT carry between scenes, though you may add this yourself. It can be found in Audio/ASG/Prefabs
<img width="1473" height="942" alt="image" src="https://github.com/user-attachments/assets/112229b8-be0f-4f9b-b950-5c6b8a8da2bd" />

### Clip Import
1. On the importer child, specify the desired folders and the various options.
<img width="442" height="602" alt="image" src="https://github.com/user-attachments/assets/d8b9c740-28c5-47df-b11f-390c90d6f6a2" />
2. Click import music, import ambiance, or import both.
3. Return to the main gameObject. The list of audio clips should have been updated! Simply adjust parameters and run the tool.
<img width="447" height="782" alt="image" src="https://github.com/user-attachments/assets/b50f3c8c-f8e4-43cc-bd99-b4468def5dfa" />

### Fine Tuning
Note that this tool does NOT update midway through the play session in many cases. Play with it by stopping and starting the scene, and see the parameter section below.
## Parameters
### Audio Manager
Do not edit any items in the audio manager. It is entirely for in-game usage.
### Stream Generator
General Settings
- Tracks
	- How many ambiance objects play at once. They are all on their own delays, so will stack. Increasing this will add to how much simultaneous noise is in the scene, decreasing it will decrease simultaneous noise.

Delay

- Delay Between ambiance
	- How long, on average, the ambiance object should wait before playing the next ambiance clip.
- Random Delay Between Ambiance
	- How far the real delay can deviate from the average. This is floored at 0.

Fade

- Fade Control
	- What percentage of the clips are spent fading in or out.

Perlin

- Perlin Volume
	- Whether or not to add small modifications to volume based off perlin noise.
- Volume variation
	- How much the perlin volume variation can change from the base volume

Clips

- Volume
	- How loud the clip is.
- Priority
	- How likely the clip is to be chosen next. Increasing by 1 nearly doubles chance of being chosen (1->20 to 2->21), and so forth.
### Importer

Target
- Do not modify the target generator. It is the parent gameobject.

Resource Folders
- Destinations
	- The destination of the music/ambiance folders (from root, including assets)
- Subfolders?
	- Whether or not to search in the various subfolders of these folders. May be bugged.

Defaults
- Sets defaults for imported clips of volume and priority above.

Import Behavior
- Clear target list first
	- If there are already clips, clear them first.
- Skip duplicates
	- If a clip has a clip of the same name in the list, skip importing that one.

Parse Metadata
- If the clip is named a certain way, as: `name__v0.8__p5`, where what follows v is volume and what follows p is priority, it will import with that volume and priority.

Import Tools
- Click to import to the AudioStreamGenerator!

### Audio Mixer
Change volume in the audio mixer! There are also many, many effects to add. I encourage you to research it!
### Volume Manager
The default master volume, music, and ambiance settings can be adjusted to maintain a consistent volume as set by the user between play sessions. This is by default set to 1, but if sliders edit this, they will update the audio mixer.
### Ambiance Prefab
Technically, you can directly change the ambiance prefab's parameters, though I wouldn't recommend it. Everything is replaced by existing parameters except for speed and smoothing.
- Speed
	- How far each call of the perlin noise goes.
- Smooth
	- How smooth the transition between perlin and fade calls are.
## Additional Features
### Volume Control
The volume control can be called from other scripts, which will update the user's audio preferences for future launches. For example, if you create a slider that links to user preference of ambiance volume, music volume, and both, you can allow them to permanently adjust this.
