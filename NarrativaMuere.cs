public class NarrativaMuere
{
    public static string[] Narraciones =
    {
        "Te raptaron, buena suerte.",
        "Los entes se enojan y les dan golpes hasta hacerlos sangrar.",
        "Se disgustan, se enrabonan y les meten alfileres al cuerpo."
    };

    public static string[][] Decisiones =
    {
        new string[] { "1) Decirles groserías.", "2) Escupirles." },
        new string[] { "1) Gritar por ayuda.", "2) Llorar." },
        new string[] { "1) Gritar por ayuda.", "2) Llorar." }
    };

    public static string[][] resultados =
    {
        new string[]
        {
            "Tienes agallas.",
            "Estás pendejo."
        },
        new string[]
        {
            "Te comienzan a amputar las extremidades y mueres desangrado.",
            "Te cocinan vivo, ves tus órganos en la sopa y mueres del dolor."
        },
        new string[]
        {
            "Te comienzan a amputar las extremidades y mueres desangrado.",
            "Te cocinan vivo, ves tus órganos en la sopa y mueres del dolor."
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