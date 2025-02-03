namespace ScreenSound.Models;
using ScreenSound.interfaces;

internal class Assessment : IAssessment
{
    public int Note { get; private set; }

    public Assessment(int note)
    {
        this.Note = note;
    }
}
