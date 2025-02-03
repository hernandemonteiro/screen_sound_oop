namespace ScreenSound.Models;
internal class Band
{
    public string Name { get; }
    private List<Album> albums = new List<Album>();
    private List<Assessment> assessments = new List<Assessment>();
    private double AverageAssessments
    {
        get
        {
            if (assessments.Count == 0)
            {
                return 0;
            }

            return assessments.Average(assessment => assessment.Note);
        }
    }

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
        foreach (Album album in albums)
        {
            album.ShowAlbumInfo();
        }
    }

    public void AddStars(int note)
    {
        this.assessments.Add(new Assessment(note));
    }

    public void ShowStars()
    {
        Console.WriteLine($"{Name}: {Math.Round(AverageAssessments, 2)} stars");
    }




}
