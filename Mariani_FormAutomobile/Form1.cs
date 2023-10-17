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

        private void Accellera_Click(object sender, EventArgs e)
        {
            
        }
    }
}
