using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConvertion
{
    class Program
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
                            check = checkBinary(num); // H
                            if (check) // I
                            {
                                // J
                                Console.WriteLine($"Binary {num} to decimal {ConvertBinary(num)}");
                            }
                            break;
                        case 2:
                            Console.Write("enter octal number: ");
                            num = Console.ReadLine();
                            check = CheckOctal(num);
                            if (check)
                            {
                                Console.WriteLine($"Octal {num} to decimal {ConvertOctal(Convert.ToInt32(num))}");
                            }
                            break;
                        case 3:
                            Console.Write("enter Hexadecimal number: ");
                            Hexa = Console.ReadLine();
                            check = CheckHexadecimal(Hexa); 
                            if (check)
                            {
                                Console.WriteLine($"Hexadecimal {Hexa} to decimal {ConvertHexadecimal(Hexa)}");
                            }
                            break;
                        case 4:
                        default:
                            return;
                    }
                }
            } while (true);
        }

        static bool checkValidate(string input, int min, int max)
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
            return check; // L
        }

        static bool checkBinary(string num)
        {
            bool check = checkValidate(num, int.MinValue, int.MaxValue); // A'
            PathOutput = "A'";

            PathOutput += "B";
            if (check) // B
            {
                PathOutput += "C";
                foreach (char x in num) // C
                {
                    PathOutput += "D";
                    if (x != '0' && x != '1') // D
                    {
                        PathOutput += "E";
                        check = false; // E
                        break;
                    }
                    else
                    {
                        PathOutput += "F";
                        check = true; // F
                    } // G
                    PathOutput += "G";
                } // H
                PathOutput += "H";
            } // I

            PathOutput += "IJ";
            return check; // J
        }

        static bool CheckOctal(string num)
        {
            int mod, temp;
            bool check = checkValidate(num, int.MinValue, int.MaxValue); // A'
            PathOutput = "A'";
            PathOutput += "B";
            if (check) // B
            {
                PathOutput += "C";
                // C
                temp = Convert.ToInt32(num);
                PathOutput += "D";
                while (temp > 0) // D
                {
                    PathOutput += "E";
                    // E
                    mod = temp % 10;
                    temp /= 10;
                    PathOutput += "F";
                    if (mod > 7) // F
                    {
                        PathOutput += "G";
                        // G
                        check = false;
                        break;
                    }
                    else
                    {
                        PathOutput += "H";
                        // H
                        check = true;
                    } // I
                    PathOutput += "I";
                } // J
                PathOutput += "J";
            } // K
            PathOutput += "KL";
            return check; // L
        }

        static bool CheckHexadecimal(string input)
        {
            bool check = true;
            PathOutput += "A";
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

        static int ConvertBinary(string num)
        {
            int count = 0;
            int sum = 0;
            PathOutput = "A";
            for (int i = num.Length - 1; i >= 0; i--) // A
            {
                PathOutput += "B";
                // B
                sum += (int)(char.GetNumericValue(num[i]) * Math.Pow(2, count));
                count++;
            }
            PathOutput += "C";
            // C
            return sum;
        }

        static int ConvertOctal(int x)
        {
            int mod;
            int count = 0;
            int sum = 0;
            PathOutput = "A";
            while (x > 0) // A
            {
                PathOutput += "B";

                // B
                mod = x % 10;
                x /= 10;
                sum += (int)(mod * Math.Pow(8, count));
                count++;
            }
            // C
            PathOutput += "C";
            return sum;
        }

        

        static int ConvertHexadecimal(String Hexa)
        {
            PathOutput += "A";
            Hexa = Hexa.ToUpper(); // A
            int sum = 0;
            int count = 0;
            PathOutput += "B";
            char[] temp = Hexa.ToCharArray(); // B

            PathOutput += "C";
            for (int i = temp.Length - 1; i >= 0; i--) // C
            {
                PathOutput += "D";
                if (char.IsDigit(temp[i])) // D
                {
                    PathOutput += "E";
                    // E
                    sum += (int)(Char.GetNumericValue(temp[i]) * Math.Pow(16, count));
                    count++;
                }
                else
                {
                    PathOutput += "F";
                    // F
                    int num = temp[i] - 'A' + 10;
                    sum += (int)(num * Math.Pow(16, count));
                    count++;
                } // G
                PathOutput += "G";
            }
            PathOutput += "H";
            // H
            return sum;
        }
    }
}
