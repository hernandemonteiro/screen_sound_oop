namespace ScreenSound.Models;
class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public double Duration { get; private set; }
    public bool Available
    {
        get; private set;
    }
    private bool formattedDuration = false;
    public string Description => $"{Name} - {Artist}";

    public Music(string name, Band artist, int duration, bool available)
    {
        this.Name = name;
        this.Artist = artist;
        this.Duration = duration;
        this.Available = available;
    }

    public Music SetAvailable(bool available)
    {
        Available = available;
        return this;
    }


    public Music FormatDuration()
    {
        Duration = Duration / 60;
        formattedDuration = true;
        return this;
    }

    public void ShowMusicInfo()
    {
        Console.WriteLine($"\nName: {Description}");
        Console.WriteLine($"Duration: {Duration}{(formattedDuration ? "m" : "s")}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Available: {(Available ? "Yes" : "No")}");
    }
}
