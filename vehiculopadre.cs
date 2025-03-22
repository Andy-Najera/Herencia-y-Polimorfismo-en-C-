using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_2.Vehiculosclases
{
    public abstract class Vehiculo
    {
        private int velocidad;
        public int Velocidad
        {
            get { return velocidad; }
            private set { velocidad = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidad = 0;
        }

        public virtual void Acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }

        public virtual void Frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("La velocidad es ahora {0} KMS / Hora", velocidad);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo está encendido.");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El vehículo está apagado.");
        }
    }
}
