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
            bool flag;
            do
            {
                flag = DisplayMenu();
            } while (flag);
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
            if (check) // B
            {
                foreach (char x in num) // C
                {
                    if (x != '0' && x != '1') // D
                    {
                        check = false; // E
                        break;
                    }
                    else
                    {
                        check = true; // F
                    } // G
                }
            } // H
            
            return check; // I
        }

        static bool CheckOctal(string num)
        {
            int mod, temp;
            bool check = checkValidate(num, int.MinValue, int.MaxValue); // A'1
            if (check) // B
            {
                // C
                temp = Convert.ToInt32(num);
                while (temp > 0) // D
                {
                    // E
                    mod = temp % 10;
                    temp /= 10;
                    if (mod > 7) // F
                    {
                        // G
                        check = false;
                        break;
                    }
                    else
                    {
                        // H
                        check = true;
                    } // I
                }
            }
            // J
            return check; // K
        }

        static int ConvertBinary(string num)
        {
            int count = 0;
            int sum = 0;
            for (int i = num.Length - 1; i >= 0; i--) // A
            {
                // B
                sum += (int)(char.GetNumericValue(num[i]) * Math.Pow(2, count));
                count++;
            }
            // C
            return sum;
        }

        static int ConvertOctal(int x)
        {
            int mod;
            int count = 0;
            int sum = 0;
            while (x > 0) // A
            {
                // B
                mod = x % 10;
                x /= 10;
                sum += (int)(mod * Math.Pow(8, count));
                count++;
            }
            // C
            return sum;
        }

        static bool CheckHexadecimal(string input)
        {
            bool check = true;
            foreach (char x in input) // A
            {
                if (x < '0' || ('9' < x && x < 'A') || ('F' < x && x < 'a') || x > 'f') // B
                {
                    check = false; // C
                    break;
                } // E
            } 
            // F
            return check;
        }

        static int ConvertHexadecimal(String Hexa)
        {
            Hexa = Hexa.ToUpper(); // A
            int sum = 0;
            int count = 0;
            Char[] temp = Hexa.ToCharArray(); // B
            for (int i = temp.Length - 1; i >= 0; i--) // C
            {
                if (Char.IsDigit(temp[i])) // D
                {
                    // E
                    sum += (int)(Char.GetNumericValue(temp[i]) * Math.Pow(16, count));
                    count++;
                }
                else
                {
                    // F
                    int num = temp[i] - 'A' + 10;
                    sum += (int)(num * Math.Pow(16, count));
                    count++;
                } // G
            }
            // H
            return sum;
        }

        static bool DisplayMenu()
        {
            string num;
            string Hexa;
            string choose;
            // A
            Console.WriteLine("======================================================");
            Console.WriteLine("1. Convert binary number to decimal number.");
            Console.WriteLine("2. Convert octal number to decimal number.");
            Console.WriteLine("3. Convert hexadecimal number to decimal number.");
            Console.WriteLine("4. Exit.");
            Console.WriteLine("======================================================");
            Console.Write("Please choose number (1 - 4): ");
            // B
            choose = Console.ReadLine();
            bool check = checkValidate(choose, 1, 4); // C'
            if (check) // D
            {
                switch (Convert.ToInt32(choose)) // E
                {
                    case 1: // F
                        // G
                        Console.Write("enter binary number: ");
                        num = Console.ReadLine();
                        check = checkBinary(num); // H
                        if (check) // I
                        {
                            // J
                            Console.WriteLine($"Binary {num} to decimal {ConvertBinary(num)}");
                        }
                        break;
                    case 2: // K
                        // L
                        Console.Write("enter octal number: ");
                        num = Console.ReadLine();
                        check = CheckOctal(num); // M
                        if (check) // N
                        {
                            // O
                            Console.WriteLine($"Octal {num} to decimal {ConvertOctal(Convert.ToInt32(num))}");
                        }
                        break;
                    case 3: // P
                        // Q
                        Console.Write("enter Hexadecimal number: ");
                        Hexa = Console.ReadLine();
                        check = CheckHexadecimal(Hexa); // R
                        if (check) // S
                        {
                            // T
                            Console.WriteLine($"Hexadecimal {Hexa} to decimal {ConvertHexadecimal(Hexa)}");
                        }
                        break;
                    case 4: // U
                        // V
                        return false;
                } // W
            } // X
            return true;
        }
    }
}
