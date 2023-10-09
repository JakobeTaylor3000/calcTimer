// September 18 2023
using System.Diagnostics;
using System;

class Program
{
    static void Main()
    {
        
        
        int n = 800000;
        double[,] numbers;
        float[,] numps;
        Stopwatch timer = new Stopwatch();


        numbers = GenerateRandomNumbers(n);
        numps = new float[n,3];


        for(int i = 0; i<n; ++i){
            numps[i,0] = (float)numbers[i,0];
            numps[i,1] = (float)numbers[i,1];
        }

        timer.Start();
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        float addTicks = (float)timer.ElapsedTicks;



        /**/
        timer.Restart();
        AddfNumbers(numps, n);
        timer.Stop();
        Console.WriteLine("Addition float");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        double addfTicks = (double)timer.ElapsedTicks;
        Console.WriteLine("Ratio = " + addTicks/addfTicks);
        /**/

        timer.Restart();
        sqviamulti(numbers, n);
        timer.Stop();
        Console.WriteLine("Square via multiplication ");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        int Square = (int)timer.ElapsedTicks;
        Console.WriteLine("Ratio = " + addTicks/Square);

        timer.Restart();
        Sq(numbers, n);
        timer.Stop();
        Console.WriteLine("Square with Math.Pow function ");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        int SquareM = (int)timer.ElapsedTicks;
        Console.WriteLine("Ratio = " + addTicks/SquareM);
     









        
    }

static double [,] GenerateRandomNumbers(int count)
        {
            
            Random rand = new Random();
            double[,] num = new double[count,3];
          for(int i=0; i<count; ++i)
        {
            num[i,0]= 10000*rand.NextDouble();
            num[i,1]=10000*rand.NextDouble();
        }
       
            return num;
        }

        // Function that adds numbers in the supplied 2d array


 static void AddNumbers(double[,] nums, int count)
        {
            int i;
            for(i=0; i<count; ++i){
                nums[i,2] = nums[i,0] + nums[i,1];
            }
        }



static void AddfNumbers(float[,] nums, int count)
        {
            int i;
            for(i=0; i<count; ++i){
                nums[i,2] = nums[i,0] + nums[i,1];
            }
        }

static void sqviamulti(double[,] nums, int count)
        {
            int i;
            for(i=0; i<count; ++i){
                nums[i,2] = nums[i,1]*nums[i,1];
            }
        }



static void Sq(double[,] nums, int count)
        {
            int i;
            for(i=0; i<count; ++i){
                nums[i,2] = Math.Pow(nums[i,0],nums[i,1]);
            }
        }









}






















