using System;
using System.IO;
using System.Linq;

namespace PgProtEn
{
    class BTTEncoder // Base64 To Text Encoder
    {
        private static string[] Base64Symbols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "/", "=" };

        private static string[] EncodingWords = { "Aperiam", "Belgium", "Children", "Document", "Elephant", "Future", "Goal", "Human", "Island", "Jump", "Kity", "Lorem", "Memory", "North", "Orbital", "Picture", "Quiet", "Roll", "Stone", "Trigger", "Unicorn", "Version", "Wave", "Xici", "Yorah", "Zombie",
            "and", "but", "chat", "diamond", "error", "for", "glass", "has", "iron", "joke", "kwin", "lime", "month", "negative", "open", "premium", "quick", "rock", "still", "time", "under", "vision", "water", "xerox", "yak", "zip",
            "null", "once", "tizer", "think", "finger", "force", "stars", "short", "egg", "night", "pulse", "flash", "river" };

        public static string Encode(string base64)
        {
            try
            {
                string result = "";
                char[] b64Char = base64.ToArray();

                for (int i = 0; i < b64Char.Length; i++)
                {
                    int encIndex = Array.IndexOf(Base64Symbols, b64Char[i].ToString());
                    result += EncodingWords[encIndex];

                    if(i != b64Char.Length - 1)
                    {
                        result += " ";
                    }
                }

                return result;
            }
            catch
            {
                throw new Exception("BTT Encoding Error");
            }
        }

        public static string Decode(string text)
        {
            try
            {
                string result = "";
                string[] encWords = text.Split(' ');

                for (int i = 0; i < encWords.Length; i++)
                {
                    int decIndex = Array.IndexOf(EncodingWords, encWords[i]);

                    if (decIndex == -1)
                    {
                        decIndex = EncodingWords.Length + decIndex;
                    }

                    result += Base64Symbols[decIndex];
                }

                return result;
            }
            catch
            {
                throw new Exception("BTT Decoding Error");
            }
        }
    }
}
