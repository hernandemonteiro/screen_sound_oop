using ScreenSound.Models;

class Program
{
    static void Main()
    {
        Band band1 = new Band("Vicetone");
        Band band2 = new Band("João Gomes");
        Music[] musics = { new Music("Astronomia", band1, 195, true), new Music("Meu Dengo", band2, 180, false) };

        Album album = new Album("Top 1");
        Album album2 = new Album("Top 2");
        foreach (Music music in musics)
        {
            if (music.Artist.Name == "Vicetone")
            {
                album.AddMusic(music);
            }
            else
            {
                album2.AddMusic(music);
            }
        }

        band1.AddAlbum(album);
        band2.AddAlbum(album2);

        band1.ShowDiscography();
        band2.ShowDiscography();
    }

}