#BlightfallMapper

Mapper that reads a minecraft world file and show a map of what part of the world is still tainted.

Replicates map aboard The Jaded.

Writes bitmaps to disk for use in making timelapses.

To make timelapse video/gifs:

```
ffmpeg -framerate 30 -pattern_type glob -i '*.png' -c:v libx264 -pix_fmt yuv420p out_30fps.mp4
ffmpeg -framerate 15 -pattern_type glob -i '*.png' -c:v libx264 -pix_fmt yuv420p out_15fps.mp4
ffmpeg -i out_15fps.mp4 -r 15 -cf scale=512:-1 testgif.gif
ffmpeg -i out_15fps.mp4 -r 15 -vf scale=1024:-1 testgif.gif
```
