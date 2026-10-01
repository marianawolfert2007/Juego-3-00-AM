public class NarrativaVives
{
    public static string[] Narraciones =
    {
        "Intenta buscar una salida. Buena suerte.",
        "Nada. Miras la cochera. Intentas abrirla. Nada. Está cerrada. Buscas algo con qué abrirla. No encuentras nada. Suspiras y sigues buscando. Nada. Comienzas a desesperarte. Subes al ático y lo cierras. Miras a tu alrededor.",
        "Subes al ático y lo cierras."
    };

    public static string[][] Decisiones =
    {
        new string[] { "1) Seguir las instrucciones que te dieron.", "2) Ver el ático." },
        new string[] { "1) Agarrar la escopeta.", "2) Salir por la ventana." },
        new string[] { "1) Agarrar la escopeta.", "2) Salir por la ventana." }
    };

    public static string[][] resultados =
    {
        new string[]
        {
            "Decides seguir las instrucciones que te dieron.",
            "Buscas otra salida. Miras todas las ventanas."
        },
        new string[]
        {
            "Miras a tu alrededor. Está apoyada junto a una vieja caja de herramientas. La tomas. Revisas el cargador. Dos cartuchos. —Bueno... espero que esto funcione. Los golpes se detienen. Silencio. Después escuchas pasos subiendo las escaleras. La puerta del ático comienza a abrirse lentamente. Una figura aparece al otro lado. No parece una persona. Es demasiado alta. El ente entra al ático. Te encuentra. Se lanza hacia ti. Levantas la escopeta. ¡BANG! El disparo golpea al ente, pero no cae y retrocedes. El ente vuelve a levantarse. Te queda un cartucho. Se acerca. Cada vez más rápido. Apuntas. ¡BANG! El ente cae al suelo. Por unos segundos no pasa nada. Entonces su cuerpo comienza a deshacerse lentamente, convirtiéndose en una especie de humo negro. El humo desaparece. Silencio. Te quedas mirando la escopeta. —...Creo que funcionó. Desde abajo se escucha un ruido. TOC. Te congelas. Otro golpe. TOC. Miras hacia la puerta. Era la ventana. El viento. Te dejas caer al suelo. Estás agotado. Pero sigues vivo.",
            "Sales por la ventana del ático y saltas a los arbustos. Escapas de la casa y te diriges a la estación de policía."
        },
        new string[]
        {
            "Miras a tu alrededor. Está apoyada junto a una vieja caja de herramientas. La tomas. Revisas el cargador. Dos cartuchos. —Bueno... espero que esto funcione. Los golpes se detienen. Silencio. Después escuchas pasos subiendo las escaleras. La puerta del ático comienza a abrirse lentamente. Una figura aparece al otro lado. No parece una persona. Es demasiado alta. El ente entra al ático. Te encuentra. Se lanza hacia ti. Levantas la escopeta. ¡BANG! El disparo golpea al ente, pero no cae y retrocedes. El ente vuelve a levantarse. Te queda un cartucho. Se acerca. Cada vez más rápido. Apuntas. ¡BANG! El ente cae al suelo. Por unos segundos no pasa nada. Entonces su cuerpo comienza a deshacerse lentamente, convirtiéndose en una especie de humo negro. El humo desaparece. Silencio. Te quedas mirando la escopeta. —...Creo que funcionó. Desde abajo se escucha un ruido. TOC. Te congelas. Otro golpe. TOC. Miras hacia la puerta. Era la ventana. El viento. Te dejas caer al suelo. Estás agotado. Pero sigues vivo.",
            "Sales por la ventana del ático y saltas a los arbustos. Escapas de la casa y te diriges a la estación de policía."
        }
    };

    public static int[][] Consecuencias =
    {
        new int[] { 1, 2 },
        new int[] { -1, -1 },
        new int[] { -1, -1 }
    };

    public static string[] intro =
    {
        "======================================",
        "VAMOS A VIVIR",
        "======================================",
        "",
        "Presiona ENTER para comenzar..."
    };
}