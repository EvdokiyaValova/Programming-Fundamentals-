using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {

        static void Main(string[] args)
        {
            int lenghtField = int.Parse(Console.ReadLine());
            int[] indexArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrLadybugs = new int[lenghtField];

            for (int i = 0; i < indexArray.Length; i++)  // настаняваме калинките в полето
            {
                if (indexArray[i] >= 0 && indexArray[i] < arrLadybugs.Length)
                {
                    arrLadybugs[indexArray[i]] = 1;                        
                }                 
            }
           // Console.WriteLine(string.Join(" ", arrLadybugs));
            
            string input = Console.ReadLine();
            string[] comand = new string[3];

            while (input != "end")
            {
                comand = input.Split().ToArray();
                int indexLadybugs = int.Parse(comand[0]);
                string directions = comand[1];
                int fly = int.Parse(comand[2]);
                //               int newPositions = 0;  //първоначалната позиция на калинката
                
                if ((indexLadybugs >= 0
                    && indexLadybugs < arrLadybugs.Length) // ако позицията е в полето
                    && arrLadybugs[indexLadybugs] == 1                  // и има калинка
                    && fly != 0)                                      // и тя се мести
                {
                    if (directions == "right") // ако се движи надясно
                    {
                        if (indexLadybugs + fly >= 0      // ако е в полето
                            && indexLadybugs + fly < arrLadybugs.Length
                            && arrLadybugs[indexLadybugs + fly] == 0)    // и е празно мястото
                        {
                            arrLadybugs[indexLadybugs + fly] = 1;  // го заема
                            
                        }
                        else if (indexLadybugs + fly >= 0             //и е в полето 
                               && indexLadybugs + fly < arrLadybugs.Length
                               && arrLadybugs[indexLadybugs + fly] == 1) // ако е заето
                        {
//                            indexLadybugs += fly;

                            while (arrLadybugs[indexLadybugs + fly] == 1  // докато е заето
                                 && indexLadybugs + fly >= 0             //и е в полето 
                                 && indexLadybugs + fly < arrLadybugs.Length)     
                            {

                                fly += fly;
                                if (indexLadybugs + fly >= 0      // ако е в полето
                                    && indexLadybugs + fly < arrLadybugs.Length)
                                {                                   

                                                                
                                  if (indexLadybugs + fly >= 0      // ако е в полето
                                    && indexLadybugs + fly < arrLadybugs.Length
                                    && arrLadybugs[indexLadybugs + fly] == 0)    // и е празно мястото
                                  {
                                    arrLadybugs[indexLadybugs + fly] = 1;  // го заема
                                  }
                                  else if (indexLadybugs + fly >= 0     // ако е в полето
                                    && indexLadybugs + fly < arrLadybugs.Length
                                    && arrLadybugs[indexLadybugs + fly] == 1)  // но е зето , продължава отново да търси
                                  {
                                    continue;
                                  }
                                }
                            //    else if (!(indexLadybugs + fly >= 0      // ако не е в полето
                            //        && indexLadybugs + fly < arrLadybugs.Length))
                            //    {
                            //        break;
                            //    }
                            }
                        }
                    }
                    else if (directions == "left") // ако се движи наляво
                    {

                        if (indexLadybugs - fly >= 0      // ако е в полето
                                  && indexLadybugs - fly < arrLadybugs.Length
                                  && arrLadybugs[indexLadybugs - fly] == 0)    // и е празно мястото
                        {
                            arrLadybugs[indexLadybugs - fly] = 1;  // го заема
                          
                        }
                        else if (indexLadybugs - fly >= 0             //и е в полето 
                                 && indexLadybugs - fly < arrLadybugs.Length
                                 && arrLadybugs[indexLadybugs - fly] == 1)  // ако е заето
                        {
 //                           indexLadybugs -= fly;
                            while (arrLadybugs[indexLadybugs - fly] == 1  // докато е заето
                                       && indexLadybugs - fly >= 0             //и е в полето 
                                       && indexLadybugs - fly < arrLadybugs.Length)
                            {
                                fly += fly;
                                if (indexLadybugs - fly >= 0      // ако е в полето
                                    && indexLadybugs - fly < arrLadybugs.Length)
                                {
                                    
                              

                                  if (indexLadybugs - fly >= 0     // ако е в полето
                                    && indexLadybugs - fly < arrLadybugs.Length
                                    && arrLadybugs[indexLadybugs - fly] == 0)    // и е празно мястото
                                  {
                                    arrLadybugs[indexLadybugs - fly] = 1;  // го заема
                                  }
                                  else if (indexLadybugs - fly >= 0     // ако е в полето
                                    && indexLadybugs - fly < arrLadybugs.Length
                                    && arrLadybugs[indexLadybugs - fly] == 1)  // но е зето , продължава отново да търси
                                  {
                                    continue;
                                  }
                                    //else if (!(indexLadybugs - fly >= 0      // ако не е в полето
                                    //    && indexLadybugs - fly < arrLadybugs.Length))
                                    //{
                                    //    break;
                                    //}
                                }
                            }
                        }
                    }
                    
                }
                arrLadybugs[indexLadybugs] = 0; // понеже е излетяла, изходната позиция е опразнена
                input = Console.ReadLine();  // четем новата дестинация
            }
            Console.WriteLine(string.Join(" ", arrLadybugs));  // печатаме новото състояние на полето
        }
    }
}
