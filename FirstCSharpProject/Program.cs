using System;

namespace FirstCSharpProject
{
    class Program
    {
        static void Main(string[] args) //cria um metódo básico para todo programa em C#
        {
            int x = 10; //cria uma variável x com valor 10
            double y = 20; //cria uma variável y com valor 20
            string yourName; //cria uma variável do tipo String

            Console.WriteLine("Hello World!"); //mostra na tela "Hello World"
            Console.WriteLine("x = {0}; y = {1}", x, y); // retorna "x = 10; y = 20", substituindo {0} e {1} pelo valor de x e y, respectivamente

            Console.WriteLine("What's your name?"); // mostra na tela o que está entre aspas

            yourName = Console.ReadLine(); // cria uma variável de entrada de dados

            Console.WriteLine("Hello {0}", yourName); // retorna "Hello" e o nome do usuário
        }
    }
}
