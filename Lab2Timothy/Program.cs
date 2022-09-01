internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Question One:");
        Console.WriteLine("Please Enter a Number");
        int NumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("PLease Enter a Second Number");
        int NumberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");

        Console.WriteLine("Question 2:");
        Console.WriteLine("Input a Number to Multiply");
        int Multiple = Convert.ToInt32(Console.ReadLine());
        int[] Multi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        foreach (int i in Multi)
        {

            Console.WriteLine($"{Multiple} x {Multi} = {Multiple * Multi}");
        }


    }
}