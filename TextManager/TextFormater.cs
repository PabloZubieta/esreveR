using System;
using System.Collections.Generic;

namespace TextManager
{
    public class TextFormater
    {
        #region public methods
        public string Reverse(string textToReverse)
        {
            textToReverse = textToReverse.Remove(textToReverse.Length - 1, 1);
            textToReverse = textToReverse.ToLower();

            String[] splitted = textToReverse.Split(" ");
            String[] reversed = new string[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                reversed[(reversed.Length - 1) - i] = splitted[i];
            }
            String res = String.Join(" ", reversed);
            
            char[] Caps = res.ToCharArray();
            Caps[0]= char.ToUpper(Caps[0]);

            res = new string(Caps);
            res += ".";

            return res;
            //throw new NotImplementedException();
        }


        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
