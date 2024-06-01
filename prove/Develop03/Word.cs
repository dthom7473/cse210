public class Word
{
    private string word;
    private bool isHidden;

    public Word(string word)
    {
        this.word = word;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetWord()
    {
        if (isHidden)
        {
            return new string('_', word.Length);
        }
        else
        {
            return word;
        }
    }
}
