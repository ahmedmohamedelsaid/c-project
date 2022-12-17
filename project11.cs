 namespace ConsoleApp1;

 public class Task11
 {
     public static void Main(string[] args)
  {
         Console.Write("please enter a list separated by space :");
        var s = Console.ReadLine()?.Split();
        if (s== null)return;
        var newString = "";
         for (int i = 0; i < s.Length; i++)
         {
             if (i == s.Length-1)
             {
                 newString = newString.Insert(newString.Length  , s[i]);
                break;
            }             newString = newString.Insert(newString.Length  , $"{s[i]} , ");
             var current = Convert.ToInt32(s[i]);
             var next = Convert.ToInt32(s[i+1]);
             while ((current + 1) != next)
             {
                newString = newString.Insert(newString.Length, $"{++current} , ");
             }
         }
         Console.Write(newString);
     } }