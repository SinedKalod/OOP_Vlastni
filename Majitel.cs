using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Majitel : Knihovna
    {
        private double mesicniZisk;
        private string pohlavi;
        public Majitel(int pocetKnih, int pocetZamestnancu, string jmenoMajitele, string nazevKnihovny, double mesicniZisk, string pohlavi) : base (pocetKnih,pocetZamestnancu,jmenoMajitele, nazevKnihovny)
        {
            this.mesicniZisk = mesicniZisk;
            this.pohlavi = pohlavi;
        }
        public double GetVydelek()
        {
            return mesicniZisk;
        }
        public void SetVydelek(double zisk)
        {
            this.mesicniZisk = zisk;
        }

        public string GetPohlavi()
        {
            return pohlavi;
        }

        public void SetPohlavi(string pohlavi)
        {
            this.pohlavi = pohlavi;
        }

        public override string ToString()
        {
            return base.ToString() + "\nMesíční zisk: " + mesicniZisk + "\nPohlaví: "+pohlavi;
        }
    }
}
