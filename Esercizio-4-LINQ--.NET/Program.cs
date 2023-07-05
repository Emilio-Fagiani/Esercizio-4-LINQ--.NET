class Program
{
    static void Main()
    {
      
        List<int> numeriCasuali = GenerateRandomNumber(1000);

      
        var numeriOrdinati = numeriCasuali.OrderBy(n => n.ToString().Length);

      
        foreach (var numero in numeriOrdinati)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> GenerateRandomNumber(int quantita)
    {
        Random random = new Random();
        List<int> numeriCasuali = new List<int>();

        for (int i = 0; i < quantita; i++)
        {
            numeriCasuali.Add(random.Next(1000));
        }

        return numeriCasuali;
    }
}
