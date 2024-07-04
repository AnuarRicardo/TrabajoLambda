using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    public class estudiante
    {
       public string nombre { get; set; }
       public int edad { get; set; }
       public double nota { get; set; }
        public estudiante(string nombre, int edad, double nota)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nota = nota;
        }
    }
}
