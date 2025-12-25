
namespace superfort;

public class Program
{
    static void Main(string[] args)
    {
        var paquets = new int[] { 7, 2, 3, 9 };
        var maxim = 10;

        var resultat = CalculaViatges(maxim, paquets);

        Console.WriteLine($"{resultat} viatges");
    }

    public static int CalculaViatges(int maxim, int[] paquets)
    {
        var viatges = 0;
        if (paquets.Length == 0) return -1;
        Array.Sort(paquets);
        if (paquets[paquets.Length-1]>=maxim || paquets[0]<0) {
            return -1;
        }

        for(var i=0; i<paquets.Length; i++)
        {
            if (paquets[i] != 0)
            {
            var primer = paquets[i];
            for(var j=i+1; j<paquets.Length; j++)
            {
                if (paquets[j] + primer < maxim)
                {
                    primer += paquets[j];
                    paquets[j] = 0;
                }
            }
            viatges++;
            }
        }
        return viatges;
    }
}
