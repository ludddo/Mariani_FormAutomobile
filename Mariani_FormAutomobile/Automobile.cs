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
        private bool attiva;
        public int marcia;

        public Automobile() { }

        public void Accendi()
        {
            attiva = true;
        }

        public void Spegni()
        {
            attiva = false;
        }

        public void Marcia(int numero)
        {
            marcia = numero;
        }

        public int Accellera(string azione) 
        {
            if (attiva)
            {
                switch (marcia)
                {
                    case 1:
                        return 30;
                    case 2:
                        return 60;
                    case 3:
                        return 90;
                    case 4:
                        return 120;
                    case 5:
                        return 150;
                    default:
                        return -2;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
