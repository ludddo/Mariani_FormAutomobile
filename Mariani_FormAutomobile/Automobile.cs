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
        private int _velocita;
        private bool _attiva;
        private int _marcia;

        public int Velocita { get { return _velocita; } set { _velocita = value; } }
        public int Marcia { get { return _marcia; }  set { if (value <= 5 || value > 0) _marcia = value;  } }
        public bool Attiva { get; set; }

        public Automobile() { Velocita = 0; Marcia = 1; }

        public Automobile(Automobile auto)
        {
            Velocita= auto.Velocita; Marcia = auto.Marcia; Attiva = auto.Attiva;
        }

        public virtual void Accendi()
        {
            Attiva = true;
        }

        public void Spegni()
        {
            if ( Velocita == 0 )
            {
                Attiva = false;
                Velocita = 0;
            }
        }

        public virtual void SetMarcia(int numero)
        {
            Marcia = numero;
        }

        public virtual void Movimento(string cosaFare) 
        {
            int i = 0;

            if (cosaFare == "accellera") { i = 0;}
            else { i = -20;}

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

        public int GetVelocita()
        {
            return Velocita;
        }

        public int GetMarcia()
        {
            return Marcia;
        }

        public string GetAttiva()
        {
            if (Attiva)
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
