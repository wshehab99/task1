using System;

namespace without
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("please enter the number of rows");
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter the number of column");
                int columns = int.Parse(Console.ReadLine());
                float[,] array = new float[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine("Enter the value of araay [{0},{1}]", i, j);
                        array[i, j] = float.Parse(Console.ReadLine());
                    }
                }
                maxmax(array);
                maxmin(array);
                minmaxRegret(array);
            Console.WriteLine("------------------------------------------\n cost");
            minmin(array);
            minmax(array);
            minmaxRegret_cost(array);
                Console.ReadKey();

            }
            //for profit
            static void maxmax(float[,] array)
            {
                float max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > max) { max = array[i, j]; }
                    }
                }
                Console.WriteLine("the Maxmax = {0}", max);

            }
            //for cost
            static void minmin(float[,] array)
            {
                float min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min) { min = array[i, j]; }
                    }
                }
                Console.WriteLine("the Maxmax = {0}", min);

            }
            //for profit
            static void maxmin(float[,] array)
            {
                float[] mins = new float[array.GetLength(0)];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    float min = array[i, 0];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (array[i, j] < min) { min = array[i, j]; }

                    }
                    mins[i] = min;

                }
                float max = mins[0];
                for (int i = 0; i < mins.GetLength(0); i++)
                {
                    if (mins[i] > max)
                    {
                        max = mins[i];
                    }
                }
                Console.WriteLine("the maxmin = {0}", max);
            }
            //for cost
            static void minmax(float[,] array)
            {
                float[] mins = new float[array.GetLength(0)];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                float m = array[i, 0];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (array[i, j] > m) { m = array[i, j]; }

                    }
                    mins[i] = m;

                }
                float max = mins[0];
                for (int i = 0; i < mins.GetLength(0); i++)
                {
                    if (mins[i] < max)
                    {
                        max = mins[i];
                    }
                }
                Console.WriteLine("the maxmin = {0}", max);
            }
            //for profit
            static void minmaxRegret(float[,] array)
            {
                float[] tmp = new float[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    float max = array[0, i];
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[j, i] > max) { max = array[j, i]; }
                    }
                    tmp[i] = max;
                }
                float[,] result = new float[array.GetLength(0), array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        result[j, i] = tmp[i] - array[j, i];
                    }
                }
                float[] maxs = new float[result.GetLength(0)];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    float max = result[i, 0];
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (result[i, j] > max)
                        {
                            max = result[i, j];
                        }
                    }
                    maxs[i] = max;
                }
                float minRsult = maxs[0];
                for (int i = 0; i < maxs.GetLength(0); i++)
                {
                    if (maxs[i] < minRsult) { minRsult = maxs[i]; }
                }
                Console.WriteLine("Minimax Reget = {0}", minRsult);
            }
            //for cost
            static void minmaxRegret_cost(float[,] array)
            {
                float[] tmp = new float[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    float min = array[0, i];
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[j, i] < min) { min = array[j, i]; }
                    }
                tmp[i] = min;
                }
            
                float[,] result = new float[array.GetLength(0), array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        result[j, i] =  array[j, i]- tmp[i];
                    }
                }
            
                float[] maxs = new float[result.GetLength(0)];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    float max = result[i, 0];
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (result[i, j] > max)
                        {
                            max = result[i, j];
                        }
                    }
                    maxs[i] = max;
                }
                float minRsult = maxs[0];
                for (int i = 0; i < maxs.GetLength(0); i++)
                {
                    if (maxs[i] < minRsult) { minRsult = maxs[i]; }
                }
                Console.WriteLine("Minimax Reget = {0}", minRsult);
            }
        }


    }
