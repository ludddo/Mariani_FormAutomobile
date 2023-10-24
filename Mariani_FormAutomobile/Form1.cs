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

        int auto_manual = 0;

        Automobile auto = new Automobile();
        Automatica cambio_auto = new Automatica();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void manuale_Click(object sender, EventArgs e)
        {
            auto_manual = -1;
            groupBox1.Visible = false;
        }

        private void automatica_Click(object sender, EventArgs e)
        {
            auto_manual = 1;
            groupBox1.Visible = false;
            marcia1.Visible = false;
            marcia2.Visible = false;
            marcia3.Visible = false;
            marcia4.Visible = false;
            marcia5.Visible = false;
        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            if (auto_manual == -1)
            {
                auto.Accendi();
                listView1.Items.Clear();
                listView1.Items.Add("Stato Attuale: Accesa");
                listView1.Items.Add("Marcia Attuale: Folle");
                listView1.Items.Add("Velocità Attuale = 0");
            }
            else
            {
                cambio_auto.Accendi();
                listView1.Items.Clear();
                listView1.Items.Add("Stato Attuale: Accesa");
                listView1.Items.Add("Marcia Attuale: Folle");
                listView1.Items.Add("Velocità Attuale = 0");
                listView1.Items.Add("Numero di Giri = 0");
            }
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            if (auto_manual == -1)
            {
                auto.Spegni();

                if (auto.GetVelocita() != 0)
                {
                    MessageBox.Show("Per Spegnere l'Auto devi essere a 0 km/h");
                }

                StatoAttuale();
            }
            else
            {
                cambio_auto.Spegni();

                if (cambio_auto.GetVelocita() != 0)
                {
                    MessageBox.Show("Per Spegnere l'Auto devi essere a 0 km/h");
                }

                StatoAttuale();
            }
        }

        private void Accellera_Click(object sender, EventArgs e)
        {
            if (auto_manual == -1)
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
            else
            {
                cambio_auto.Movimento("accellera");
                int velocita = cambio_auto.GetVelocita();
                if (velocita == -1)
                {
                    MessageBox.Show("Accendere l'Auto");
                    return;
                }

                StatoAttuale();
            }

                       
        }

        private void Decellera_Click(object sender, EventArgs e)
        {
            if (auto_manual == -1)
            {
                auto.Movimento("decellera");
            }
            else
            {
                cambio_auto.Movimento("decellera");
            }

            StatoAttuale();
        }

        private void StatoAttuale()
        {
            if (auto_manual == -1)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Stato dell'Auto: " + auto.GetAttiva());
                listView1.Items.Add("Marcia Attuale: " + auto.GetMarcia());
                listView1.Items.Add("Velocità Attuale: " + auto.GetVelocita());
            }
            else
            {
                listView1.Items.Clear();
                listView1.Items.Add("Stato dell'Auto: " + cambio_auto.GetAttiva());
                listView1.Items.Add("Marcia Attuale: " + cambio_auto.GetMarcia());
                listView1.Items.Add("Velocità Attuale: " + cambio_auto.GetVelocita());
                listView1.Items.Add("Numero di Giri Attuale: " + cambio_auto.GetNumeroGiri());
            }
        }

        private void marcia1_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(1);
            StatoAttuale();
        }

        private void marcia2_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(2);
            StatoAttuale();
        }

        private void marcia3_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(3);
            StatoAttuale();
        }

        private void marcia4_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(4);
            StatoAttuale();
        }

        private void marcia5_Click(object sender, EventArgs e)
        {
            auto.SetMarcia(5);
            StatoAttuale();
        }

        
    }
}
