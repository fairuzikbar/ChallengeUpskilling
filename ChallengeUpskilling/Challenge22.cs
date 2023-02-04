// namespace ChallengeUpskilling;
//
// public abstract class Shape
// {
//     public abstract int GetSurface();
//     public abstract int GetVolume();
// }
//
// public class Block : Shape
// {
//     public int Length { get; set; }
//     public int Width { get; set; }
//     public int Height { get; set; }
//     
//     public override int GetSurface()
//     {
//         return 2*((Length*Width)+(Width*Height)+(Length*Height));
//     }
//     
//     public override int GetVolume()
//     {
//         return Length*Width*Height;
//     }
// }
//
// public class Triangle : Shape
// {
//     public int Base { get; set; }
//     public int Height { get; set; }
//     
//     public override int GetSurface()
//     {
//         return 0;
//     }
//     
//     public override int GetVolume()
//     {
//         return 0;
//     }
//
//     public double GetArea()
//     {
//         return 0.5 * Base * Height;
//     }
// }
//
// public class Cube : Shape
// {
//     public int Side { get; set; }
//     
//     public override int GetSurface()
//     {
//         return 6*Side*Side;
//     }
//     
//     public override int GetVolume()
//     {
//         return Side*Side*Side;
//     }
// }
//
// public class Rectangle : Shape
// {
//     public int Length { get; set; }
//     public int Width { get; set; }
//     
//     public override int GetSurface()
//     {
//         return 0;
//     }
//     
//     public override int GetVolume()
//     {
//         return 0;
//     }
//
//     public double GetArea()
//     {
//         return Length * Width;
//     }
// }
//
// public class Challenge22
// {
//     public static void Main(string[] args)
//     {
//         
//         Console.Write("Inputkan Panjang: ");
//         var lString = Console.ReadLine();
//         var l = Convert.ToInt32(lString);
//         
//         Console.Write("Inputkan Lebar: ");
//         var wString = Console.ReadLine();
//         var w = Convert.ToInt32(wString);
//         
//         Console.Write("Inputkan Tinggi: ");
//         var hString = Console.ReadLine();
//         var h = Convert.ToInt32(hString);
//
//         Shape block = new Block
//         {
//             Length = l,
//             Width = w,
//             Height = h
//         };
//
//         int volume = block.GetVolume();
//         Console.WriteLine($"Hasil Volume: {volume}");
//         
//         int surface = block.GetSurface();
//         Console.WriteLine($"Hasil Luas: {surface}");
//     }
// }