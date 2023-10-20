using System;
using System.Text;

int intentos = 6;
bool jugando = true;
        List<string> palabras = new List<string>();

        void HangMan()
        {

    //MostrarCabecera();

    string palabraElegida = SeleccionarPalabraAleatoria();
    string palabraOculta = OcultarPalabra(palabraElegida);
    DibujarLineas(palabraOculta);
    while (jugando)
    {
        if (intentos > 0)
        {
            char letraElegida = SolicitarLetra();
            ComprobarLetra(palabraElegida, letraElegida);
            palabraOculta = ReemplazarLineas(palabraElegida, palabraOculta, letraElegida);
        }
        else
        {
            Console.WriteLine("Has perdido");
            jugando = false;
        }
       
    }
  




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

        string SeleccionarPalabraAleatoria()
        {
            PrecargarPalabras();
            Random rand = new Random();
            string palabra = palabras[rand.Next(10)];
            return palabra;
        }

string OcultarPalabra(string palabraElegida)
{
    char replacement = '-';
    int i;
    int longitudPalabra = palabraElegida.Length;
    Console.WriteLine(palabraElegida);
    for (i = 0; i < longitudPalabra; i++)
    {

        StringBuilder guion = new StringBuilder(palabraElegida);
        guion[i] = replacement;
        palabraElegida = guion.ToString();

    }

    return palabraElegida;
}

void DibujarLineas(string palabraOculta)
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
    string letras = null;

    while (!comprobador)
    {
        letras = Console.ReadLine();
        if (letras.Length == 1)
        {
            if ((Char.IsLetter((char)letras[0])))
            {
                comprobador=true;
            }
            else
            {
                Console.WriteLine("Debe ser una letra, no otro caracter");
            }

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

    return letraSegura;
}

bool ComprobarLetra(string palabraComprobar, char letraComprobar)
{
    if (palabraComprobar.ToLower().Contains(letraComprobar))
    {
        return true;
    }
    else 
    {
        return false; 
    }
}

void DecrementarIntentos()
{
    intentos--;
}


String ReemplazarLineas(String palabraOriginal, String palabraOculta, char letraIntroducida)
{

    int i;
    int longitudPalabra = palabraOriginal.Length;
    int index = palabraOriginal.ToLower().IndexOf(letraIntroducida);
    StringBuilder guion = new StringBuilder(palabraOculta);
    if (index >= 0)
    {
        for (i = 0; i < longitudPalabra; i++)
        {
            if (palabraOriginal.ToLower()[i] == letraIntroducida)
            {

                guion[i] = letraIntroducida;
                Console.WriteLine(palabraOculta);
                palabraOculta = guion.ToString();
            }
        }
        Console.WriteLine(palabraOculta);
    }
    else
    {
        DecrementarIntentos();
        Console.WriteLine(intentos);
    }
    

    return palabraOculta;

}

HangMan();
           





        
    


