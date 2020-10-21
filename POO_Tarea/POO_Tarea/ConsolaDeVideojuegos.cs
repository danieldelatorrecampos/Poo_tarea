using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea
{
    class ConsolaDeVideojuegos
    {
        public class consolaDeVideojuegos
        {
            protected int precio;

            public int Precio
            {
                get { return precio; }
                set { precio = value; }
            }
            public consolaDeVideojuegos()
            {
                precio = 0;

            }
            public override string ToString()
            {
                return "precio " + precio;

            }
        }
    }
}
