using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("~~~~TAMA O MALI~~~~");
        int score;
        do
        {
            score = 0; 

            Console.WriteLine("1. Ang C# ba ay isang programming language?");
            string firstQues = Console.ReadLine();

            Console.WriteLine("2. For Backend lang ba ang C#? ");
            string secondtQues = Console.ReadLine();

            Console.WriteLine("3. Puwede ba ito gamitin for backend sa webdevelopment? ");
            string thirdtQues = Console.ReadLine();

            Console.WriteLine("4. Csharp ba ang meaning C#? ");
            string fourthtQues = Console.ReadLine();

            if (firstQues == "tama") score++;
            if (secondtQues == "mali") score++;
            if (thirdtQues == "tama") score++;
            if (fourthtQues == "tama") score++;

            Console.WriteLine("\nAng score mo ay: " + score + "/4");

            if (score < 2)
            {
                Console.Clear();
                Console.WriteLine("Bagsak ka, retake ka:\n");
            }

        } while (score < 3);

        Console.WriteLine("Congrats ANG GALING MO!");
    }
}
