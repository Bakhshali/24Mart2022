using System;
using System.Collections.Generic;
using System.Text;

namespace Extention_Task
{
    static class Extention
    {
        public static bool Example(this string word, string words)
        {
            int i = 0;
            if (char.IsUpper(word[i]))

                foreach (char letter in word)                                          
                {
                    if (letter == word.Length)
                    {
                        i++;
                    }
                    else if (!char.IsLower(word[i]))
                    {
                        return true;
                    }
                    return false;
                }                         
            return false;
        }
    }
}
