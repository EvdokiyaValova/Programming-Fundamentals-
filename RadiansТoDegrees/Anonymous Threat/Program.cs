using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textOfData = Console.ReadLine().Split().ToList();
            string inputComands = Console.ReadLine();
            
            while (inputComands != "3:1")
            {
                List<string> comands = inputComands.Split().ToList();
                int startIndex = int.Parse(comands[1]);
                int finalIndex = int.Parse(comands[2]);

                if (comands[0] == "merge")
                {                    
                    string curenttext = "";

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex >= textOfData.Count)
                    {
                        startIndex = textOfData.Count - 1;
                    }

                    for (int i = startIndex; i <= finalIndex; i++)
                    {
                        if (i < 0 || i >= textOfData.Count)
                        {
                            continue;
                        }
                        else
                        {
                            curenttext += textOfData[i];
                            textOfData[i] = "";                            
                        }
                    }

                    for (int i = 0; i < textOfData.Count; i++)
                    {                        
                        if (i == startIndex)
                        {
                            textOfData.Insert(startIndex, curenttext);
                        }                        
                    }

                    textOfData.RemoveAll(x => x == "");
                    
                }
                else if (comands[0] == "divide")
                {
  
                    int numberNewString = finalIndex;

                    string curentText = textOfData[startIndex];
                    textOfData.RemoveAt(startIndex);
                    int lenghtParts = curentText.Length / numberNewString;
                    List<string> parts = new List<string>();

                    for (int i = 0; i < numberNewString - 1; i++)
                    {
                        string currentParts = curentText.Substring(lenghtParts * i, lenghtParts);
                        parts.Add(currentParts);
                    }

                    string lastParts = curentText.Substring(lenghtParts * (numberNewString - 1));
                    parts.Add(lastParts);
                    textOfData.InsertRange(startIndex, parts);                 
                    
                }

                inputComands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" " , textOfData));
        }
    }
}
