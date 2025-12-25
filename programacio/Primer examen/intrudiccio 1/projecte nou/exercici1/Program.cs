namespace Saludar;

class Program
{
    static void Main(string[] ags)
    {
        Console.WriteLine("Quin es el teu nom?");
        var nom = Console.ReadLine();

        Console.WriteLine("Quina edet tens?");
        var text = Console.ReadLine();
        int edad = Convert.ToInt16(text);

        Console.WriteLine($"Hola {nom}! Tens {edad} anys");
    }
}