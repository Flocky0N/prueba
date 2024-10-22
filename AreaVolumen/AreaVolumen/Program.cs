using System;


namespace AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaCubo, LongitudCubo, VolumenCubo, AreaEsfera, RadioEsfera, VolumenEsfera, VolumenTotal;
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

            Console.WriteLine("Presion cualquier tecla para salir..");
            Console.ReadLine();
        }
    }
}
