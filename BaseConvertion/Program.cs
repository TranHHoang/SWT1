using System;

namespace BaseConversion
{
    public class Program
    {
        public static string PathOutput { get; set; } = "";

        static void Main(string[] args)
        {
            Console.WriteLine("======================== Convert ======================");
            do
            {
                string num;
                string Hexa;
                string choose;

                Console.WriteLine("======================================================");
                Console.WriteLine("1. Convert binary number to decimal number.");
                Console.WriteLine("2. Convert octal number to decimal number.");
                Console.WriteLine("3. Convert hexadecimal number to decimal number.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("======================================================");
                Console.Write("Please choose number (1 - 4): ");

                choose = Console.ReadLine();
                bool check = checkValidate(choose, 1, 4);
                if (check)
                {
                    switch (Convert.ToInt32(choose))
                    {
                        case 1:
                            Console.Write("enter binary number: ");
                            num = Console.ReadLine();

                            Console.WriteLine($"Binary {num} to decimal {ConvertBinary(num)}");

                            break;
                        case 2:
                            Console.Write("enter octal number: ");
                            num = Console.ReadLine();

                            Console.WriteLine($"Octal {num} to decimal {ConvertOctal(num)}");

                            break;
                        case 3:
                            Console.Write("enter Hexadecimal number: ");
                            Hexa = Console.ReadLine();

                            Console.WriteLine($"Hexadecimal {Hexa} to decimal {ConvertHexadecimal(Hexa)}");

                            break;
                        case 4:
                        default:
                            return;
                    }
                }
            } while (true);
        }

        public static bool checkValidate(string input, int min, int max)
        {
            bool check = true;

            try
            {
                PathOutput += "A";
                int num = Convert.ToInt32(input); // A

                PathOutput += "B";
                if (num < min) // B
                {
                    PathOutput += "C";
                    check = false; // C
                }
                else
                {
                    PathOutput += "D";
                    if (num > max) // D
                    {
                        PathOutput += "E";
                        check = false; // E
                    } // F
                    PathOutput += "F";
                }// G
                PathOutput += "G";
            }
            catch (OverflowException) // H
            {
                PathOutput += "HI";
                check = false; // I
            }
            catch (FormatException) // J
            {
                PathOutput += "JK";
                check = false; // K
            }

            PathOutput += "L";
            Console.WriteLine(PathOutput);
            return check; // L
        }

        public static bool checkBinary(string num)
        {
            bool check = false;

            PathOutput = "A";
            foreach (char x in num) // A
            {
                PathOutput += "B";
                if (x != '0' && x != '1') // B
                {
                    PathOutput += "C";
                    check = false; // C
                    break;
                }
                else
                {
                    PathOutput += "D";
                    check = true; // D
                } // E
                PathOutput += "E";
            } // F
            PathOutput += "F";

            PathOutput += "G";
            return check; // G
        }

        public static bool CheckOctal(string input)
        {
            bool check = true;
            PathOutput = "A";
            foreach (char x in input) // A
            {
                PathOutput += "B";
                if (x < '0' || x > '7') // B
                {
                    PathOutput += "C";
                    check = false; // C
                    break;
                } // D
                PathOutput += "D";
            } // E
            PathOutput += "EF";
            return check; // F
        }

        public static bool CheckHexadecimal(string input)
        {
            bool check = true;
            PathOutput = "A";
            foreach (char x in input) // A
            {
                PathOutput += "B";
                if (x < '0' || ('9' < x && x < 'A') || ('F' < x && x < 'a') || x > 'f') // B
                {
                    PathOutput += "C";
                    check = false; // C
                    break;
                } // D
                PathOutput += "D";
            } // E
            PathOutput += "EF";
            return check; // F
        }

        public static int ConvertBinary(string num)
        {
            int count = 0;
            int sum = 0;
            bool check = checkBinary(num); // A'
            PathOutput = "A'";
            PathOutput += "B";
            if (check) // B
            {
                PathOutput += "C";
                for (int i = num.Length - 1; i >= 0; i--) // C
                {
                    // D
                    PathOutput += "D";
                    sum += (int)(char.GetNumericValue(num[i]) * Math.Pow(2, count));
                    count++;
                } // E
                PathOutput += "E";
            } // F
            PathOutput += "FG";
            return sum; // G
        }

        public static int ConvertOctal(string x)
        {
            int mod;
            int count = 0;
            int sum = 0;
            bool Check = CheckOctal(x); // A'
            PathOutput = "A'";
            PathOutput += "B";
            if (Check) // B
            {
                PathOutput += "C";
                // C
                int num = Convert.ToInt32(x);
                PathOutput += "D";
                while (num > 0) // D
                {
                    // E
                    PathOutput += "E";
                    mod = num % 10;
                    num /= 10;
                    sum += (int)(mod * Math.Pow(8, count));
                    count++;
                } // F
                PathOutput += "F";
            } // G

            PathOutput += "GH";
            return sum; // H
        }

        public static int ConvertHexadecimal(String Hexa)
        {
            int sum = 0;
            int count = 0;
            bool Check = CheckHexadecimal(Hexa); // A'
            PathOutput = "A'";
            PathOutput += "B";
            if (Check) // B
            {
                PathOutput += "C";
                Hexa = Hexa.ToUpper(); // C
                PathOutput += "D";
                char[] temp = Hexa.ToCharArray(); // D

                PathOutput += "E";
                for (int i = temp.Length - 1; i >= 0; i--) // E
                {
                    PathOutput += "F";
                    if (char.IsDigit(temp[i])) // F
                    {
                        PathOutput += "G";
                        // G
                        sum += (int)(char.GetNumericValue(temp[i]) * Math.Pow(16, count));
                        count++;
                    }
                    else
                    {
                        PathOutput += "H";
                        // H
                        int num = temp[i] - 'A' + 10;
                        sum += (int)(num * Math.Pow(16, count));
                        count++;
                    } // I
                    PathOutput += "I";
                } // J
                PathOutput += "J";
            } // K
            PathOutput += "KL";
            return sum; // L
        }
    }
}
