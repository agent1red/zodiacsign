using System;

namespace zodiacsign
{
    class Program
    {
        private static string temp;
        private static int month = 0;
        private static bool result = false;
        private static int dayEntered, ageEntered, monthEntered;
        private static int age;
        private static int day;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello We will see what your zodiac sign is lets ask a few questions \n");

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            GetAge();
            GetBirthDay();
            GetMonth();

            Console.WriteLine($" Ok {name}, Your birth Month/Day/Year are : {month}/{day}/{GetApproximateBirthYear(age, month)} " +
                $"\n and your zodiac sign is {FindZodiac(month, day)}");
        }

        // Function returns Zodiac sign based on the month and day
        public static string FindZodiac(int month, int day)
        {
            string[] zodiac = new string[] {
                "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"
            };

            string output = "";
            switch (month)
            {
                case 1: // jan
                    if (day >= 1 && day <= 19)
                    {
                        output = zodiac[9];
                    }
                    if (day >= 20 && day <= 31)
                    {
                        output = zodiac[10];
                    }
                    break;
                case 2: // feb
                    if (day >= 1 && day <= 18)
                    {
                        output = zodiac[10];
                    }
                    if (day >= 19 && day <= 28)
                    {
                        output = zodiac[11];
                    }
                    break;
                case 3: // mar
                    if (day >= 1 && day <= 20)
                    {
                        output = zodiac[11];
                    }
                    if (day >= 21 && day <= 31)
                    {
                        output = zodiac[0];
                    }
                    break;
                case 4: // apr 
                    if (day >= 1 && day <= 19)
                    {
                        output = zodiac[0];
                    }
                    if (day >= 20 && day <= 30)
                    {
                        output = zodiac[1];
                    }
                    break;
                case 5: // may 
                    if (day >= 1 && day <= 20)
                    {
                        output = zodiac[1];
                    }
                    if (day >= 21 && day <= 31)
                    {
                        output = zodiac[2];
                    }
                    break;
                case 6: // june 
                    if (day >= 1 && day <= 20)
                    {
                        output = zodiac[2];
                    }
                    if (day >= 21 && day <= 30)
                    {
                        output = zodiac[3];
                    }
                    break;
                case 7: // july 
                    if (day >= 1 && day <= 22)
                    {
                        output = zodiac[3];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        output = zodiac[4];
                    }
                    break;
                case 8: // aug 
                    if (day >= 1 && day <= 22)
                    {
                        output = zodiac[4];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        output = zodiac[5];
                    }
                    break;
                case 9: // sep 
                    if (day >= 1 && day <= 22)
                    {
                        output = zodiac[5];
                    }
                    if (day >= 23 && day <= 30)
                    {
                        output = zodiac[6];
                    }
                    break;
                case 10: // oct 
                    if (day >= 1 && day <= 22)
                    {
                        output = zodiac[6];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        output = zodiac[7];
                    }
                    break;
                case 11: // nov 
                    if (day >= 1 && day <= 21)
                    {
                        output = zodiac[7];
                    }
                    if (day >= 22 && day <= 30)
                    {
                        output = zodiac[8];
                    }
                    break;
                case 12: // dec 
                    if (day >= 1 && day <= 21)
                    {
                        output = zodiac[8];
                    }
                    if (day >= 22 && day <= 31)
                    {
                        output = zodiac[9];
                    }
                    break;
                default:
                    output = "No correct value";
                    break;
            }

            return output;
            
        }

        // Function returns month number
        public static int FindMonthNum(string value)
        {
            
            if (value.Contains("jan") || value == "1")
            {
                return 1;
            } 
            else if (value.Contains("feb") || value == "2")
            {
                return 2;
            }
            else if (value.Contains("mar") || value == "3")
            {
                return 3;
            }
            else if (value.Contains("apr") || value == "4")
            {
                return 4;
            }
            else if (value.Contains("may") || value == "5")
            {
                return 5;
            }
            else if (value.Contains("jun") || value == "6")
            {
                return 6;
            }
            else if (value.Contains("jul") || value == "7")
            {
                return 7;
            }
            else if (value.Contains("aug") || value == "8")
            {
                return 8;
            }
            else if (value.Contains("sep") || value == "9")
            {
                return 9;
            }
            else if (value.Contains("oct") || value == "10")
            {
                return 10;
            }
            else if (value.Contains("nov") || value == "11")
            {
                return 11;
            }
            else if (value.Contains("dec") || value == "12")
            {
                return 12;
            } 
            else
            {
                return 0;
            }

        }

        // Function to get and return age integer 
        public static int GetAge()
        {
            while (!result)
            {
                Console.WriteLine("What is your age?");
                temp = Console.ReadLine();
                result = int.TryParse(temp, out ageEntered);
                if (result == false)
                {
                    Console.WriteLine("Please enter a number for your age");
                }
                else
                {
                    age = ageEntered;
                    break;
                }
            }
            result = false;
            return age;
        }

        // Function to get and return birth day integer
        public static int GetBirthDay()
        {
            while (!result)
            {
                Console.WriteLine("What day of the month was your birth?");
                temp = Console.ReadLine();
                result = int.TryParse(temp, out dayEntered);
                if (!result || (result == true && dayEntered < 1 || dayEntered > 31))
                {
                    Console.WriteLine("Please enter a number for the day of birth (1 -31)");
                    result = false;
                }
                else
                {
                    day = dayEntered;
                    break;
                }
            }
            result = false;
            return day;
        }

        // Function to return the month integer
        public static int GetMonth()
        {
            while (!result)
            {
                Console.WriteLine("What month were you born in? Spell out the month or input a number from 1 - 12 ");
                temp = Console.ReadLine().ToLower();
                result = int.TryParse(temp, out monthEntered);

                if (!result)
                {
                    month = FindMonthNum(temp);
                    
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("If you entered a number for the month it must be 1 - 12.");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                    
                }
                else
                {
                    if (monthEntered < 1 || monthEntered > 12)
                    {
                        result = false;
                    }
                    else
                    {
                        month = monthEntered;
                    }
                    
                }

            }
            return month;
        }

        // Function to get your approximate birth year from age, month
        public static int GetApproximateBirthYear(int age, int month)
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            if (month > currentMonth)
            {
                currentYear -= 1;
            }
            int birthYear = currentYear - age;
            return birthYear;
        }
    }
}
