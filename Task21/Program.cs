int[] InputDotPosition(int dotNum)
{
    int[] DotPosition = new int[3];
    
    Console.Write($"x{dotNum} = ");
    DotPosition[0] = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"y{dotNum} = ");
    DotPosition[1] = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"z{dotNum} = ");
    DotPosition[2] = Convert.ToInt32(Console.ReadLine());

    return DotPosition;
}

double GetDistance(int[] dot1, int[]dot2)
{
    double Res = 0;
    for(int i = 0; i < 3; i++)
    {
        Res += Math.Pow(dot2[i] - dot1[i], 2);
    }

    Res = Math.Sqrt(Res);

    return Res;
}

int[] dot1 = InputDotPosition(1);
int[] dot2 = InputDotPosition(2);

Console.WriteLine($"Distance : {GetDistance(dot1, dot2)}");