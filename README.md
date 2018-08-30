# Bug report

PNG images with 16 bits per channel are incorrectly imported with the content pipeline. Causing weird colours when rendering the texture.

Below you see the same two images. The left image is a texture created from an 8 bit per channel PNG image, and is correctly displayed. The right image is a texture created from the same image, stored as a 16 bit per channel PNG image. As you see the colours are incorrect.

![The bug](bug.png?raw=true "The bug")

Tested with MonoGame Framework / Pipeline Tool 3.6.0.1625