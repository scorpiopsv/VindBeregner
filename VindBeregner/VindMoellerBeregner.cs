using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VindBeregner
{
    public class VindMoellerBeregner
    {
        public double MegaWatt(double vindstyrke, double maxmegaWattEffekt)
        {
            try
            {
                if (vindstyrke < 4 || vindstyrke > 25)
                    return 0;


                double x = 0;
                x = (vindstyrke - 4) / 21;

                return x * maxmegaWattEffekt;
            }
            catch (Exception)
            {
                return -1;
            }           
        }
    }
}
