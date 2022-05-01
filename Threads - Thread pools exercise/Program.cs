using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        TreadpoolExercise tpe = new TreadpoolExercise();
        ThreadpoolExercise3 tpe3 = new ThreadpoolExercise3();
        Console.WriteLine("1. Thread pool vs threads");
        Console.WriteLine("2. Task 3");
        switch(Console.ReadKey().KeyChar) {
            case '1':
                tpe.Exercise2();
                break;
            case '2':
                tpe3.Exercise3();
                break;
        }

    }
}

#region Task 2
public class TreadpoolExercise
{
    public void Exercise2()
    {
        Stopwatch mywatch = new Stopwatch();
        Console.WriteLine("Thread Pool Execution");
        mywatch.Start();
        WithThreadPool();
        mywatch.Stop();
        Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());

        mywatch.Reset();
        Console.WriteLine("Thread Execution");
        mywatch.Start();
        WithoutThreadPool();
        mywatch.Stop();
        Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());


    }

    static void WithoutThreadPool()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(Process);
            thread.Start();
        }
    }
    static void WithThreadPool()
    {
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(Process);
        }
    }
    static void Process(object callback)
    {
        for (int i = 0; i < 100000; i++)
        {
            for (int j = 0; j < 100000; j++)
            {
            }

        }

    }

}
#endregion


#region Task 3
public class ThreadpoolExercise3
{
    public void Exercise3()
    {
        ThreadPool.QueueUserWorkItem(Endless);


    }

    static void Endless(object callback)
    {
        while (true)
        {
        }
    }

    static void EndlessAlive(object callback)
    {
        while (true)
        {
            if ()
        }
    }
}
#endregion
