using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Pratica_GIT
{
    public class Libro
    {
        internal string autore { get; set; }
        internal string titolo { get; set; }

        internal int anno { get; set; }
        internal string editore { get; set; }
        internal int nPagine { get; set; }

        static string ReadingTime(int nPagine)
        {
            string tempo = "";
            if (nPagine < 100)
            {
                tempo = "1 ora";
            }
            else
            {
                if (nPagine < 200 && nPagine > 100)
                {
                    tempo = "2 ore";
                }
                else
                {
                    if(nPagine > 200)
                    {
                        tempo = "3 ore";
                    }
                }
            }
            return tempo;
        }

        static string ToString(string autore, string titolo, int anno, string editore, int nPagine)
        {
            string finale = "L'autore del libro è " + autore + ", il titolo del libro è " + titolo + ", il quale libro è uscito nell'anno " + anno + ", dalla casa editrice " + editore + ". Il libro ha " + nPagine + "pagine";
            return finale;
        }
    }
}
