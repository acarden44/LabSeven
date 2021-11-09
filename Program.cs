using System;
using System.Text.RegularExpressions;

namespace LabSeven
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = FirstName(GetUserInput("Hello beautiful human! Please tell me your name!"));
            Console.WriteLine($"Hello {name}");

            string email = EmailAdd(GetUserInput("What is your email address?"));
            Console.WriteLine($"Thank you {name} your email address is:{email}");

            string phone = PhoneNum(GetUserInput("What is your Phone Number"));
            Console.WriteLine($"Good work {name} your Phone number is: {phone}");
        }

        public static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }

        public static string FirstName(string name)
        {
            if ((!Regex.IsMatch(name, @"^[a-zA-z]$")) && name.Length <= 30 && char.IsUpper(name[0]))
            {
                return name;
            }
            else
            {
                return FirstName(GetUserInput("Please enter a name that contains only letters and is less than 30 characters & please capitalize your name"));
            }
        }
        public static string EmailAdd(string email)
        {
            if (Regex.IsMatch(email, @"^[A-z0-9]{1,30}@[A-z]{5,10}.[A-z]{2,3}"))
            {
                return email;
            }
            else
            {
                return EmailAdd(GetUserInput("Please enter a valid email address"));
            }
        }
        public static string PhoneNum(string phone)
        {
            if (Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                return phone;
            }
            else

            {
                return PhoneNum(GetUserInput("Please enter a valid phone number - including dashes."));
            }

        }


    }

}