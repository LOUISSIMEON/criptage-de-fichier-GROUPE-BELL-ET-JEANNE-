using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_cryptage
{
    class preparation_alfabet_reversible
    {
        static int u;
        public preparation_alfabet_reversible(string motcle, char[] alfa1, ref char[] alfareversible, ref string phraseclair, int acces, ref string phrasechiffre)
        {
            List<char> cle = new List<char>();
            Boolean f = false;
            if (motcle != null)
            {
                cle.Add(char.Parse(motcle.Substring(0, 1)));
            }
            for (int i = 0; i < motcle.Length; i++)
            {
                f = false;
                for (int j = 0; j < cle.Count; j++)
                {
                    if (char.Parse(motcle.Substring(i, 1)) == cle[j])
                    {
                        f = true;
                    }
                }
                if (f == false)
                {
                    cle.Add(char.Parse(motcle.Substring(i, 1)));
                }
            }
            motcle = "";
            for (int i = 0; i < cle.Count; i++)
            {
                motcle = motcle + cle[i];
            }
            motcle = motcle.ToUpper();
            for (int i = 0; i < cle.Count; i++)
            {
                cle[i] = char.Parse(motcle.Substring(i, 1));
            }
            u = 0;

            for (int i = 0; i < alfareversible.Length; i++)
            {
                if (u < cle.Count)
                {
                    alfareversible[i] = cle[u];
                    u = u + 1;
                }
            }
            for (int i = 0; i < alfa1.Length; i++)
            {
                f = false;
                for (int j = 0; j < cle.Count; j++)
                {
                    if (alfa1[i] == alfareversible[j])
                    {
                        f = true;
                    }
                }
                if (f == false && u <= 26)
                {
                    alfareversible[u] = alfa1[i];
                    u = u + 1;
                }
            }

            

            
          

            alphabet_reversible cesar = new alphabet_reversible(alfareversible, 13, ref phraseclair, acces, ref phrasechiffre);
        }
    }
}
