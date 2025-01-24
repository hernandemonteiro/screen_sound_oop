namespace ScreenSound.Models;
class Band
{
    public string Name { get; }
    private List<Album> albums = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"\nBand: {Name}");
        foreach (Album album in albums)
        {
            album.ShowAlbumInfo();
        }
    }


}
