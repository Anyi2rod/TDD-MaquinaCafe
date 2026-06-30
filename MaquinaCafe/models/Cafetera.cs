using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.models
{
   public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }
     
        public void SetCantidadDeCafe(int cantidad)
        {
            cantidadCafe = cantidad;
        }

        public int GetCantidadDeCafe()
        {
            return cantidadCafe;
        }

        public bool HasCafe(int cantidad)
        {
            return cantidadCafe >= cantidad;
        }

        public void GiveCafe(int cantidad)
        {
            cantidadCafe -= cantidad;
        }
    }
}

