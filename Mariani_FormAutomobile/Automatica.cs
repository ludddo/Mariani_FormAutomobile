using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_FormAutomobile
{
    internal class Automatica : Automobile
    {
        private int numeroGiri;
        private int velocita;
        private bool attiva;
        private int marcia;

        public Automatica() : base() { numeroGiri = 1500; }

        public int GetNumeroGiri()
        {
            return numeroGiri;
        }

        public override void Movimento(string cosaFare)
        {
            int i = 0;

            if (cosaFare == "accellera") { i = 0; numeroGiri += 1000; }
            else { i = -20; numeroGiri += 1000; }

            if (numeroGiri > 2000)
            {
                marcia++; 
                numeroGiri = 1500;
            }
            else if (numeroGiri < 1000)
            {
                marcia--;
                numeroGiri = 1500;
            }

            if (attiva)
            {
                switch (marcia)
                {
                    case 1:
                        velocita = 20 + i;
                        break;
                    case 2:
                        velocita = 60 + i;
                        break;
                    case 3:
                        velocita = 90 + i;
                        break;
                    case 4:
                        velocita = 120 + i;
                        break;
                    case 5:
                        velocita = 150 + i;
                        break;
                }
            }
            else
            {
                velocita = -1;
            }
        }
    }
}
