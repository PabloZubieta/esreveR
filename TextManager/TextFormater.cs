using System;
using System.Collections.Generic;

namespace TextManager
{
    public class TextFormater
    {
        #region public methods
        public string Reverse(string textToReverse)
        {

            // en vrai de vrai de je trouve ça très moche je l'aurais fait avec une
            // fonction recursive qui passe la string et l'operateur de split mais
            // vous nous avez dit ne pas toucher au rgument de la fonction
            // on voit clairement que cette boucle est presque toujours la meme.


            // on retire le point avant de faire la conversion
            textToReverse = textToReverse.Remove(textToReverse.Length - 1, 1);

            //separe les phrases entre elles et on les recopient dans un nouveau array
            String[] splitted_point = textToReverse.Split(". ");
            

            int length_point = splitted_point.Length;
            String[] complete_point = new string[length_point];

            for (int k = 0; k < length_point; k++)

            {
                //on reduit la première lettre
                char[] min = splitted_point[k].ToCharArray();
                min[0] = char.ToLower(min[0]);
                splitted_point[k] = new string(min);
                //separe les demi-phrases entre elles et on les recopient dans un nouveau array
                String[] splitted_coma = splitted_point[k].Split(", ");
                int length_coma = splitted_coma.Length;
                String[] complete_coma = new string[length_coma];


                for (int i = 0; i < length_coma; i++)
                {
                    //separe lesmots entre eux et on les recopient dans un nouveau array
                    String[] splitted_space = splitted_coma[i].Split(" ");
                    int length_space = splitted_space.Length;
                    String[] complete_space = new string[length_space];
                    for (int j = 0; j < length_space; j++)
                    {
                        //on inverse les places
                        complete_space[(length_space - 1) - j] = splitted_space[j];
                        Console.WriteLine(splitted_space[j]);
                    }
                    //on recachetene
                    splitted_coma[i] = string.Join(" ", complete_space);

                    Console.WriteLine(splitted_coma[i]);

                    //on inverse les places et on recachetene
                    complete_coma[(length_coma - 1) - i] = splitted_coma[i];
                }

                
                splitted_point[k] = string.Join(", ", complete_coma);

                Console.WriteLine(splitted_point[k]);

                // première lettre en majuscule
                complete_point[(length_point - 1) - k] = splitted_point[k];
                char[] Caps = complete_point[(length_point - 1) - k].ToCharArray();
                Caps[0] = char.ToUpper(Caps[0]);
                complete_point[(length_point - 1) - k] = new string(Caps);

            }
            //on recachetène 
            string res_point = string.Join(". ", complete_point);
            res_point.Remove(res_point.Length - 1, 1);
            //on rajoute le point de fin
            res_point += ".";
            Console.WriteLine(res_point);
            return res_point;
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
