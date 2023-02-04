namespace ChallengeUpskilling;

public class Challenge82
{
    public static void Main(string[] args)
    {
        Console.Write("Tentukan posisi awal robot: "); // Masukkan dengan format (direction,x,y) tanpa spasi
        string? first = Console.ReadLine();
        char direction = first![0];
        int x = int.Parse(first[2].ToString());
        int y = int.Parse(first[4].ToString());
        
        Console.Write("Input perintah: ");
        string? moves = Console.ReadLine();
        
        RobotMoving(direction, x, y, 0, moves!);
    }

    public static void RobotMoving(char direction, int x, int y, int step, string moves = "AARAAAA")
    {
        int[,] coord = new int[1,2];
        string moveString = moves;
        List<char> Moves = new List<char>();

        foreach (var move in moveString)
        {
            Moves.Add(move);
        }

        coord[0, 0] = x;
        coord[0, 1] = y;

        for (int i = step; i < Moves.Count; i++)
        {
            switch (Moves[i])
            {
                case 'A':
                    if (direction == 'E')
                    {
                        if (Moves.IndexOf('R') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                            {
                                break;
                            }
                        }
                        else if (Moves.IndexOf('L') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                            {
                                break;
                            }
                        }
                        x += 1;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                    }
                    else if (direction == 'S')
                    {
                        if (Moves.IndexOf('R') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                            {
                                break;
                            }
                        }
                        else if (Moves.IndexOf('L') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                            {
                                break;
                            }
                        }
                        y -= 1;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                    }
                    else if (direction == 'W')
                    {
                        if (Moves.IndexOf('R') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                            {
                                break;
                            }
                        }
                        else if (Moves.IndexOf('L') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                            {
                                break;
                            }
                        }
                        x -= 1;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                    }
                    else if (direction == 'N')
                    {
                        if (Moves.IndexOf('R') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                            {
                                break;
                            }
                        }
                        else if (Moves.IndexOf('L') < 0)
                        {
                            if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                            {
                                break;
                            }
                        }
                        y += 1;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                    }
                    break;
                case 'R':
                    if (direction == 'E')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'S';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'S')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'W';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'W')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'N';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'N')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('R') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'E';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    break;
                case 'L':
                    if (direction == 'E')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'N';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'S')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'E';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'W')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'S';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    else if (direction == 'N')
                    {
                        if (step == Moves.Count || (i > Moves.IndexOf('L') && step == 0))
                        {
                            break;
                        }
                        x += 0;
                        y += 0;
                        coord[0, 0] = x;
                        coord[0, 1] = y;
                        Console.WriteLine($"{Moves[i]} -> ({coord[0, 0]},{coord[0, 1]})");
                        direction = 'S';
                        step = 0;
                        RobotMoving(direction, x, y, i+1);
                    }
                    break;
            }
        }
    }
}