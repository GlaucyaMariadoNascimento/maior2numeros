using System;

namespace maior2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
           
        int numero=0, maior=0 ;

        Console.WriteLine("Determine o maior valor");

        Console.Write("Informe o 1 valor: ");
        numero = Convert.ToInt32(Console.ReadLine());

        maior = numero;

        Console.Write("Informe o 2 valor: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero > maior){
            maior = numero;
        }
        Console.WriteLine("O maior valor informado é: "+maior);
        Console.ReadKey();
        }
    }
}
