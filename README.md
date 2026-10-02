# FOUND SIGNAL
This is a mod for UNBEATABLE that lets you play your own videos in the playback stage to existing vanilla and DLC songs, even over songs that already have an existing video.

This is an unofficial mod that is not endorsed by D-CELL GAMES in any way.

> [!CAUTION]
> DO NOT RENAME THE BASE MOD FOLDER AND VIDEOS FOLDER! The base folder and videos folder must have their default names for the mod to work!

## Installation
This works alongside [BepInEx 5](https://github.com/bepinex/bepinex), you should be able to throw the base FOUNDSIGNAL folder that contains the plugin and Videos folder into \<UNBEATABLE path>\/BepInEx/plugins.

## Usage
To have the videos play, the videos must be in the mp4 format with the title being "\[song internal name\].mp4" in the Videos folder that the mod comes in. You can find the internal names by running the game with the plugin, loading the song in Arcade mode, and then checking LogOutput.log in the base BepInEx folder. 

> [!TIP]
> The videos are also called on every load of a chart, so you don't have to restart the game to have the video be recognized.

## General Tips with Video Sync
To sync videos properly, I'd recommend grabbing the audio for the video, extracting the song audio from the game (tool to do so is [here](https://github.com/Wouldubeinta/Fmod-Bank-Tools)), then dropping them both in Audacity or another audio tool. After that, you should get the difference between each audio track's first beat, then pop open a video editor and edit the video accordingly.
