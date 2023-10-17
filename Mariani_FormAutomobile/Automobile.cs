using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_FormAutomobile
{
    internal class Automobile
    {
        private string azione;

        public Automobile() { }

        public Automobile(string azione) { SetAzione(azione); }

        public void SetAzione(string azione) { this.azione = azione; }

        public string GetAzione() { return azione; }


    }
}
