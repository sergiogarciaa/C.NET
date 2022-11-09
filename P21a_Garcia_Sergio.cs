// Alumno: García Barrera, Sergio

namespace P21a_Garcia_Sergio;

internal class P21a_Garcia_Sergio
{
    private static void Main(string[] args)
    {
        int cant, min, num, nc;
        bool esCorrecto;


        cant = Captura("\n\tCantidad de múltiplos a presentar? [100..300]: ", 100, 300);

        // Captura del valor inicial min
        num = Captura("\n\t¿Número del que obtener sus múltiplos? [11..77]: ", 11, 77);

        // Captura del valor inicial min
        min = Captura("\n\t¿Valor mínimo? [1000..2000]: ", 1000, 2000);
        // Captura del número de columnas en las que lo voy a presentar  nc

        nc = Captura("\n\t¿Número de columnas? [3..8]: ", 3, 8);

        // cálculo del primer múltiplo suponiendo que el límite inferior está incluido
        var multiplo = min / num * num;

        if (multiplo < min)
            multiplo += num;

        // presentación
        Console.Clear();
        Console.WriteLine("\n{0} primeros múltiplos de {1} a partir de {2} en {3} columnas", cant, num, min, nc);

        for (var i = 0; i < cant; i++)
        {
            // cuando el contador sea múltiplo del nº de columnas...
            // Salto de línea
            if (i % nc == 0)
                Console.WriteLine();

            Console.Write("{0}\t", multiplo); // <-- Presentamos el múltiplo
            multiplo += num; // <-- obtenemos el siguiente
        }


        Console.Write("\n\n\tPulsa una tecla para salir");
        Console.ReadKey();
    }

    private static int Captura(string txt, int min, int max)
    {
        var valor = 1;
        bool ok;

        do
        {
            Console.Write("\n\t {0}: ", txt);
            ok = int.TryParse(Console.ReadLine(), out valor);

            if (!ok) // IMPORTANTE: La expresión !ok equivale a ok == false
                Console.Write("\n\t** Error!! el valor introducido no es un número entero **\n");

            else if (valor < min || valor > max)
                Console.Write("\n\t** Error!! número fuera de rango **\n");
        } while (!ok || valor < min || valor > max);

        return valor;
    }
}