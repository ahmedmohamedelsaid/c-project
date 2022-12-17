 namespace ConsoleApp1
 reverse string
 {
    public static class Task1 
  {
         public static void Main(string[] args)
         {
             Console.Write("please enter a  string:");
             var s = Console.ReadLine();
             if (s == null) return;
            for (var i = s!.Length - 1; i >= 0; i--)
             {
                 Console.Write(s[i]);
             }
         }
    }
 }