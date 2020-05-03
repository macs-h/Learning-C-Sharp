using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            bool containsUpper = false;
            bool containsLower = false;
            bool containsDigits = false;
            bool containsSpecial = false;
            int strength = 0;

            Console.WriteLine("Enter a password to test it's strength:");
            string pw = Console.ReadLine();

            if (pw.Length >= 8)
            {
                strength++;
            }

            for (int i = 0; i < pw.Length; i++)
            {
                if (Char.IsUpper(pw[i]))
                {
                    containsUpper = true;
                }
                if (Char.IsLower(pw[i]))
                {
                    containsLower = true;
                }
                if (Char.IsDigit(pw[i]))
                {
                    containsDigits = true;
                }
                if (Char.IsSymbol(pw[i]) || Char.IsPunctuation(pw[i]))
                {
                    containsSpecial = true;
                }
            }

            if (containsUpper) strength++;
            if (containsLower) strength++;
            if (containsDigits) strength++;
            if (containsSpecial) strength++;

            if (pw == "1234") strength = 0;

            string msg = "Your password is ";
            switch (strength)
            {
                case 4:
                case 5:
                    msg += "extremely strong!";
                    break;
                case 3:
                    msg += "strong";
                    break;
                case 2:
                    msg += "medium";
                    break;
                case 1:
                    msg += "weak";
                    break;
                default:
                    msg = "Your password doesn't meet any of the standards";
                    break;
            }

            Console.WriteLine(msg);
        }
    }
}
