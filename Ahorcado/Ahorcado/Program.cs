using System.Text;

int intentos = 6;
        List<String> palabras = new List<String>();

        void HangMan()
        {

    //MostrarCabecera();

    String palabraElegida = SeleccionarPalabraAleatoria();
    String PalabraOculta = OcultarPalabra(palabraElegida);
    DibujarLineas(PalabraOculta);
    SolicitarLetra();






    //while (letraIntroducida != null)
    //{

    //}

    // while (intentos > 0)
    //{   
    //    Console.WriteLine(intentos + " 1");
    //    intentos--;
    //}     

}

        void MostrarCabecera()
        {
            Console.WriteLine("+-------------------------------------+");
            Console.WriteLine("|  +---+    -----------------         |");
            Console.WriteLine("|  |   |    JUEGO:AHORCADO            |");
            Console.WriteLine("|      |    LENGUAJE:C#               |");
            Console.WriteLine("|      |    AUTOR: ALBERTO T.C.       |");
            Console.WriteLine("|      |    -----------------         |");
            Console.WriteLine("|      |   PROGRAMACIÓN Y MOTORES     |");
            Console.WriteLine("+-------------------------------------+");
        
            Console.WriteLine("--------------------");
        
            Console.WriteLine("--------------------");
            Console.WriteLine("VIDAS RESTANTES: 6");
            Console.WriteLine("--------------------");
            Console.Write("Introduce UNA letra: ");
            string letraIntroducida = Console.ReadLine() ?? "";
}

        void PrecargarPalabras()
        {
            
            palabras.Add("Programacion");
            palabras.Add("Matematicas");
            palabras.Add("Naruto");
            palabras.Add("Ordenador");
            palabras.Add("Dragon");
            palabras.Add("Escorpion");
            palabras.Add("Nintendo");
            palabras.Add("Unity");
            palabras.Add("Tiranosaurio");
            palabras.Add("Videojuegos");

            
        }

        String SeleccionarPalabraAleatoria()
        {
            PrecargarPalabras();
            Random rand = new Random();
            string palabra = palabras[rand.Next(10)];
            return palabra;
        }

String OcultarPalabra(String palabraElegida)
{
    char replacement = '-';
    int i;
    int longitudPalabra = palabraElegida.Length;
    Console.WriteLine(palabraElegida+" 1");
    for (i = 0; i < longitudPalabra; i++)
    {

        StringBuilder guion = new StringBuilder(palabraElegida);
        guion[i] = replacement;
        palabraElegida = guion.ToString();

    }

    return palabraElegida;
}

void DibujarLineas(String palabraOculta)
{
 
    string remplazado = palabraOculta.Replace("-", "- ");

    //Console.WriteLine(remplazado);
}

int IntentosRestantes()
{
    return intentos;
}

char SolicitarLetra()
{
    bool comprobador = false;
    String letras = null;

    while (!comprobador)
    {
        letras = Console.ReadLine();
        if (letras.Length == 1)
        {
            comprobador=true;
        }
        else if (letras.Length > 1)
        {
            Console.WriteLine("Solo debe ser una letra");
        }
        else
        {
            Console.WriteLine("Introduce una letra");
        }
    }




    char letraSegura = char.Parse(letras);
    Console.WriteLine(letraSegura);

    return letraSegura;
}

HangMan();
           





        
    


/*
Console.WriteLine("+-------------------------------------+");
Console.WriteLine("|  +---+    -----------------         |");
Console.WriteLine("|  |   |    JUEGO:AHORCADO            |");
Console.WriteLine("|      |    LENGUAJE:C#               |");
Console.WriteLine("|      |    AUTOR: ALBERTO T.C.       |");
Console.WriteLine("|      |    -----------------         |");
Console.WriteLine("|      |   PROGRAMACIÓN Y MOTORES     |");
Console.WriteLine("+-------------------------------------+");

Console.WriteLine("--------------------");


Console.WriteLine("--------------------");
Console.WriteLine("VIDAS RESTANTES: 6");
Console.WriteLine("--------------------");
Console.Write("Introduce UNA letra: ");
*/