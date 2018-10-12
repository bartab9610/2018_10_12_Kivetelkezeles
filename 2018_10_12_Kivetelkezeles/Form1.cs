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
            File.WriteAllText(Fajl_nev, szoveg);
        }

        public Form_kivetelkezeles()
        {
            InitializeComponent();

            Button_create_file.Click += (sender, e) =>
            {
                try
                {
                    Fajlkiiratas("Hello");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Érvénytelen fájlnév, adjon meg egy úját!");
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Nem tudtam megnyitni!");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("A mező nem lehet üres!");
                }
            };
        }
    }
}