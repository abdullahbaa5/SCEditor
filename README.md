# Supercell SC Editor - with viewer

### Features (Basic)

- Decompress (LZHAM, LZMA, ZSTD) (Version ~3, 4) SC Files
- Compress Back to (LZHAM, LZMA, ZSTD) Format, in Version 3 and Version 4 (Metadata not implemented)
- View Each Export/Movieclip Animated Preview
- View Shape/Chunks
- View Textfields (not fully implemented)
- Edit/Add Textures
- Edit/Add Matrix
- Edit/Add Colorspaces
- Edit Export/Moveclip Shapes Data (Add and Remove Shapes)
- Edit Export/Moveclip frames data (Add and Remove MoveclipFrames)]
- Clone Export/Movieclip/Shape/Chunk as a new object
- Save any of the mention editions back to uncompressed file

### Custom Features (Main)

####- Add your own custom sprites
Yes, You are able to add your own Character/Building.

No, it will not be fully automated, You may have to mess around with how many frames you want by manually editing it afterwards.

This tool uses another software (paid version of it) called [TexturePacker](https://www.codeandweb.com/texturepacker "TexturePacker"). It is used to convert each of the Animations Frames Shapes into a single Texture.

####- Combine 2 SC Files Data Together
Combine 2 SC Files together while having the ability to choose which exports to import from the second SC File.

This feature also uses [TexturePacker](https://www.codeandweb.com/texturepacker "TexturePacker") - Paid Version, to combine all the exports back to a single texture.

It will import full Export data and save it as a new Export in the file (this includes importing the correct Matrix, Colorspaces too).

- If you import the whole file the whole texture is copied else generated by TexturePacker.
- You can choose to use importing sc objects to instead use the main files one
(For example: if you import a character from another file with each export having shadow shape with id 50, while you have a shadow already in your current file, you can enter the ids to make sure that shape with id 50 is not imported but replaced by the one in original file)

####- Live Edit a Export/Movieclip data
This will help with manually adjusting the x,y position of the Shape in the Object.
You can either choose to move the shapechunk's x,y position directly (this will effect all the Exports/Movieclips using that specific shapechunk) or generate a matrix which can be replaced for the specific shape in the moveclips frames data

#### Known Bugs/Issues/Incompeted Features
> One of the basic rules of the universe is that nothing is perfect. Perfection simply doesn't exist.....Without imperfection, neither you nor I would exist - Stephen Hawking

The tools works perfectly but may cause glitches that may not cause much inconvience.

- V4 saving bypassed/skipped for now (METADATA generation for v4 is unknown)
- Cloning will reflect changes to the original unless the file is save and reopened (prolly due to variable references being soft cloned)
- Live editing a Export/Movieclip may hang sometimes (Yet to optimize the animation renderer for it)
- A custom sprites generator so TexturePacker is not required.
- FOR DEVS: Alot of code being repeated, unused code, and no single library handling the rendering

#### Additional Information

The above information may not be complete and does not yet provide a step by step guide for how everything is done.

The tool is able to perform all the features mentioned above but may crash for some certain feature tho it works you just have to try and avoid doing things in a certain way that may cause a crash.

This tool has been in use for creating alot of custom mods for the past few years.
As it works in its messy but optimized state, I do not plan on rewriting a clean code version of it for a while.

If requested enough, I will create a video guide for how the editor flow works for the main features.