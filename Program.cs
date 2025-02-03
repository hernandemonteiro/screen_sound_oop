using ScreenSound.Models;

class Program
{
    static void Main(string[] args)
    {
        Band band1 = new Band("Vicetone");
        band1.AddStars(5);
        band1.AddStars(4);
        band1.AddStars(3);
        Album album = new Album("Top 1");
        album.AddMusic(new Music("Astronomia", band1, 195, true));
        band1.AddAlbum(album);

        Band band2 = new Band("João Gomes");
        band2.AddStars(5);
        band2.AddStars(5);
        band2.AddStars(4);
        Album album2 = new Album("Top 2");
        album2.AddMusic(new Music("Meu Dengo", band2, 180, false));
        band1.AddAlbum(album2);

        Band[] bands = { band1, band2 };


        foreach (Band band in bands)
        {
            band.ShowDiscography();
            band.ShowStars();
        }
    }

}