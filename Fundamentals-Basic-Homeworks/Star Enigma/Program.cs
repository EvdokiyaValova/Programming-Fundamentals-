using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"([S,s,T,t,A,a,R,r])";

            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(@"([S,s,T,t,A,a,R,r])");
                MatchCollection matches = regex.Matches(text);
                int decrypt = matches.Count;

                string newMessage = string.Empty;

                for (int j = 0; j < text.Length; j++)
                {
                    char simbol = (char)(text[j] - decrypt);
                    newMessage += simbol;
                }

                //  Console.WriteLine(newMessage);

                Regex regex1 = new Regex(@"[^@\-!:>]*@([A-Za-z]+)[^@\-!:>]*:([\d]+)[^@\-!:>]*!(A|D)![^@\-!:>]*->([\d]+)[^@\-!:>]*");
                Match match1 = regex1.Match(newMessage);

                // "Attacked planets: {attackedPlanetsCount}"
                // "-> {planetName}"
                //"Destroyed planets: {destroyedPlanetsCount}"
                //"-> {planetName}"


                string planet = match1.Groups[1].Value;
                string population = match1.Groups[2].Value;
                string attackType = match1.Groups[3].Value;
                string soldierCount = match1.Groups[4].Value;

                if (attackType == "A")
                {
                    attackedPlanet.Add(planet);
                }
                else if (attackType == "D")
                {
                    destroyedPlanet.Add(planet);
                }
            }
            
            attackedPlanet = attackedPlanet.OrderBy(p => p).ToList();
            destroyedPlanet = destroyedPlanet.OrderBy(p => p).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");

            for (int i = 0; i < attackedPlanet.Count; i++)
            {
                Console.WriteLine($"-> {attackedPlanet[i]}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");

            for (int i = 0; i < destroyedPlanet.Count; i++)
            {
                Console.WriteLine($"-> {destroyedPlanet[i]}");
            }
        }
    }
}
