using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1
{
    class Vehiculo
    {
        protected string llantas;

       

        public string Llantas
        {
            get
            {
                return llantas; 
            }
            set
            {
                llantas = value;
            }
        }

        public Vehiculo() 
        {
            Llantas = "Rodada 16";
        }

        public override string ToString()
        {
            return llantas + " ";








        }






    }
}
