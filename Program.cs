using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Program
    {
        public enum Gender
        {
            Female,
            Male
        }

        static void Main(string[] args)
        {
            int day = 21, month = 11, year = 1982;
            string male = "M";
            string female = "F";

            string birthdate = string.Format("{0}/{1}/{2}", year, month, day);

            DateTime birthDate = Convert.ToDateTime(birthdate);

            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            Gender? MyGender = null;

            Console.WriteLine("Input your gender:");
            string gender = Console.ReadLine();

            int forMale = string.Compare(gender, male, true);
            int forFemale = string.Compare(gender, female, true);

            if (forMale == 0)
            {
                MyGender = Gender.Male;
            }
            else if (forFemale == 0)
            {
                MyGender = Gender.Female;
            }
            else
            {
                MyGender = null;
            }

            if (!String.IsNullOrEmpty(MyGender.ToString()))
            {
                if (forMale == 0)
                {
                    if (age >= 65)
                    {
                        Console.WriteLine("\nRetired\n");
                    }
                    else
                    {
                        Console.WriteLine("\nWill retire at 65\n");
                    }
                }
                else if (forFemale == 0)
                {
                    if (age >= 63)
                    {
                        Console.WriteLine("\nRetired\n");
                    }
                    else
                    {
                        Console.WriteLine("\nWill retire at 63\n");
                    }
                }
            }


            Console.WriteLine("My birthday is: {0}", birthDate);
            Console.WriteLine("My age is: {0}", age);
            Console.WriteLine("My gender is: {0}", MyGender);

            Console.ReadKey();
        }
    }
}
