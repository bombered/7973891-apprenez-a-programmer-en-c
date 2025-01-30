using System;

namespace Hello
{
    /// <summary>
    /// Ceci est une implémentation du message traditionnel «·Hello world!·»
    /// </summary>
    /// <remarks>Créée par l'équipe éducative d'OpenClassrooms</remarks>
    public class HelloWorld
    {
        /// <summary>
        /// Le programme commence ici
        /// </summary>
        public static void Main(string[] args)
        {
            AfficheBonjour();
        }

        public static void AfficheBonjour()
        {
            Console.WriteLine("Hello World!");
            int nombreDeTasses = 0;

            do
            {
                Console.WriteLine("J'ai sommeil");
                nombreDeTasses += 1;
                Console.WriteLine("J'ai bu " + nombreDeTasses + " tasses de café");
            } while (nombreDeTasses < 10);

            Console.WriteLine("À présent, je me sens réveillé·!" + nombreDeTasses);
        }
    }
}