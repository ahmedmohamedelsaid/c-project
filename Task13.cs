namespace ConsoleApp1;

public class Task13
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        var average = arr.Average();
        Console.Write("the numbers greater than avg are : " );
        foreach (var i in arr)
        {
            if (i>average)
            {
                Console.Write($"{i} ");
            }
        }
    }
}