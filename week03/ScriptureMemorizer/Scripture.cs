using System;

class Scripture
{
    // atributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    // constructor
    public Scripture(Reference reference, string text)
    {
        int count = 0;
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (var word in words)
        {
            count = count + 1;
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }
    //methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            else
            {
                int index = random.Next(_words.Count);

                if (_words[index].IsHidden() == false)
                {
                    _words[index].Hide();
                }
                else
                {
                    while (_words[index].IsHidden() == true)
                    {
                        int newIndex = random.Next(_words.Count);
                        index = newIndex;
                    }
                    _words[index].Hide();
                }
            }



        }


    }

    public string GetDisplayText()
    {
        string allText;

        allText = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            allText = allText + word.GetDisplayText();
        }

        return allText;
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = true;

        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                completelyHidden = false;
            }

        }

        return completelyHidden;
    }

}