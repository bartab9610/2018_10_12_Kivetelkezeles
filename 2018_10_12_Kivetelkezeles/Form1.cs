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
        public Form_kivetelkezeles()
        {
            InitializeComponent();

            Button_create_file.Click += (sender, e) =>
            {
                try
                {
                    string Fajl_nev = TextBox_path.Text;
                    File.WriteAllText(Fajl_nev, "Hello");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Érvénytelen fájlnév, adjon meg egy úját!");
                }
            };
        }
    }
}