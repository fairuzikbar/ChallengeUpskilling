// namespace ChallengeUpskilling;
//
// public class Challenge51
// {
//     public static void Main(string[] args)
//     {
//         int[] numbers = {1,2,3,4,5,6};
//         int[] anotherNumbers = {4,5,6,7,8,9,10};
//
//         if (numbers.Length < anotherNumbers.Length)
//         {
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 for (int j = 0; j < anotherNumbers.Length; j++)
//                 {
//                     if (numbers[i] == anotherNumbers[j])
//                     {
//                         Console.Write($"{numbers[i]}, ");
//                     }
//                 }
//             }
//             Console.WriteLine();
//         }
//         else
//         {
//             for (int i = 0; i < anotherNumbers.Length; i++)
//             {
//                 for (int j = 0; j < numbers.Length; j++)
//                 {
//                     if (numbers[i] == anotherNumbers[j])
//                     {
//                         Console.Write($"{numbers[i]}, ");
//                     }
//                 }
//             }
//             Console.WriteLine();
//         }
//     }
// }