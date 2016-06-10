using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.TP5_Colas
{
    public class Auto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public double Fin_estacionamiento { get; set; }
        

        public Auto()
        {

        }
        public Auto(int id, string nombre, string estado, double fin_est)
        {
            Id = id;
            Nombre = nombre;
            Estado = estado;
            Fin_estacionamiento = fin_est;

        }
    }
}
