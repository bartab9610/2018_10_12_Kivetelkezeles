using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2018_10_12_Kivetelkezeles
{
    public partial class Form_kivetelkezeles : Form
    {
        void Fajlkiiratas(string szoveg)
        {
            string Fajl_nev = TextBox_path.Text;
            // C:\ ELERESI UTVONAL \  -> VALAMI.txt
            if (string.IsNullOrWhiteSpace(Fajl_nev))
            {
                throw new IOException("Fájl létrehozásakor érvénytelen fájlnév!");
            }
            // File.WriteAllText(Fajl_nev, szoveg);
            // StreamWriter sw = new StreamWriter(Fajl_nev); UGYAN AZT JELENTI MINT AZ ALATTA LÉVŐ SOR
            // StreamWriter sw = File.CreateText(Fajl_nev);
            // StreamReader sr = new StreamReader(Fajl_nev);
            // StreamReader sr = File.OpenText(Fajl_nev);
            using (StreamWriter sw = File.CreateText(Fajl_nev))
            {
                sw.WriteLine(szoveg);
                for (int i = 0; i < 10; i++)
                {
                    /*
                    if (i == 5)
                    {
                        throw new IOException("Hálózati hiba történt!");
                        // 5 elemet kiír utána kilép a program!
                    }
                    int tmp = 15 / (i - 3);
                    */
                    sw.WriteLine(i + ". sor"); //+ tmp);
                }
            }
            /*
            try
            {
                sw.WriteLine(szoveg);
                for (int i = 0; i < 10; i++)
                {
                    if (i == 5)
                    {
                        throw new IOException("Hálózati hiba történt!");
                        // 5 elemet kiír utána kilép a program!
                    }
                    sw.WriteLine(i + ". sor");
                }
            }
            finally
            {
                sw.Close();
            }
            */
        }

        int FileBeolvasas(string File_nev)
        {
            using (StreamReader sr = File.OpenText(File_nev))
            {
                string cim = sr.ReadLine();
                string sor;
                int darab_Szam = 0;
                while ((sor = sr.ReadLine()) != null)
                {
                    darab_Szam++;
                }
                return darab_Szam;
            }
        }

        public Form_kivetelkezeles()
        {
            InitializeComponent();

            Button_create_file.Click += (sender, e) =>
            {
                try
                {
                    Fajlkiiratas("Hello");
                    MessageBox.Show("Sikeres kiíratás!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Érvénytelen fájlnév, adjon meg egy úját!");
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Nem tudtam megnyitni!");
                }
                /* catch (ArgumentException ex)
                {
                    MessageBox.Show("A mező nem lehet üres!");
                } */
            };

            Button_open_file.Click += (sender, e) =>
            {
                int i = FileBeolvasas(TextBox_path.Text);
                MessageBox.Show(i + " db sor");
            };
        }
    }
}