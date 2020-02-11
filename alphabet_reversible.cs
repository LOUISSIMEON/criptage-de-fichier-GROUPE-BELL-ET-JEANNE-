using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_cryptage
{
    class alphabet_reversible
    {
         static char[] lettre;
        static int rang;

        public alphabet_reversible(char[] alfareversible, int num, ref string phraseclair, int acces, ref string phrasechiffre)
        {
            if (acces == 0)
            {
                lettre = new char[phraseclair.Length];
                phrasechiffre = "";
                phraseclair = phraseclair.ToUpper();
                Boolean exite = false;
                for (int i = 0; i < lettre.Length; i++)
                {
                    lettre[i] = char.Parse(phraseclair.Substring(i, 1));
                }


                for (int i = 0; i < lettre.Length; i++)
                {
                    exite = false;
                    for (int j = 0; j < alfareversible.Length; j++)
                    {

                        if (lettre[i] == alfareversible[j])
                        {

                            rang = (j + num) % 26;
                            exite = true;

                        }

                    }
                    if (exite == true)
                    {
                        phrasechiffre = phrasechiffre + alfareversible[rang];
                    }
                    if (exite == false)
                    {
                        phrasechiffre = phrasechiffre + lettre[i];
                    }

                }
            }

            if (acces == 1)
            {
                lettre = new char[phrasechiffre.Length];

                phraseclair = "";
                Boolean exite = false;
                for (int i = 0; i < lettre.Length; i++)
                {
                    lettre[i] = char.Parse(phrasechiffre.Substring(i, 1));
                }

                for (int i = 0; i < lettre.Length; i++)
                {

                    exite = false;
                    for (int j = 0; j < alfareversible.Length; j++)
                    {

                        if (lettre[i] == alfareversible[j])
                        {

                            rang = (j + num) % 26;
                            exite = true;

                        }

                    }
                    if (exite == true)
                    {
                        phraseclair = phraseclair + alfareversible[rang];
                    }
                    if (exite == false)
                    {
                        phraseclair = phraseclair + lettre[i];
                    }

                }


            }
        }
        
    }
}
