using System.Collections.Generic;

public class Scripture
{
    private Reference _reference = new Reference();

    private List<Word> _words = new List<Word>();

    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
    }


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsList = text.Split(' ');
        foreach (var word in wordsList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();    
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        List<string> wordList = new List<string>();
        foreach (var word in _words)
        {
            string text = word.GetDisplayText();
            wordList.Add(text);
        }
        string joinedWords = string.Join(" ", wordList);
        
        return $"{reference} {joinedWords}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}