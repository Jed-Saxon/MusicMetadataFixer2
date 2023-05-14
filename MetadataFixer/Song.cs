namespace MetadataFixer;

internal class Song
{
    public Song(FileInfo oldFile, string artist, string album, int trackNumber, string title)
    {
        OldFile = oldFile;
        Artist = artist;
        Album = album;
        TrackNumber = trackNumber;
        Title = title;
    }

    public FileInfo OldFile { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int TrackNumber { get; set; }
    public string Title { get; set; }
}