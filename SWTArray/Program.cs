using System;

namespace SWTArray
{
    public class Program
    {
        public static string PathOutput { get; set; } = "";
        public static bool checkValidate(string input)
        {
            bool check = true;

            try
            {
                PathOutput += "A";
                int num = Convert.ToInt32(input); // A
            }
            catch (OverflowException) // B
            {
                PathOutput += "BC";
                check = false; // C
            }
            catch (FormatException) // D
            {
                PathOutput += "DE";
                check = false; // E
            }

            PathOutput += "F";
            return check; // F
        }

        public static void add(ref int[] a, string input)
        {
            // A' 
            bool isValid = checkValidate(input);
            PathOutput = "A'";

            PathOutput += "B";
            if (isValid) // B
            {
                PathOutput += "C";
                // C
                int[] b = new int[a.Length + 1];
                b[a.Length] = Convert.ToInt32(input);
                Array.Copy(a, b, a.Length);
                a = b;
            } // D
            PathOutput += "D";
        }

        public static int search(int[] a, string x)
        {
            // A'
            bool isValid = checkValidate(x);
            int result = -1;

            PathOutput =  "A'";

            PathOutput += "B";
            if (isValid) // B
            {
                PathOutput += "C";
                for (int i = 0; i < a.Length; i++) // C
                {
                    PathOutput += "D";
                    if (a[i] == Convert.ToInt32(x)) // D
                    {
                        PathOutput += "E";
                        // E
                        result = i;
                        break;
                    } // F
                    PathOutput += "F";
                } // G
                PathOutput += "G";
            } // H
            PathOutput += "H";
            PathOutput += "I";
            return result; // I
        }

        public static void removea(ref int[] a, string x)
        {
            // A'
            bool isValid = checkValidate(x);
            PathOutput = "A'";

            PathOutput += "B";
            if (isValid) // B
            {
                int count = a.Length;

                PathOutput += "C";
                for (int i = 0; i < count; i++) // C
                {
                    PathOutput += "D";
                    if (a[i] == Convert.ToInt32(x)) // D
                    {
                        PathOutput += "E";
                        for (int k = i; k < count - 1; k++) // E
                        {
                            PathOutput += "F";
                            // F
                            a[k] = a[k + 1];
                        } // G
                        PathOutput += "G";
                        count--;
                        break;
                    } // H
                    PathOutput += "H";
                } // I

                PathOutput += "I";
                PathOutput += "J";
                if (count != a.Length) // J
                {
                    PathOutput += "K";
                    // K
                    int[] b = new int[count];
                    Array.Copy(a, b, count);
                    a = b;
                } // L
                PathOutput += "L";
            } // M
            PathOutput += "M";
        }

        public static void removeall(ref int[] a, string x)
        {
            bool isValid = checkValidate(x); // A'
            PathOutput = "A'";
            PathOutput += "B";
            if (isValid) // B
            {
                int count = a.Length;

                PathOutput += "C";
                for (int i = 0; i < count; i++) // C
                {
                    PathOutput += "D";
                    if (a[i] == Convert.ToInt32(x)) // D
                    {
                        PathOutput += "E";
                        for (int k = i; k < count - 1; k++) // E
                        {
                            PathOutput += "F";
                            // F
                            a[k] = a[k + 1];
                        } // G
                        PathOutput += "G";
                        count--;
                        i--;
                    } // H
                    PathOutput += "H";
                } // I
                PathOutput += "I";
                PathOutput += "J";
                if (count != a.Length) // J
                {
                    PathOutput += "K";
                    // K
                    int[] b = new int[count];
                    Array.Copy(a, b, count);
                    a = b;
                } // L
                PathOutput += "L";
            } // M
            PathOutput += "M";
        }

        static void display(int[] a)
        {
            Console.Write("Array you want display is: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        public static void selectionsortup(int[] a)
        {
            int i, j, temp;
            PathOutput = "A";
            for (i = 0; i < a.Length; i++) // A
            {
                PathOutput += "B";
                for (j = i + 1; j < a.Length; j++) // B
                {
                    PathOutput += "C";
                    if (a[i] > a[j]) // C
                    {
                        PathOutput += "D";
                        // D
                        temp = a[i]; 
                        a[i] = a[j];
                        a[j] = temp;
                    } // E
                    PathOutput += "E";
                } // F
                PathOutput += "F";
            } // G
            PathOutput += "G";
        }

        public static void selectionsortdown(int[] a)
        {
            int i, j, temp;
            PathOutput = "A";
            for (i = 0; i < a.Length; i++) // A
            {
                PathOutput += "B";
                for (j = i + 1; j < a.Length; j++) // B
                {
                    PathOutput += "C";
                    if (a[i] < a[j]) // C
                    {
                        PathOutput += "D";
                        // D
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    } // E
                    PathOutput += "E";
                } // F
                PathOutput += "F";
            } // G
            PathOutput += "G";
        }

        static void Main(string[] args)
        {
            int[] a = new int[0];
            while (true)
            {
                Console.Write("1: Add a value.\n");
                Console.Write("2: Search a value.\n");
                Console.Write("3: Remove the first existence of a value.\n");
                Console.Write("4: Remove all existences of a value.\n");
                Console.Write("5: Print out the array.\n");
                Console.Write("6: Sort the array in ascending order(positions of elements a preserved).\n");
                Console.Write("7: Sort the array in descending order(positions of elements are preserved).\n");
                Console.Write("Others-Quit.\n");
                Console.Write("You want choose?.\n");

                var input = Console.ReadLine();

                if (checkValidate(input))
                {
                    switch (Convert.ToInt32(input))
                    {
                        case 1:
                            Console.Write("Enter number: ");
                            input = Console.ReadLine();

                            add(ref a, input);
                            break;
                        case 2:
                            Console.Write("Enter number: ");
                            input = Console.ReadLine();

                            search(a, input);
                            break;
                        case 3:
                            Console.Write("Enter number: ");
                            input = Console.ReadLine();

                            removea(ref a, input);
                            break;
                        case 4:
                            Console.Write("Enter number: ");
                            input = Console.ReadLine();

                            removeall(ref a, input);
                            break;
                        case 5:
                            display(a);
                            break;
                        case 6:
                            selectionsortup(a);
                            break;
                        case 7:
                            selectionsortdown(a);
                            break;
                        default:
                            return;
                    }
                }
            }
        }
    }
}
