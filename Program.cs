public class Program
{
    public static bool linterna = false;

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string resultado = descidirNarrativa();

        if (resultado == "vive")
        {
            Narrativa vives = new Narrativa(
                NarrativaVives.Narraciones,
                NarrativaVives.Decisiones,
                NarrativaVives.resultados,
                NarrativaVives.intro,
                NarrativaVives.Consecuencias,
                "FIN. Lograste sobrevivir a las 3:17 a. m.");

            vives.mostrarIntro();
            vives.historia();
        }

        else if (resultado == "muereLinterna")
        {
            // Intro chistoso: 
            string[] introChistosa =
            {
                "======================================",
                "VAMOS A VIVIR",
                "======================================",
                "",
                "Presiona ENTER para comenzar..."
            };

            var muere = new Narrativa(
                NarrativaMuere.Narraciones,
                NarrativaMuere.Decisiones,
                NarrativaMuere.resultados,
                introChistosa,                        
                NarrativaMuere.Consecuencias,
                "FIN. No lograste sobrevivir a las 3:17 a. m.",
                inicio: 0);

            muere.mostrarIntro();
            muere.historia();
        }
        else if (resultado == "muere")
        {
            var muere = new Narrativa(
                NarrativaMuere.Narraciones,
                NarrativaMuere.Decisiones,
                NarrativaMuere.resultados,
                NarrativaMuere.intro,                 
                NarrativaMuere.Consecuencias,
                "FIN. No lograste sobrevivir a las 3:17 a. m.",
                inicio: 0);

            muere.mostrarIntro();
            muere.historia();
        }
        else if (resultado == "muerePuerta")
        {
            var muere = new Narrativa(
                NarrativaMuere.Narraciones,
                NarrativaMuere.Decisiones,
                NarrativaMuere.resultados,
                NarrativaMuere.intro,
                NarrativaMuere.Consecuencias,
                "FIN. No lograste sobrevivir a las 3:17 a. m.",
                inicio: 1);

            muere.mostrarIntro();
            muere.historia();
        }
        else
        {
            Console.WriteLine("No se seleccionó una narrativa válida.");
            Console.WriteLine("Presiona ENTER para salir...");
            Console.ReadLine();
        }
    }

    public static string Preguntar()
    {
        string r = Console.ReadLine();
        while (r != "1" && r != "2")
        {
            Console.Write("Opción inválida. Elige 1 o 2: ");
            r = Console.ReadLine();
        }
        return r;
    }

    public static string descidirNarrativa()
    {
        Console.WriteLine("Son las 3:17 de la madrugada.");
        Console.WriteLine("Estás despierto en tu habitación, aunque no recuerdas qué te despertó.");
        Console.WriteLine("La casa está completamente en silencio, y no hay nadie más en la casa.");
        Console.WriteLine("Miras el teléfono.");
        Console.WriteLine("3:17 a. m.");
        Console.WriteLine("Entonces empieza a sonar.");
        Console.WriteLine("Miras la pantalla.");
        Console.WriteLine("El número que aparece es el tuyo.");
        Console.WriteLine("No un contacto con tu nombre.");
        Console.WriteLine("Tu propio número.");
        Console.WriteLine("El teléfono sigue sonando. Se ve que es importante, pero no sabes qué hacer.");
        Console.WriteLine("Contestar teléfono: 1. SÍ, 2. NO: ");
        string descicion = Preguntar();

        if (descicion == "1")
        {
            Console.WriteLine("Levantas el teléfono y contestas.");
            Console.WriteLine("¿Hola?");
            Console.WriteLine("Escuchas una respiración. Pero después de un rato escuchas tu voz.");
            Console.WriteLine("No abras la puerta, no abras la puerta.");
            Console.WriteLine("Te quedas en silencio.");
            Console.WriteLine("Escuchas un golpe en la puerta, y después escuchas tu voz.");
            Console.WriteLine("Soy tú.");
            Console.WriteLine("La llamada se corta.");
            Console.WriteLine("Miras la pantalla de tu teléfono.");
            Console.WriteLine("3:17 a. m.");
            Console.WriteLine("La hora no ha cambiado.");
            Console.WriteLine("Entonces escuchas un golpe en la puerta.");
            Console.WriteLine("Todo queda en silencio y vuelves a escuchar un golpe en la puerta.");
            Console.WriteLine("Pero esta vez es más fuerte.");
            Console.WriteLine("Recuerdas lo que te dijo tu voz.");
            Console.WriteLine("¿Qué haces? 1. Abrir la puerta, 2. No abrir la puerta: ");

            string decisionPuerta = Preguntar();

            if (decisionPuerta == "1")
            {
                Console.WriteLine("Abres la puerta");
                Console.WriteLine("y alguien te golpea en la cabeza y caes inconsciente.");
                return "muere";
            }
            else if (decisionPuerta == "2")
            {
                Console.WriteLine("No abres la puerta.");
                Console.WriteLine("Los golpes en la puerta se detienen, y todo queda en silencio.");
                Console.WriteLine("¿Qué haces? 1. Mirar por la ventana, 2. Revisar la casa: ");

                string decisionCasa = Preguntar();

                if (decisionCasa == "1")
                {
                    Console.WriteLine("Te llega un mensaje de tu teléfono, pero no lo lees.");
                    Console.WriteLine("Te acercas a la ventana y miras hacia afuera.");
                    Console.WriteLine("Ves a alguien parado en la calle, pero no puedes distinguir quién es.");
                    Console.WriteLine("La persona te comienza a mirar directamente a los ojos.");
                    Console.WriteLine("Sientes que alguien está detrás de ti, y cuando volteas no hay nadie.");
                    Console.WriteLine("Te llega un mensaje de tu teléfono y lo lees.");
                    Console.WriteLine("El mensaje dice: \"Te dije que no vieras la ventana pero me ignoraste.\"");
                    Console.WriteLine("Sientes un golpe en la cabeza y caes inconsciente.");
                    return "muere";
                }
                else if (decisionCasa == "2")
                {
                    Console.WriteLine("Decides revisar la casa.");
                    Console.WriteLine("Miras a tu alrededor y todo está oscuro.");
                    Console.WriteLine("Ves una linterna en el suelo.");
                    Console.WriteLine("¿La tomas? 1. Sí, 2. No");

                    string decisionLinterna = Preguntar();

                    if (decisionLinterna == "1")
                    {
                        linterna = true;
                        Console.WriteLine("Decides tomar la linterna.");
                        Console.WriteLine("Tomas una linterna y sales de tu habitación.");
                        Console.WriteLine("El pasillo está oscuro.");
                        Console.WriteLine("No hay nadie.");
                        Console.WriteLine("Revisas la sala.");
                        Console.WriteLine("Nada.");
                        Console.WriteLine("La cocina.");
                        Console.WriteLine("Nada.");
                        Console.WriteLine("El baño.");
                        Console.WriteLine("Definitivamente nada.");
                        Console.WriteLine("Vuelves al pasillo.");
                        Console.WriteLine("Entonces ves algo debajo de una puerta.");
                        Console.WriteLine("Una hoja de papel.");
                        Console.WriteLine("La recoges.");
                        Console.WriteLine("Solo tiene una frase:");
                        Console.WriteLine("\"NO CONFÍES EN LA PERSONA QUE ESTÁ CONTIGO.\"");
                        Console.WriteLine("Miras alrededor.");
                        Console.WriteLine("Estás solo.");
                        Console.WriteLine("...");
                        Console.WriteLine("O al menos eso creías.");
                        Console.WriteLine("Decides buscar otra salida.");
                        Console.WriteLine("Corres hacia la cocina. Hay una ventana.");
                        Console.WriteLine("Perfecto.");
                        Console.WriteLine("Vas hacia ella. Intentas abrirla.");
                        Console.WriteLine("Nada.");
                        Console.WriteLine("Está cerrada.");
                        Console.WriteLine("Buscas algo con qué abrirla. Encuentras una llave sobre la mesa.");
                        Console.WriteLine("La tomas.");
                        Console.WriteLine("En ese momento escuchas:");
                        Console.WriteLine("TOC.");
                        Console.WriteLine("Pero esta vez no viene de la puerta.");
                        Console.WriteLine("Viene de la ventana. Miras el vidrio.");
                        Console.WriteLine("Hay alguien al otro lado.");
                        Console.WriteLine("Está sonriendo.");
                        Console.WriteLine("Levanta la mano y toca el vidrio otra vez.");
                        Console.WriteLine("TOC.");
                        Console.WriteLine("Corres de vuelta hacia el pasillo.");
                        Console.WriteLine("Tu teléfono vuelve a sonar.");
                        Console.WriteLine("Esta vez contestas.");
                        Console.WriteLine("No dices nada.");
                        Console.WriteLine("La voz al otro lado habla primero:");
                        Console.WriteLine("—Escúchame.");
                        Console.WriteLine("Es tu propia voz.");
                        Console.WriteLine("—No importa lo que veas. No abras la puerta.");
                        Console.WriteLine("—¿Por qué?");
                        Console.WriteLine("Silencio.");
                        Console.WriteLine("Entonces responde:");
                        Console.WriteLine("—Porque yo la abrí.");
                        Console.WriteLine("La llamada termina.");
                        Console.WriteLine("Te quedas completamente quieto.");
                        Console.WriteLine("Entonces escuchas una voz detrás de ti:");
                        Console.WriteLine("—No le hagas caso.");
                        Console.WriteLine("Te das la vuelta.");
                        Console.WriteLine("No hay nadie.");
                        Console.WriteLine("Miras la pantalla.");
                        Console.WriteLine("3:17 a. m.");
                        Console.WriteLine("Sigue siendo la misma hora.");
                        Console.WriteLine("Ya no sabes qué está pasando.");
                        Console.WriteLine("Tienes dos opciones.");
                        return "vive";
                    }
                    else if (decisionLinterna == "2")
                    {
                        Console.WriteLine("Decides no tomar la linterna.");
                        Console.WriteLine("Todo está oscuro y vas por el pasillo.");
                        Console.WriteLine("Sientes que alguien te sigue, y cuando volteas no hay nadie.");
                        Console.WriteLine("Sientes un golpe en la cabeza y caes inconsciente.");
                        return "muereLinterna";   
                    }
                }
            }
        }
        else if (descicion == "2")
        {
            Console.WriteLine("La llamada se corta, y todo queda en silencio.");
            Console.WriteLine("La puerta de tu casa se abre de golpe, y alguien te golpea en la cabeza y caes inconsciente.");
            return "muere";
        }

        return "null";
    }
}