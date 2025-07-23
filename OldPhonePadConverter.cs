using System;
using System.Collections.Generic;
using System.Text;

public class OldPhonePadConverter
{
    public static string OldPhonePad(string input)
    {
        // check null or empty
        if (string.IsNullOrWhiteSpace(input))
            return "";

        var keyMappings = new Dictionary<char, string>
        {
            { '1', "&,(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        var msg = new StringBuilder();       // keep output
        var buf = new StringBuilder();     // keep digit press

        foreach (char ch in input)
        {
            if (ch == '#')
            {
                // end, convert last
                TranslateDigits(buf, keyMappings, msg);
                break;
            }
            else if (ch == '*')
            {
                // backspace
                TranslateDigits(buf, keyMappings, msg);
                buf.Clear();

                if (msg.Length > 0)
                    msg.Remove(msg.Length - 1, 1);
            }
            else if (ch == ' ')
            {
                // space
                TranslateDigits(buf, keyMappings, msg);
                buf.Clear();
            }
            else if (char.IsDigit(ch))
            {
                // press same key
                if (buf.Length == 0 || buf[0] == ch)
                {
                    buf.Append(ch);
                }
                else
                {
                    // press new key
                    TranslateDigits(buf, keyMappings, msg);
                    buf.Clear();
                    buf.Append(ch);
                }
            }
            else
            {
                // not handle 
            }
        }

        return msg.ToString();
    }

    private static void TranslateDigits(StringBuilder digits, Dictionary<char, string> map, StringBuilder output)
    {
        if (digits.Length == 0) return;

        char key = digits[0];
        int timesPressed = digits.Length;

        if (map.ContainsKey(key))
        {
            var letters = map[key];
            int index = (timesPressed - 1) % letters.Length;

            output.Append(letters[index]);
        }
        else
        {
            // unknown key
        }

        digits.Clear(); // clear buffer after use
    }
}
