public class Narrativa
{
    private const int FIN = -1;

    private int actual;
    private string[] narrativas;
    private string[][] decisiones;
    private string[][] resultados;
    private int[][] consecuencias;
    private string[] intro;
    private string mensajeFinal;

    public Narrativa(
        string[] narrt,
        string[][] decs,
        string[][] resp,
        string[] ntr,
        int[][] consecuencias_,
        string mensajeFinal_ = "¡Has llegado al final de la historia!",
        int inicio = 0)
    {
        narrativas = narrt;
        decisiones = decs;
        resultados = resp;
        intro = ntr;
        consecuencias = consecuencias_;
        mensajeFinal = mensajeFinal_;
        actual = inicio;
    }

    public void mostrarIntro()
    {
        foreach (string txt in intro)
        {
            Console.WriteLine(txt);
        }

        Console.ReadLine();
    }

    public void historia()
    {
        while (actual != FIN && actual >= 0 && actual < narrativas.Length)
        {
            Console.Clear();

            Console.WriteLine(narrativas[actual]);
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("¿Qué quieres hacer?");

            foreach (string opcion in decisiones[actual])
            {
                Console.WriteLine(opcion);
            }

            Console.WriteLine();
            Console.Write("Elige 1 o 2: ");

            string eleccion = Console.ReadLine();

            while (eleccion != "1" && eleccion != "2")
            {
                Console.Write("Opción inválida. Elige 1 o 2: ");
                eleccion = Console.ReadLine();
            }

            int indice = eleccion == "1" ? 0 : 1;

            Console.WriteLine("======================================");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine(resultados[actual][indice]);
            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadLine();

            actual = consecuencias[actual][indice];
        }

        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine(mensajeFinal);
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Presiona ENTER para salir...");
        Console.ReadLine();
    }
}