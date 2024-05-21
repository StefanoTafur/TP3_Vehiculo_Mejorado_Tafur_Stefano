using System;

namespace Vehiculos
{
    class Program
    {
        abstract class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        class Automovil : Vehiculo
        {
            public int NumeroPuertas { get; set; }
            public string TipoCombustible { get; set; }

            public Automovil(string marca, string modelo, int año, int numeroPuertas, string tipoCombustible)
                : base(marca, modelo, año)
            {
                NumeroPuertas = numeroPuertas;
                TipoCombustible = tipoCombustible;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Automóvil \nNúmero de Puertas: {NumeroPuertas} \nTipo de Combustible: {TipoCombustible}");
            }
        }

        class Camion : Vehiculo
        {
            public double CapacidadCarga { get; set; }
            public string TipoRemolque { get; set; }

            public Camion(string marca, string modelo, int año, double capacidadCarga, string tipoRemolque)
                : base(marca, modelo, año)
            {
                CapacidadCarga = capacidadCarga;
                TipoRemolque = tipoRemolque;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Camión \nCapacidad de Carga: {CapacidadCarga} toneladas \nTipo de Remolque: {TipoRemolque}");
            }
        }

        class Bicicleta : Vehiculo
        {
            public int NumeroMarchas { get; set; }

            public Bicicleta(string marca, string modelo, int año, int numeroMarchas)
                : base(marca, modelo, año)
            {
                NumeroMarchas = numeroMarchas;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nNúmero de Marchas: {NumeroMarchas}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHÍCULOS--------");

            Automovil automovil = new Automovil("Toyota", "Corolla", 2020, 4, "Gasolina");
            Camion camion = new Camion("Volvo", "FH16", 2020, 20, "Plataforma");
            Bicicleta bicicleta = new Bicicleta("Giant", "Talon", 2021, 18);

            automovil.MostrarInformacion();
            Console.WriteLine("-----------------");
            camion.MostrarInformacion();
            Console.WriteLine("-----------------");
            bicicleta.MostrarInformacion();
        }
    }
}
