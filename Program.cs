using prueba_2.Vehiculosclases;

class Program
{

    static void Main(string[] args)
    {
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Motocicleta("Honda", "CBR 1000", true);
        vehiculos[1] = new AutoDeCombustion("Ford", "Fiesta", 100);
        vehiculos[2] = new Camion("Scania", "R500", 5000);
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.Encender();
            vehiculo.Acelerar(50);
            vehiculo.Frenar(10);
            vehiculo.Apagar();
        }
    }
}