using System;
using System.Text;

public class StringExtractor
{
    public string ExtractEnding(string text, int count)
    {
        if (count > text.Length)
        {
            return text;
        }

        StringBuilder result = new StringBuilder();
        for (int i = text.Length - count; i < text.Length; i++)
        {
            result.Append(text[i]);
        }

        return result.ToString();
    }
}
