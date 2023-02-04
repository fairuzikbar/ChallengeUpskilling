// namespace ChallengeUpskilling;
//
// public class Character
// {
//     public string Nama { get; set; }
//     public string Peran { get; set; }
// }
//
// public class Challenge34
// {
//     public static void Main(string[] args)
//     {
//         var character = new Character();
//         Console.Write("Nama: ");
//         character.Nama = Console.ReadLine();
//         var name = character.Nama;
//         
//         Console.Write("Peran: ");
//         character.Peran = Console.ReadLine();
//         var role = character.Peran;
//
//         if (name == "" && role == "")
//         {
//             Console.WriteLine("Nama dan Peran harus diisi");
//         }
//         else if (name is not null && (role.ToLower() != "superhero" || role.ToLower() != "monster"))
//         {
//             Console.WriteLine($"Selamat datang {name}, pilih peranmu untuk melanjutkan game ini");
//         }
//         else
//         {
//             if (role.ToLower() == "superhero")
//             {
//                 Console.WriteLine($"Selamat datang {name}, kalahkan semua Monster di Muka Bumi");
//             }
//             else if (role.ToLower() == "monster")
//             {
//                 Console.WriteLine($"Selamat datang Monster {name}, hancurkan semua Superhero yang ada");
//             }
//         }
//     }
// }