using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ange storlek på kvadraten:");
        int storlek = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ange tecken för kvadraten:");
        char tecken = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Ange mellanrum i x- och y-led (eller tryck Enter för 0):");
        string mellanrumInput = Console.ReadLine();
        int mellanrum = string.IsNullOrEmpty(mellanrumInput) ? 0 : Convert.ToInt32(mellanrumInput);

        RitaKvadrat(storlek, tecken, mellanrum);
    }

    public static void RitaKvadrat(int storlek, char tecken, int mellanrum = 0)
    {
        for (int i = 0; i < storlek; i++)
        {
            for (int j = 0; j < storlek; j++)
            {
                Console.Write(tecken);

                if (j < storlek - 1)
                {
                    for (int k = 0; k < mellanrum; k++)
                    {
                        Console.Write(" ");
                    }
                }
            }

            for (int k = 0; k < mellanrum; k++)
            {
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
