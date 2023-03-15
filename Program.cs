namespace examen
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Quants de nombres vols introduir?");
                int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
                if (n > 0)
                {
                    int[] numberArray = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Introdueix el nombre {0}", i + 1);
                        numberArray[i] = int.TryParse(Console.ReadLine(), out numberArray[i]) ? numberArray[i] : 0;
                    }

                    Console.WriteLine("El nombre mes gran es {0}", MesGran(numberArray));
                    Console.WriteLine("Vols sortir del programa? (S/N)");
                    string input = Console.ReadLine() ?? string.Empty;
                    if (input.ToUpper() == "S")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("El nombre ha de ser major que 0");
                }
            }
        }

        static int MesGran(int[] numberArray)
        {
            int mesGran = numberArray[0];
            foreach (int number in numberArray)
            {
                if (number > mesGran)
                {
                    mesGran = number;
                }
            }

            return mesGran;
        }
    }
}