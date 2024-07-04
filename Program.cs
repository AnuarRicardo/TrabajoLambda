using lambda;
using System.Linq;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lista estudiantes");
        List<estudiante> Estudiantes = new List<estudiante>();
        {
            Estudiantes.Add(new estudiante("Alberto", 19, 61.9));
            Estudiantes.Add(new estudiante("Juan", 21, 34.4));
            Estudiantes.Add(new estudiante("Anuar", 19, 71.7));
            Estudiantes.Add(new estudiante("Bryan", 17, 78.5));
            Estudiantes.Add(new estudiante("Joshue", 20, 56.8));

        };
        var mayoresedad = Estudiantes.Where(i => i.edad > 18).ToList();
        Console.WriteLine("Mayores de edad de estudiantes");
        mayoresedad.ForEach(i => Console.WriteLine($"nombre {i.nombre}, edad {i.edad}, nota {i.nota}"));
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        double notaAlta = Estudiantes.Max(i => i.nota);
        var estudiantenotaAlta = Estudiantes.First(i => i.nota == notaAlta);
        Console.WriteLine("Estudiante con nota mas alta:");
        Console.WriteLine($"Estudiante {estudiantenotaAlta.nombre}, edad {estudiantenotaAlta.edad}, nota {estudiantenotaAlta.nota}");
        var estudiantesordenaods = Estudiantes.OrderBy(i => i.nombre).ToList();
        Console.WriteLine("Estudiantes ordenados");
        estudiantesordenaods.ForEach(i => Console.WriteLine($"nombre {i.nombre}, edad {i.edad}, nota {i.nota}"));
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////");
        double promedionotas = Estudiantes.Average(i => i.nota);
        Console.WriteLine($"Promedio de los estudiantes {promedionotas}");
        {
            Console.WriteLine("lambda programacion 1");
            Func<int, int, int> suma = (a, b) => a + b;
            Console.WriteLine(suma(3, 4));
            Func<double, double> produc = x => x * x;
            Console.WriteLine(produc(10));
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(10, "programacion1"));
            Action<int> mayorEdad = n =>
            {
                Boolean ME = (n > 18) ? true : false;
                Console.WriteLine($"Es mayor de edad");

            };
            mayorEdad(15);
            Action<string> saludar = _ => Console.WriteLine("saludar");
            saludar("ignorando");

        }

    }

}
