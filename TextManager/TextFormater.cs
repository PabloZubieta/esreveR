using System;
using System.Collections.Generic;

namespace TextManager
{
    public class TextFormater
    {
        #region public methods
        public string Reverse(string textToReverse)
        {
            string formatted = Format(textToReverse,true);
            String[] splitted = formatted.Split(" ");
            String[] reversed = new string[splitted.Length];

            for (int i = splitted.Length - 1; i >= 0; i--)
            {
                reversed[(reversed.Length - 1) - i] = splitted[i];
            }
            String res = String.Join(" ", reversed);

            res = Format(res, false);

            return res;
        }
        #endregion public methods

        #region private methods
        private string Format(string textToFormat,bool lower) {
            string formated;
            if (lower)
            {
                formated = textToFormat.Remove(textToFormat.Length - 1, 1);
                formated = formated.ToLower();


            }
            else {
                char[] caps = textToFormat.ToCharArray();
                caps[0] = char.ToUpper(caps[0]);

                formated = new string(caps);
               formated += ".";

            }
            
            return formated;
        }


        #endregion private methods
    }
}
