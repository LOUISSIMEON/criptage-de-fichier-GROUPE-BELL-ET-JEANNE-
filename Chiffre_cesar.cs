using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_cryptage
{
    class Chiffre_cesar
    {
        static char[] lettre;
        static int rang;

        // ce constructeur prend l'afabet normal, le decalage entré, le texte entré, l'acces pour savoir si on est sur le bouton chiffrer ou dechiffrer et le texte à dechiffrer
        public Chiffre_cesar(char[] alfa1, int num, ref string phraseclair, int acces, ref string phrasechiffre)
        {
            
            if (acces==0)  // si le bouton est chiffrer
	        {
		      lettre = new char[phraseclair.Length]; 
              phrasechiffre = "";
              phraseclair = phraseclair.ToUpper(); //on transforme le texte entré tout en majuscule pour eviter des problemes de scates
            Boolean exite = false;   // ce booleen nous aidera a savoir si une lettre entrée en dans notre tableau de lettres
                for (int i = 0; i < lettre.Length; i++)
                {
                    lettre[i] = char.Parse(phraseclair.Substring(i, 1));  //on recupere lettre par lettre, le texte entré
                }

               
            for (int i = 0; i < lettre.Length; i++)
            {
                exite = false;
                for (int j = 0; j < alfa1.Length; j++)
                {

                    if (lettre[i] == alfa1[j])        //si la lettre du texte entré est dans le tableau de lettres
                    {

                        rang = (j + num) % 26;        //alors à son rang on additionne le decalage et on recupere le reste apres division par 26
                                                      //ceci nous permet de trouver la position de la lettre qui remplacera l'original en tenant compte qu'elle ne depasse pas 26
                        exite = true;                 //si la lettre entrée esr dans notre tableau de lettres exite prend true
                    }

                }
                if (exite == true)  //exite est à true on met la nouvelle lettre appelé lettre chiffré
                {
                    phrasechiffre = phrasechiffre + alfa1[rang];
                }
                if (exite == false)  //sinon on remet la meme lettre original
                {
                    phrasechiffre = phrasechiffre + lettre[i];
                }

            }   
	        }

            if (acces == 1)  // si le bouton est dechiffrer
	        {
		        lettre = new char[phrasechiffre.Length];

                phraseclair = "";
                Boolean exite = false;
                for (int i = 0; i < lettre.Length; i++)
                {
                    lettre[i] = char.Parse(phrasechiffre.Substring(i, 1));  ////on recupere lettre par lettre, le texte entré
                }

                for (int i = 0; i < lettre.Length; i++)
                {

                    exite = false;
                    for (int j = 0; j < alfa1.Length; j++)
                    {

                        if (lettre[i] == alfa1[j])  //si la lettre du texte chiffré est dans le tableau de lettres
                        {

                            rang = (j - num) % 26;  //alors à son rang on soustrait le decalage et on recupere le reste apres division par 26
                            //ceci nous permet de trouver la position de la lettre original qui remplacera lettre du texte chiffré
                            if (rang<0)
                            {
                                rang = 26 + rang; //cependant si en soustrayant on obtient un rang negatif on considere la position 26 auquel on soustrait ce rang negatif  
                            }
                            exite = true;

                        }

                    }
                    if (exite == true)  //exite est à true on met la nouvelle lettre appelé lettre originale
                    {
                        phraseclair = phraseclair + alfa1[rang];
                    }
                    if (exite == false)  //exite est à false on remet la meme lettre 
                    {
                        phraseclair = phraseclair + lettre[i];
                    }

                }

               
	        }
        }

    }
}
