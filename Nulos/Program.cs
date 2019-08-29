using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {

        static Alumno alumno;
        static void Main(string[] args)
        {
            alumno = new Alumno();
            alumno.Materias.Add("Matematicas");
            ImprimirAlumno();
            Console.Read();

          
        }
        static void ImprimirAlumno()
        {
            try
            {

                alumno.Nombre = "Jose";
                Console.WriteLine("Nombre: "
                    + alumno.Nombre);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
