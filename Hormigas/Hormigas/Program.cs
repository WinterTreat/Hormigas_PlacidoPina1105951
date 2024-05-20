using System;

/*Lo que hice fue tomar la letra "a" como la cabeza de la hormiga. 
  Si la letra "a" no va seguida de "nt" se cuenta como cadáver.*/

// También decidí que sería buena idea que el usuario pudiera poner las hormigas que quisiera.
// Aquí le dejo el del ejercicio para que lo pueda probar: ...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t
class NoMasHormigas
{
    static void Main()
    {
        Console.Write("Pon a las hormigas: ");
        string input = Console.ReadLine();

        int deadAntCount = Contador(input);

        Console.Write($"Hormigas muertas: {deadAntCount}");
    }

    static int Contador(string input)
    {
        int deadAntCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a')
            {
                // Aqui confirmo si la "a" va seguida de "nt"
                if (i + 2 >= input.Length || input[i + 1] != 'n' || input[i + 2] != 't')
                {
                    deadAntCount++;
                }
            }
        }

        return deadAntCount;
    }
}