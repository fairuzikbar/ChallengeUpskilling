// namespace ChallengeUpskilling;
//
// public class Challenge73
// {
//     public static void Main(string[] args)
//     {
//         int[] numbers = {4, 3, 2, 1, -1, -3, -4};
//         List<int> numbers2 = new List<int>();
//
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             int a = Array.Find(numbers, j => j == -numbers[i]);
//             if (a == 0)
//             {
//                 numbers2.Add(-numbers[i]);
//             }
//         }
//         numbers2.Sort();
//         if (numbers2.Count > 0)
//         {
//             Console.WriteLine(numbers2[0]);
//         }
//         else
//         {
//             Console.WriteLine(numbers2[numbers2.Count-1]);
//         }
//     }
// }