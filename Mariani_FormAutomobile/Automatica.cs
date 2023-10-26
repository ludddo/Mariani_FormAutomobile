using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_FormAutomobile
{
    internal class Automatica : Automobile
    {
        private int _numeroGiri;

        public Automatica() : base()
        { 
            NumeroGiri = 1500; 
        }

        public Automatica(Automatica automatica) /*: base(automatica)*/ 
        {
            NumeroGiri = automatica.NumeroGiri;
        }


        public int NumeroGiri { get; set; }

        public int GetNumeroGiri()
        {
            return NumeroGiri;
        }

        public override void Movimento(string cosaFare)
        {
            int i = 0;

            if (cosaFare == "accellera") { i = 0; NumeroGiri += 1000; }
            else { i = -20; NumeroGiri = 1000; }

            if (NumeroGiri > 2000)
            {
                if (Marcia != 5)
                {
                    Marcia++;
                    NumeroGiri = 1500;
                }
                else
                {
                    NumeroGiri = 2500;
                }
            }
            else if (NumeroGiri <= 1000)
            {
                if (Marcia > 0)
                {
                    Marcia--;
                    NumeroGiri = 1500;
                }
                
            }

            if (Attiva)
            {
                switch (Marcia)
                {
                    case 1:
                        Velocita = 20 + i;
                        break;
                    case 2:
                        Velocita = 60 + i;
                        break;
                    case 3:
                        Velocita = 90 + i;
                        break;
                    case 4:
                        Velocita = 120 + i;
                        break;
                    case 5:
                        Velocita = 150 + i;
                        break;
                }
            }
            else
            {
                Velocita = -1;
            }
        }
    }
}
