// namespace ChallengeUpskilling;
//
// public class Challenge35
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Tanggal: ");
//         var dateString = Console.ReadLine();
//         var date = Convert.ToInt32(dateString);
//         
//         Console.Write("Bulan: ");
//         var monthString = Console.ReadLine();
//         var month = Convert.ToInt32(monthString);
//         
//         Console.Write("Tahun: ");
//         var yearString = Console.ReadLine();
//         var year = Convert.ToInt32(yearString);
//
//         switch (month)
//         {
//             case 1:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Januari {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Januari hanya ada 31 hari");
//                 }
//                 break;
//             case 2:
//                 if (year % 4 == 0)
//                 {
//                     if (date >= 1 && date <= 29)
//                     {
//                         Console.WriteLine($"{date} Februari {year}");
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Bulan Februari tahun {year} hanya ada 29 hari");
//                     }
//                 }
//                 else if(year % 4 != 0)
//                 {
//                     if (date >= 1 && date <= 28)
//                     {
//                         Console.WriteLine($"{date} Februari {year}");
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Bulan Februari tahun {year} hanya ada 28 hari");
//                     }
//                 }
//                 break;
//             case 3:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Maret {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Maret hanya ada 31 hari");
//                 }
//                 break;
//             case 4:
//                 if (date >= 1 && date <= 30)
//                 {
//                     Console.WriteLine($"{date} April {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan April hanya ada 30 hari");
//                 }
//                 break;
//             case 5:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Mei {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Mei hanya ada 31 hari");
//                 }
//                 break;
//             case 6:
//                 if (date >= 1 && date <= 30)
//                 {
//                     Console.WriteLine($"{date} Juni {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Juni hanya ada 30 hari");
//                 }
//                 break;
//             case 7:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Juli {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Juli hanya ada 31 hari");
//                 }
//                 break;
//             case 8:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Agustus {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Agustus hanya ada 31 hari");
//                 }
//                 break;
//             case 9:
//                 if (date >= 1 && date <= 30)
//                 {
//                     Console.WriteLine($"{date} September {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan September hanya ada 30 hari");
//                 }
//                 break;
//             case 10:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Oktober {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Oktober hanya ada 31 hari");
//                 }
//                 break;
//             case 11:
//                 if (date >= 1 && date <= 30)
//                 {
//                     Console.WriteLine($"{date} November {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan November hanya ada 30 hari");
//                 }
//                 break;
//             case 12:
//                 if (date >= 1 && date <= 31)
//                 {
//                     Console.WriteLine($"{date} Desember {year}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Bulan Desember hanya ada 31 hari");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("Format tanggal invalid");
//                 break;
//         }
//     }
// }