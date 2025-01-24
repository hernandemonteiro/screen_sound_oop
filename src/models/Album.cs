namespace ScreenSound.Models;
class Album
{
    private List<Music> musics = new List<Music>();
    public string Name { get; set; }

    public Album(string name)
    {
        Name = name;
    }

    public double TotalDuration { get; set; }

    public void AddMusic(Music music)
    {
        musics.Add(music);
        TotalDuration += music.Duration;
    }

    public void ShowAlbumInfo()
    {
        Console.WriteLine($"\nAlbum: {Name}");
        Console.WriteLine($"Total Duration: {TotalDuration}m");
        Console.WriteLine("\nMusics:");
        foreach (Music music in musics)
        {
            music.ShowMusicInfo();
        }
    }
}
