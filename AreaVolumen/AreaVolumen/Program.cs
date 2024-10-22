using System;
//Agregando nuevo funcionamiento
using System.Threading;

namespace AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            double AreaCubo, LongitudCubo, VolumenCubo, AreaEsfera, RadioEsfera, VolumenEsfera, VolumenTotal;
            //Nos permitirá pedir la longitud que posee el cubo
            Console.WriteLine("Ingrese la Longitud del cubo");
            LongitudCubo = double.Parse(Console.ReadLine());

            AreaCubo = Funciones.ACubo(LongitudCubo);
            Console.WriteLine("El area del cubo es: "+ AreaCubo);

            VolumenCubo = Funciones.Vcubo(LongitudCubo);
            Console.WriteLine("El volumen del cubo es: " + VolumenCubo);

            Console.WriteLine("Ingrese el radio de la esfera");
            RadioEsfera = double.Parse(Console.ReadLine());
            AreaEsfera = Funciones.AEsfera(RadioEsfera);
            Console.WriteLine("El área de la esfera es: " + AreaEsfera);

            VolumenEsfera = Funciones.VEsfera(RadioEsfera);
            Console.WriteLine("El volumen de la esfera es: " + VolumenEsfera);
            VolumenTotal = VolumenEsfera + VolumenCubo;
            Console.WriteLine("El volumen total es: " + VolumenTotal);


            //Agregando funcion extra
             double CalculoMental;

            Console.WriteLine("En que numero estás pensando? ");
            CalculoMental = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Calculando...");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Recolectando información...");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Creando conexiones neuronales...");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Renderizando resultado...");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Este proceso puede tardar... Por favor espere...");
            Thread.Sleep(4000);

            Console.Clear();
            Console.WriteLine("Estas pensando en el numero: "+CalculoMental);
            Console.ReadKey();

            

            Console.WriteLine("Presion cualquier tecla para salir..");
            Console.ReadLine();
        }
    }
}
