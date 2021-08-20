using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNight = int.Parse(Console.ReadLine());
            string typeRoom = "";
            double priceNightStudio = 0;
            double priceNightApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    
                            priceNightStudio = countNight * 50.00;
                            if (countNight > 14)
                            {
                                priceNightStudio = priceNightStudio * 0.70;
                            }
                            else if (countNight > 7)
                            {
                                priceNightStudio = priceNightStudio * 0.95;
                            }
                                                                         
                    
                            priceNightApartment = countNight * 65.00;
                    if (countNight > 14)
                    {
                        priceNightApartment = priceNightApartment * 0.90;
                    }
                    break;
            
                    
                case "June":
                case "September":
                    
                            priceNightStudio = countNight * 75.20;
                            if (countNight > 14)
                            {
                                priceNightStudio = priceNightStudio * 0.80;
                            }
                                                    
                    
                            priceNightApartment = countNight * 68.70;
                            if (countNight > 14)
                            {
                                priceNightApartment = priceNightApartment * 0.90;
                            }
                    break;
                    
                case "July":
                case "August":
                    
                            priceNightStudio = countNight * 76.00;
                            
                        
                    
                            priceNightApartment = countNight * 77.00;
                            if (countNight > 14)
                            {
                                priceNightApartment = priceNightApartment * 0.90;
                            }
                        
                    break;
            }

            Console.WriteLine($"Apartment: {priceNightApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceNightStudio:f2} lv.");

        }
    }
}
