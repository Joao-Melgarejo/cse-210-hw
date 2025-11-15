using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = _random.Next(_words.Count);
            Word word = _words[index];

            if (!word.isHidden())
            {
                word.hide();
                hiddenCount++;
            }

            // Si todas las palabras ya están ocultas, salir del bucle
            if (IsCompletelyHidden())
                break;
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.TotalReference()}-{scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
                return false;
        }
        return true;
    }
}