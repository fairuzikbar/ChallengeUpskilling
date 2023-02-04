// namespace ChallengeUpskilling;
//
// public class Challenge53
// {
//     public static void Main(string[] args)
//     {
//         int[] arr ={7,20,39,2,48,520,5,5};
//         // Array.Sort(arr); // menggunakan method C#
//
//         for (int i = 1; i < arr.Length; i++)
//         {
//             int val = arr[i];
//             int flag = 0;
//
//             for (int j = i-1; j >= 0 && flag != 1;)
//             {
//                 if (val < arr[j])
//                 {
//                     arr[j + 1] = arr[j];
//                     j--;
//                     arr[j + 1] = val;
//                 }
//                 else
//                 {
//                     flag = 1;
//                 }
//             }
//         }
//
//         foreach (var ar in arr)
//         {
//             Console.WriteLine(ar);
//         }
//     }
// }