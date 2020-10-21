using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea
{
    class Xbox : ConsolaDeVideojuegos
    {
        protected string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Xbox() : base();
       {
        modelo = "";
       }

    public override string ToString()
    {
        return modelo + " " + base.ToString();
    }
}
}
