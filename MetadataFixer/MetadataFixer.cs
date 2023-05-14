using File = TagLib.Flac.File;

namespace MetadataFixer;

public static class MetadataFixer
{
    public static event Action<string> OnError;

    public static void Fix(DirectoryInfo start, DirectoryInfo end)
    {
        // Loop through all files
        foreach (FileInfo file in start.EnumerateFiles())
        {
            Song? song = ProcessFile(file);
            if (song is null) continue;
            MoveSong(song, end);
        }
    }

    private static Song? ProcessFile(FileInfo file)
    {
        if (!file.Exists)
        {
            OnError($"Could not find the file at the path: {file.FullName}");
            return null;
        }

        if (file.Extension != ".flac")
        {
            OnError($"The extension '{file.Extension}' is not supported!");
            return null;
        }

        File flacFile = new(file.FullName);
        return new Song(
            file,
            flacFile.Tag.JoinedAlbumArtists,
            flacFile.Tag.Album,
            (int)flacFile.Tag.Track,
            flacFile.Tag.Title
        );
    }

    private static void MoveSong(Song song, DirectoryInfo end)
    {
        DirectoryInfo artistDir = new($"{end.FullName}/{song.Artist}/");
        if (!artistDir.Exists) artistDir.Create();

        DirectoryInfo albumDir = new($"{end.FullName}/{song.Artist}/{song.Album}");
        if (!albumDir.Exists) albumDir.Create();

        string newFileName =
            $"{end.FullName}/{song.Artist}/{song.Album}/{song.TrackNumber} - {song.Title}{song.OldFile.Extension}";
        song.OldFile.CopyTo(newFileName);
    }
}