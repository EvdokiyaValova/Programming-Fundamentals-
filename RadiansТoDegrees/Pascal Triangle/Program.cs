using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int n = 1;

            int[,] array = new int[numberLines, numberLines];
            int[,] currentArray = new int[numberLines, numberLines];

            for (int i = 0; i < numberLines; i++)
            {
                

                
                for (int j = 0; j <= i; j++)
                {
                    if (i ==0 && j == 0 )
                    {
  //                     n = 1;
                        currentArray[i,j] = 1;
                    }
                    else if (j == 0)
                    {
                        currentArray[i, j] = 1;
                    }

                    else if (i == j)
                    {
                        currentArray[i,j] = 1; ;
                    }

                    //else if (j >= i+1)
                    //{
                    //    currentArray[i] = 0; 
                    //}

                    else if ((j == 1 && i == 1))
                    {
                        currentArray[i,j] = 1; 
                    }


                    else if (j == 1)
                    {
                        currentArray[i,j] = i;
                    }

                    else if (j == i-1)
                    {
                        currentArray[i, j] = i;
                    }

                    else if (i >= 4 && j <= i-2)
                    {
                       currentArray[i,j] = currentArray[i - 1, j -1] + currentArray[i -1, j];

                }


                    //                   Console.Write(n);
       //             array[i] = currentArray[i];
              //      Console.Write(array[i,j] + " ");
                  Console.Write(currentArray[i,j]+" ");
                }

                
              //  Console.Write(array[i] + " ");
               Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
