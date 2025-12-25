namespace exercici2;

class Program
{
    static void Main(string[] args)
    {
        /*
           Console.WriteLine("Multiplicacdor1:");
           var numero1 = Console.ReadLine();
           int multiplicado1 = Convert.ToInt16(numero1);

           Console.WriteLine("Multiplicacdor2:");
           var numero2 = Console.ReadLine();
           int multiplicado2 = Convert.ToInt16(numero2);


           Console.WriteLine("El resultat de la multiplicacio es:" + (multiplicado1)*(multiplicado2));
       */
        Console.WriteLine("Multiplicador1");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Multiplicador2");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("El resultado es");
        int resultat = a * b;
        Console.WriteLine(resultat);

    }
}
