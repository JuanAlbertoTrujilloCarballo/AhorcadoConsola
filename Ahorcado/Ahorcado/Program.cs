
        int vidas = 6;

        static void Ahorcado(int vidas)
        {
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
            string letraIntroducida = Console.ReadLine();


                while( letraIntroducida != null )
                {

                }
    */
                    while (vidas >= 1)
                    {   
                        Console.WriteLine(vidas+" 1");
                        vidas--;
                    }     

        }

        static void palabraAzar()
        {
            List<String> posiblesPalabras = new List<String>();
            posiblesPalabras.Add("Programacion");
            posiblesPalabras.Add("Matematicas");
            posiblesPalabras.Add("Naruto");
            posiblesPalabras.Add("Ordenador");
            posiblesPalabras.Add("Dragon");
            posiblesPalabras.Add("Escorpion");
            posiblesPalabras.Add("Nintendo");
            posiblesPalabras.Add("Unity");
            posiblesPalabras.Add("Tiranosaurio");
            posiblesPalabras.Add("Videojuegos");

            Random rand = new Random();
            Console.WriteLine(posiblesPalabras[rand.Next(11)]);
        }

            Ahorcado(vidas);
            palabraAzar();





        
    


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