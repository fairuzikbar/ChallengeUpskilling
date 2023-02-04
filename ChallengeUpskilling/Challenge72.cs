// namespace ChallengeUpskilling;
//
// public class Challenge72
// {
//     public static void Main(string[] args)
//     {
//         int[] numbers = { 6, 2, 4, 10, 5 };
//         List<int> list = FindMinMax(numbers);
//         Console.WriteLine("Max: {0} - Min: {1}", list[0], list[1]);
//     }
//
//     public static List<int> FindMinMax(int[] numbers)
//     {
//         Array.Sort(numbers);
//         int minNum = numbers[0];
//         int maxNum = numbers[numbers.Length-1];
//
//         return new List<int>
//         {
//             maxNum, minNum
//         };
//     }
// }