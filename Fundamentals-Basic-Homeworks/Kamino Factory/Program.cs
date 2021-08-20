using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int[] bestDNA = new int[lengthDNA];
            int numberSequences = 0;
            int bestcount = 0;
            int startIndexDNA = lengthDNA;

            while (input != "Clone them!")
            {
                int[] currentDNASequences = input
                    .Split("!" , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                            
                int currentDNACounter = 1;
                int currentIndex = currentDNASequences.Length;
                int counterDNASum = currentDNASequences[currentDNASequences.Length -1];
                int maxDNA = 0;

                for (int i = 0; i < currentDNASequences.Length -1; i++)
                {
                    counterDNASum += currentDNASequences[i];

                    if (currentDNASequences[i] == 0)
                    {
                        currentDNACounter = 1;
                        continue;
                    }
                    else if (currentDNASequences[i] == 1 && currentDNASequences[i] == currentDNASequences[i+1])
                    {
                        currentDNACounter ++;

                        if (currentIndex > i)
                        {
                            currentIndex = i;
                        }
                    }

                    if (currentDNACounter > maxDNA)
                    {
                            maxDNA = currentDNACounter;
                            currentDNACounter = 1;
                    }                        
                   
                }

                if (maxDNA > bestcount)
                {
                    bestSequenceIndex = numberSequences;
                    bestSequenceSum = counterDNASum;
                    bestDNA = currentDNASequences;
                    bestcount = maxDNA;
                    startIndexDNA = currentIndex;
                }
                else if (maxDNA == bestcount && currentIndex < startIndexDNA 
                    || maxDNA == bestcount && currentIndex == startIndexDNA && counterDNASum > bestSequenceSum)
                {
                    bestSequenceIndex = numberSequences;
                    bestSequenceSum = counterDNASum;
                    bestDNA = currentDNASequences;
                    bestcount = maxDNA;
                    startIndexDNA = currentIndex;
                }

                numberSequences++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex +1} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
