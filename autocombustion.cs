using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_2.Vehiculosclases
{
    public class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible;

        public int NivelCombustible
        {
            get { return nivelCombustible; }
            private set { nivelCombustible = value; }
        }

        public AutoDeCombustion(string marca, string modelo, int nivelCombustible)
            : base(marca, modelo)
        {
            this.nivelCombustible = nivelCombustible;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            nivelCombustible -= 1;
            Console.WriteLine("Nivel de combustible: {0}%", nivelCombustible);
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("El frenado consume algo de combustible.");
        }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("El auto de combustión está encendido.");
        }

        public override void Apagar()
        {
            base.Apagar();
            Console.WriteLine("El auto de combustión se apaga.");
        }
    }
}
