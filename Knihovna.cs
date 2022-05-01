using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Knihovna
    {
        protected int pocetKnih;
        protected int pocetZamestnancu;
        protected string jmenoMajitele;
        protected string nazevKnihovny;
        public int PocetKnih
        {
            get
            {
                return pocetKnih;
            }
            set
            {
                pocetKnih = value;
            }
        }
        public int PocetZamestnancu
        {
            get
            {
                return pocetZamestnancu;
            }
            set
            {
                pocetZamestnancu = value;
            }
        }
        public string JmenoMajitele
        {
            get
            {
                return jmenoMajitele;
            }
            set
            {
                string o = value;
                int i = 0;
                while(i<o.Length)
                {
                    if(char.IsLetter(o[i]) || o[i] == ' ')
                    {
                        ++i;
                    }
                    else
                    {
                        o = o.Remove(i, 1);
                    }
                    
                }
                string substring = o.Substring(1, o.Length - 1);
                string vysledek = char.ToUpper(o[0]) + substring;
                jmenoMajitele = vysledek;
            }
        }
        public string NazevKnihovny
        {
            get
            {
                return nazevKnihovny;
            }
            set
            {
                nazevKnihovny = value;
            }
        }
        public Knihovna(int pocetKnih, int pocetZamestnancu, string jmenoMajitele,string nazevKnihovny)
        {
            PocetKnih = pocetKnih;
            PocetZamestnancu = pocetZamestnancu;
            JmenoMajitele = jmenoMajitele;
            NazevKnihovny = nazevKnihovny;
        }
        public override string ToString()
        {
            string s = "Název knihovny: " + nazevKnihovny + "\nJméno majitele: " + jmenoMajitele + "\nPočet zaměstnanců: " + pocetZamestnancu + "\nPočet knih: " + pocetKnih;
            return s;
        }
    }
}
