using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_2.Vehiculosclases
{
    public class Motocicleta : Vehiculo
    {
        private bool tieneCasco;

        public bool TieneCasco
        {
            get { return tieneCasco; }
            private set { tieneCasco = value; }
        }

        public Motocicleta(string marca, string modelo, bool tieneCasco)
            : base(marca, modelo)
        {
            this.tieneCasco = tieneCasco;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto + 10);
            Console.WriteLine("¡Vas más rápido con la motocicleta!");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("La motocicleta frenó de forma más ágil.");
        }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("La motocicleta está encendida.");
        }

        public override void Apagar()
        {
            base.Apagar();
            Console.WriteLine("La motocicleta se apagó.");
        }
    }
}
