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
        private int velocita;
        private bool attiva;
        public int marcia;

        public Automobile() { velocita = 0; marcia = 1; }

        public void Accendi()
        {
            attiva = true;
        }

        public void Spegni()
        {
            if ( velocita == 0 )
            {
                attiva = false;
                velocita = 0;
            }
        }

        public void SetMarcia(int numero)
        {
            marcia = numero;
        }

        public void Movimento(string cosaFare) 
        {
            int i = 0;

            if (cosaFare == "accellera") { i = 0;}
            else { i = -20;}

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

        public int GetVelocita()
        {
            return velocita;
        }

        public int GetMarcia()
        {
            return marcia;
        }

        public string GetAttiva()
        {
            if (attiva)
            {
                return "accesa";
            }
            else
            {
                return "spenta";
            }
        }
    }
}
