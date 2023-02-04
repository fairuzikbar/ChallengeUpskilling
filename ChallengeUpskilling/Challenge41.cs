// namespace ChallengeUpskilling;
//
// public class Challenge41
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Inputkan Angka: ");
//         var numString = Console.ReadLine();
//         var num = Convert.ToInt32(numString);
//
//         int oddSum = 0;
//         int evenSum = 0;
//
//         if (num >= 1)
//         {
//             Console.Write("Ganjil: ");
//             for (int i = 0; i < num; i++)
//             {
//                 if (i % 2 == 1)
//                 {
//                     oddSum += i;
//                     Console.Write($"{i} ");
//                 }
//             }
//             Console.Write($"= {oddSum}");
//             Console.WriteLine();
//             Console.Write("Genap: ");
//             for (int j = 1; j <= num * 2; j++)
//             {
//                 if (j % 2 == 0)
//                 {
//                     evenSum += j;
//                     Console.Write($"{j} ");
//                 }
//             }
//             Console.Write($"= {evenSum}");
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Angka harus POSITIF");
//         }
//     }
// }