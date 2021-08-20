using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            int counterNumber = 0;
            bool passLenght = false;
            bool passSimbolls = false;

            PasswordValidator(inputPassword, ref counterNumber, ref passLenght, ref passSimbolls);
        }

        private static void PasswordValidator(string inputPassword, ref int counterNumber, ref bool passLenght, ref bool passSimbolls)
        {
            for (int i = 0; i < inputPassword.Length; i++)
            {

                if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
                {
                    passLenght = true;

                    if ((inputPassword[i] >= 48 && inputPassword[i] <= 57)
                        || (inputPassword[i] >= 65 && inputPassword[i] <= 90)
                        || (inputPassword[i] >= 97 && inputPassword[i] <= 122))
                    {
                        passSimbolls = true;

                        if (inputPassword[i] >= 48 && inputPassword[i] <= 57)
                        {
                            counterNumber++;
                        }
                    }
                    else
                    {
                        passSimbolls = false;
                        Console.WriteLine("Password must consist only of letters and digits");
                        break;
                    }

                }
                else
                {
                    passLenght = false;
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    break;
                }
            }
            if (counterNumber >= 2 && passLenght == true && passSimbolls == true)
            {
                Console.WriteLine("Password is valid");
            }
            else if (counterNumber < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
