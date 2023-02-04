// namespace ChallengeUpskilling;
//
// public class Challenge43
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Inputkan angka: "); 
//         var numString = Console.ReadLine(); 
//         var num = Convert.ToInt32(numString);
//
//         int x = 0;
//         int banyak = 0;
//         
//         while (x < num*2)
//         {
//             if (x <= num)
//             {
//                 banyak = x;
//             }
//             else
//             {
//                 banyak = num * 2 - x;
//             }
//             
//             for (int i = 0; i < banyak; i++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//             x++;
//         }
//     }
// }