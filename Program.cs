public class Program
{


    public static void Main(string[] args)

    {
        ForwardWhile(5, 1);
        Console.WriteLine();
        BackwardWhile(1, 5);
        Console.WriteLine();
        ForwardFor(5);
        Console.WriteLine();
        BackwardFor(5, 1);
        Console.WriteLine();
        Even100(1, 100);
        Console.WriteLine();
        SumNormal(1,5);
        Console.WriteLine();
        SumEven(1,10);
        Console.WriteLine();
        SumOdd(1,10);
        Console.WriteLine();
        RightTriangle(-70);

    }


    public static void ForwardWhile(int times, int timer)
    {

        while (timer <= times)
        {
            Console.WriteLine(timer);
            timer++;
        }

    }
    public static void BackwardWhile(int times, int timer)
    {

        while (timer >= times)
        {
            Console.WriteLine(timer);
            timer--;
        }

    }
    public static void ForwardFor(int j)
    {
        for (int i = 1; i <= j; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void BackwardFor(int u, int j)
    {
        for (int i = u; i >= j; i--)
        {
            Console.WriteLine(i);
        }
    }
    public static void Even100(int u, int j)
    {
        for (int i = u; i <= j; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void SumNormal(int u, int j)
    {
        int sum = 0;

        for (int i = u; i <= j; i++)
        {
            sum += i;

        }
        Console.WriteLine(sum);
    }
    public static void SumEven(int u, int j)
    {
        int sum = 0;

        for (int i = u; i <= j; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }

        }
        Console.WriteLine(sum);
    }
    public static void SumOdd(int u, int j)
    {
        int sum = 0;

        for (int i = u; i <= j; i++)
        {
            if (i % 2 == 0)
            { }
            else
            {
                sum += i;
            }

        }
        Console.WriteLine(sum);
    }
    public static void RightTriangle(int l)
    {
        int r = 0;
        if( l > 0 )
        {
        for (int i = r; i < l; i++)
        {
            for (int j = r; j <= i; j++)
            {
                Console.Write("*");
            }





            Console.WriteLine();
        }
        }
        else if(l<0)
        {
        for (int i = -l; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write("*");
            }





            Console.WriteLine();
        }
        }

        

    }

}