public class NarrativaMuere
{
    public static string[] Narraciones =
    {
        "Te raptaron, buena suerte.",
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
            "La tomas. Revisas el cargador. Vacío. Los golpes se detienen. Silencio. Escuchas pasos subiendo las escaleras. La puerta del ático se abre lentamente. Aprietas el gatillo. Clic. Lo último que ves es tu propia cara, sonriéndote. Todo se vuelve negro.",
            "Sales por la ventana y caes sobre los arbustos. Levantas la vista. Alguien te esperaba abajo. —Te dije que no abrieras la puerta. Todo se vuelve negro."
        },
        new string[]
        {
            "La tomas. Revisas el cargador. Vacío. Los golpes se detienen. Silencio. Escuchas pasos subiendo las escaleras. La puerta del ático se abre lentamente. Aprietas el gatillo. Clic. Lo último que ves es tu propia cara, sonriéndote. Todo se vuelve negro.",
            "Sales por la ventana y caes sobre los arbustos. Levantas la vista. Alguien te esperaba abajo. —Te dije que no abrieras la puerta. Todo se vuelve negro."
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
        "VAMOS A MORIR",
        "======================================",
        "",
        "Presiona ENTER para comenzar..."
    };
}