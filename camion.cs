using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_2.Vehiculosclases
{
    public class Camion : Vehiculo
    {
        private int capacidadCarga;

        public int CapacidadCarga
        {
            get { return capacidadCarga; }
            private set { capacidadCarga = value; }
        }

        public Camion(string marca, string modelo, int capacidadCarga)
            : base(marca, modelo)
        {
            this.capacidadCarga = capacidadCarga;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            Console.WriteLine("El camión acelera con dificultad debido a su gran carga.");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("El camión necesita más tiempo para frenar.");
        }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("El camión está encendido.");
        }

        public override void Apagar()
        {
            base.Apagar();
            Console.WriteLine("El camión se apaga.");
        }
    }
}
