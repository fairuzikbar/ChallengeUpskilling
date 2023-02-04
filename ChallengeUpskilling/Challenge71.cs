// namespace ChallengeUpskilling;
//
// public class Challenge71
// {
//     public static void Main(string[] args)
//     {
//         int[] bamboos = { 3, 2, 2 };
//         int cuts = 2;
//         
//         Console.Write("Bamboos: ");
//         for (int y = 0; y < bamboos.Length; y++)
//         {
//             Console.Write($"{bamboos[y]},");
//         }
//         Console.WriteLine();
//         Console.WriteLine($"Cuts: {cuts}");
//         Console.WriteLine("Initials:");
//         
//         for (int i = 0; i < bamboos.Length; i++)
//         {
//             
//             Console.Write("|");
//
//             for (int j = 0; j < bamboos[i]; j++)
//             {
//                 Console.Write("-");
//             }
//             Console.WriteLine();
//         }
//
//         for (int x = 0; x < cuts; x++)
//         {
//             Console.WriteLine($"Cycle cuts: {x+1}");
//         
//             for (int i = 0; i < bamboos.Length; i++)
//             {
//                 Console.Write("|");
//
//                 for (int j = 0; j < bamboos[i]-x-1; j++)
//                 {
//                     Console.Write("-");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }