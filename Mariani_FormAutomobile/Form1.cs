using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariani_FormAutomobile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            auto.Accendi();
            listView1.Items.Clear();
            listView1.Items.Add("Stato Attuale: Accesa");
            listView1.Items.Add("Marcia Attuale: Folle");
            listView1.Items.Add("Velocità Attuale = 0");
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            
            auto.Spegni();

            if (auto.GetVelocita() != 0)
            {
                MessageBox.Show("Per Spegnere l'Auto devi essere a 0 km/h");
            }

            StatoAttuale();
        }

        private void Accellera_Click(object sender, EventArgs e)
        {
            auto.Movimento("accellera");
            int velocita = auto.GetVelocita();
            if (velocita == -1)
            {
                MessageBox.Show("Accendere l'Auto");
                return;
            }

            StatoAttuale();            
        }

        private void Decellera_Click(object sender, EventArgs e)
        {
            auto.Movimento("decellera");

            StatoAttuale();
        }

        private void StatoAttuale()
        {
            listView1.Items.Clear();
            listView1.Items.Add("Stato dell'Auto: " + auto.GetAttiva());
            listView1.Items.Add("Marcia Attuale: " + auto.GetMarcia());
            listView1.Items.Add("Velocità Attuale: " + auto.GetVelocita());
        }

        private void marcia1_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(1);
        }

        private void marcia2_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(2);
        }

        private void marcia3_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(3);
        }

        private void marcia4_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(4);
        }

        private void marcia5_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(5);
        }
    }
}
