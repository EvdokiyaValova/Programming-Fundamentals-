using System;

namespace Password_Validator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool lengthPassword = LengthPassword(inputPassword);
            bool typeElements = TypeElements(inputPassword);
            bool isTwoDigits = IsTwoDigits(inputPassword);

            if (lengthPassword && typeElements && isTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsTwoDigits(string inputPassword)
        {
            bool isTwoDigits = false;

            int counterDigits = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if ((char)inputPassword[i] >= 48 && (char)inputPassword[i] <= 57)
                {
                    counterDigits++;
                }
            }

            if (counterDigits >= 2)
            {
                isTwoDigits = true;
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            
        }

        private static bool TypeElements(string inputPassword)
        {
            bool typeCharacters = false;

            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (((char)inputPassword[i] >= 48 && (char)inputPassword[i] <= 57)
                    || ((char)inputPassword[i] >= 65 && (char)inputPassword[i] <= 90)
                    || ((char)inputPassword[i] >= 97 && (char)inputPassword[i] <= 122))
                {
                    typeCharacters = true;
                }
                else
                {
                    typeCharacters = false;
                    break;
                }                
            }

            if (typeCharacters)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }

        private static bool LengthPassword(string inputPassword)
        {
            bool lengthPassword = false;
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                lengthPassword = true;
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
           
        }
    }
}
