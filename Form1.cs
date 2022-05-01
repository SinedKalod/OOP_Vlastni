using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazev = textBox1.Text, majitel = textBox2.Text;
            int pocetKnih = int.Parse(textBox3.Text), pocetZamestnancu = int.Parse(textBox4.Text);
            Knihovna knihovna = new Knihovna(pocetKnih, pocetZamestnancu, majitel, nazev);
            MessageBox.Show(knihovna.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nazev = textBox5.Text, jmenoMajitele = textBox6.Text, pohlavi;
            int pocetKnih = int.Parse(textBox7.Text), pocetZamestnancu = int.Parse(textBox8.Text);
            double mesicniZisk = double.Parse(textBox9.Text);
            if (radioButton1.Checked) pohlavi = "Muž";
            else pohlavi = "Žena";
            Majitel majitel = new Majitel(pocetKnih,pocetZamestnancu,jmenoMajitele,nazev,mesicniZisk, pohlavi);
            MessageBox.Show(majitel.ToString());
        }
    }
}
