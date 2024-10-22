using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolumen
{
    class Funciones
    {
        public static double ACubo(double LogCubo)
        {
            double AreCubo;
            AreCubo = 6 * (Math.Pow(LogCubo, 2));
            return AreCubo;
        }
           public static double Vcubo(double LogCubo)
           {
           double VolumCubo;
           VolumCubo=Math.Pow(LogCubo,3);
            return VolumCubo;
           }
        public static double AEsfera(double radio)
        {
            double AreEsfera;
            AreEsfera = 4 * (Math.PI) * (Math.Pow(radio, 2));
            return AreEsfera;
        }
        public static double VEsfera(double radio)
        {
            double VolumEsfera;
            VolumEsfera = 4/3 * (Math.PI) * (Math.Pow(radio, 3));
            return VolumEsfera;
        }
    }
}
