using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoHero = new Calculo();

            //sem argumentos
            System.Console.WriteLine( infoHero.Calcular() );

            //1 argumento int 
            System.Console.WriteLine( infoHero.Calcular(2323));

            //2 argumentos int 
            System.Console.WriteLine( infoHero.Calcular(2323,450) );

            //2 argumentos string
            System.Console.WriteLine( infoHero.Calcular("Tobias ", "Fate") );
        }
    }
}
