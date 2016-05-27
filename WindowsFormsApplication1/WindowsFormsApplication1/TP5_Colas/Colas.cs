using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.TP5_Colas
{
    class Colas
    {
        bool demora;

        public bool determinarDemora(double rndDemora)
        {
            if (rndDemora >= 0.0 && rndDemora < 0.20)
            {
                demora = true;
            }
            else if (rndDemora >= 0.20 && rndDemora < 1)
            {
                demora = false;
            }
            return demora;
        }
    }
}
