using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_2.Vehiculosclases
{
    public class CarroElectrico : Vehiculo
    {
        private int cargaBateria;

        public int CargaBateria
        {
            get { return cargaBateria; }
            private set { cargaBateria = value; }
        }

        public CarroElectrico(string marca, string modelo, int cargaBateria)
            : base(marca, modelo)
        {
            this.cargaBateria = cargaBateria;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            cargaBateria--;
            Console.WriteLine("La batería ahora está al {0}% de carga.", cargaBateria);
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("El freno regenerativo recarga parcialmente la batería.");
        }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("El carro eléctrico está listo para usar.");
        }

        public override void Apagar()
        {
            base.Apagar();
            Console.WriteLine("El carro eléctrico se apaga.");
        }
    }
}
