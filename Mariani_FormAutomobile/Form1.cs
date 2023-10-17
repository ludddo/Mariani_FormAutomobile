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
        Automobile auto = new Automobile();
        public Form1()
        {
            InitializeComponent();
        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            auto.Accendi();
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            auto.Spegni();
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
            listView1.Items.Clear();

            listView1.Items.Add("Velocità Attuale: " + auto.GetVelocita());
            listView1.Items.Add("Marcia Attuale: " + auto.GetMarcia());
            
        }

        private void Decellera_Click(object sender, EventArgs e)
        {
            auto.Movimento("decellera");
        }

        private void StatoAttuale()
        {
            listView1.Items.Clear();
            listView1.Items.Add("Stato dell'Auto: " + auto.GetAttiva());
            listView1.Items.Add("Marcia Attuale: " + auto.GetMarcia());
            listView1.Items.Add("Velocità Attuale: " + auto.GetVelocita());
        }
    }
}
