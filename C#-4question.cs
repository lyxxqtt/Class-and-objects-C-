using System;

class Program
{
    static void Main()
    {
        // gumawa ako ng array na may tatlong animals
        string[] animalsArr = { "cat", "dog", "bird" };

        // gumamit ako ng for loop para ma-display lahat ng animals
        for (int i = 0; i < animalsArr.Length; i++)
            // ipi-print yung bawat animal
            Console.WriteLine(animalsArr[i]);
    }
}
