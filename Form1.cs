using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_Find_Summoners
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string selected_radio_button()
        {
            if (NA_radio.Checked) return "na";
            else if (EUW_radio.Checked) return "euw";
            else if (EUNE_radio.Checked) return "eune";
            else return "NOTHING_SELECTED";
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var radio_val = selected_radio_button();

            if (radio_val == "NOTHING_SELECTED")
            {
                MessageBox.Show("Region not selected!","Error: Region not selected");
                return;
            }
            string[] linije = metroTextBox1.Text.Split('\n');

            foreach (string linija in linije)
            {
                string summ_name = linija.Replace(" joined the lobby", "");
                string url = "https://" + radio_val + ".op.gg/summoner/userName=" + summ_name;
                Process.Start(url);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var radio_val = selected_radio_button();

            if (radio_val == "NOTHING_SELECTED")
            {
                MessageBox.Show("Region not selected!", "Error: Region not selected");
                return;
            }

            string[] linije = metroTextBox1.Text.Split('\n');

            foreach (string linija in linije)
            {
                string summ_name = linija.Replace(" joined the lobby", "");
                string url = "https://porofessor.gg/live/" + radio_val + "/" + summ_name;
                Process.Start(url);
                break;
            }
        }
    }
}
