        int intentos = 6;
        List<String> palabras = new List<String>();

        void HangMan()
        {

                //MostrarCabecera();
  
                SeleccionarPalabraAleatoria();

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
            string letraIntroducida = Console.ReadLine();
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
                Console.WriteLine();
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