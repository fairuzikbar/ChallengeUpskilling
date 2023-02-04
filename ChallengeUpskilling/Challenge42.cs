// namespace ChallengeUpskilling;
//
// public class Challenge42
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Inputkan angka: ");
//         var numString = Console.ReadLine(); 
//         var num = Convert.ToInt32(numString);
//         
//         if (num >= 0)
//         {
//             for (int i = 1; i <= num; i++)
//             {
//                 if (num % i == 0)
//                 {
//                     Console.Write($"{i},");
//                 }
//
//                 Console.WriteLine(i);
//             }
//         }
//         else
//         {
//             for (int j = -1; j >= num; j--)
//             {
//                 if (num % j == 0)
//                 {
//                     Console.Write($"{j},");
//                 }
//             }
//         }
//         Console.WriteLine();
//     }
// }