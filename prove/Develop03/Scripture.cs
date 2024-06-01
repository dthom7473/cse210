using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string book;
    private int chapter;
    private int verse;
    private string text;
    private List<Word> words;

    public Scripture(string book, int chapter, int verse, string text)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.text = text;
        words = new List<Word>();
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] verseWords = text.Split(' ');
        foreach (string word in verseWords)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<int> nonHiddenIndexes = Enumerable.Range(0, words.Count).Where(i => !words[i].IsHidden()).ToList();

        int wordsToHide = Math.Min(3, nonHiddenIndexes.Count);

        nonHiddenIndexes = nonHiddenIndexes.OrderBy(x => random.Next()).ToList(); // Shuffle non-hidden indexes
        for (int i = 0; i < wordsToHide; i++)
        {
            words[nonHiddenIndexes[i]].Hide();
        }
    }
    public string DisplayScripture(bool replaceWithUnderscores = false)
    {
        string displayedVerse = $"{book} {chapter}:{verse}\n";
        foreach (Word word in words)
        {
            if (replaceWithUnderscores && !word.IsHidden())
            {
                displayedVerse += new string('_', word.GetWord().Length) + " ";
            }
            else
            {
                displayedVerse += word.GetWord() + " ";
            }
        }
        return displayedVerse.Trim();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
