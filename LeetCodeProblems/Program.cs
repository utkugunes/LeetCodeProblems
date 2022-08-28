namespace RomanToInteger
{
    public class Program
    {
        public static int RomanToInt(string s)
        {
            string romanNumb = s;
            int number = 0;

            for (int i = romanNumb.Length - 1; i >= 0; i--)
            {
                if (romanNumb[i] == 'I')
                {
                    number += 1;

                }

                if (romanNumb[i] == 'V')
                {
                    number += 5;
                    if (i > 0 && romanNumb[i - 1] == 'I') { number -= 1; i--; }

                }

                if (romanNumb[i] == 'X')
                {
                    number += 10;
                    if (i > 0 && romanNumb[i - 1] == 'I') { number -= 1; i--; }

                }

                if (romanNumb[i] == 'L')
                {
                    number += 50;
                    if (i > 0 && romanNumb[i - 1] == 'X') { number -= 10; i--; }

                }

                if (romanNumb[i] == 'C')
                {
                    number += 100;
                    if (i > 0 && romanNumb[i - 1] == 'X') { number -= 10; i--; }

                }

                if (romanNumb[i] == 'D')

                {
                    number += 500;
                    if (i > 0 && romanNumb[i - 1] == 'C') { number -= 100; i--; }

                }

                if (romanNumb[i] == 'M')
                {
                    number += 1000;
                    if (i > 0 && romanNumb[i - 1] == 'C') { number -= 100; i--; }

                }

            }
            return number;

        }

        public static int RomanToIntDict(string s)
        {
            int number = 0;

            var romanNumb = new Dictionary<char, int>();

            romanNumb.Add('I', 1);
            romanNumb.Add('V', 5);
            romanNumb.Add('X', 10);
            romanNumb.Add('L', 50);
            romanNumb.Add('C', 100);
            romanNumb.Add('D', 500);
            romanNumb.Add('M', 1000);

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanNumb[s[i]] < romanNumb[s[i + 1]])
                {
                    number -= romanNumb[s[i]];
                }
                else
                {
                    number += romanNumb[s[i]];

                }


            }
            return number;
        }

        static void Main()
        {
            string _romanNumb = "MLIX";

            int result = RomanToIntDict(_romanNumb);
            Console.WriteLine($"{result}");
        }
    }
}