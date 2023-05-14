# MusicMetadataFixer2
My 'legally sourced music' is 'legally sourced' with metadata, but not in a nice format (in terms of directory structure). This project intends to solve that issue by getting said metadata out of the file and moving it into the directory `/Artist/Album/# - Title.flac`. It also only works with Flac files because I'm lazy. One day I'll come back and make this project a little more useful

## Usage
You should build from source as I have not released a standalone application yet. I'll eventually get to that... Once you install it, just run the program, enter the start directory (unsorted files) and end directory (where you want your sorted files to go) and it will do the rest for you

## Build from source
1. Clone the repository
2. Bulid the project: `dotnet build -c Release;`
3. CD into the build output: `cd ConsoleUI/bin/Release/net7.0`
4. Run the program: `dotnet ConsoleUI.dll`

## Help
I have no idea what to call this project as the name is misleading. It doesn't 'fix' metadata. It does fix the files based on the metadata from each file. However, I don't know what repo name I could use that doesn't sound clunky
