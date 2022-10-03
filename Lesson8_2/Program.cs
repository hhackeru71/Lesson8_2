using System;

namespace Lesson8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //לקלוט מהשתמש מדינה באנגלית
            //לעשות בדיקה האם אות a נמצאת בתוך המחרוזת
            //במידה והאות a יש לשנות את כל האותיות לאותיות קטנות ToLower
            //אחרת המחרוזת תשתנה לאותיות גדולות ע"י ToUpper
            //להדפיס את המחרוזת בסוף
            Console.WriteLine("enter a course");
            string course =  Console.ReadLine();
            course = course.ToLower();
            if(course.IndexOf('m')>=0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");


            //לקלוט מהשתמש קורס מחרוזת באנגלית 
            //לבדוק האם האות m קיימת במחרוזת 
            //במידה והאות קיימת להדפיס yes
            //אחרת להדפיס לא 
            


            //ChangeStringToUpperOrLowerL();
            //ChangeStringToUpperOrLowerI();
            //ChangeStringToUpperOrLowerA();
            string name = "ttb";
            //שינוי מחרוזת לאותיות גדולות
            //Console.WriteLine(name.ToUpper());
            //שינוי מחרוזת לאותיות קטנות
            //Console.WriteLine(name.ToLower());
            //אורך המחרוזת 
            //Console.WriteLine(name.Length);
            int index = name.IndexOf('b');
            Console.WriteLine(index);

            //while (true)
            //{
            //    Console.WriteLine("enter name");
            //    //אורך של המחרוזת 
            //    // Console.WriteLine(name.Length);
            //    //char firstChar = name[0];
            //    //Console.WriteLine(firstChar);
            //    //char seconsChar = name[1];
            //    //Console.WriteLine(seconsChar);
            //    //char lastChar = name[name.Length - 2];
            //    //Console.WriteLine(lastChar);
            //    //לקלוט מהשתמש את השם שלו ואת השם משפחה 
            //    //אם בשם שלו קיים אות y ידפיס yes 
            //    int flag = 0;
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (name[i] == 'y')
            //        {
            //            flag = 1;
            //            Console.WriteLine("yes");
            //            break;
            //        }
            //    }
            //    if (flag == 0)
            //        Console.WriteLine("no");

            //}


        }

        static void ChangeStringToUpperOrLowerL()
        {
            Console.WriteLine("enter a country name");
            string countryName = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < countryName.Length; i++)
            {
                if (countryName[i] == 'a')
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine(countryName.ToLower());
            }
            else
            {
                Console.WriteLine(countryName.ToUpper());

            }

        }

        static void ChangeStringToUpperOrLowerI()
        {
            System.Console.WriteLine("Please enter a country:");
            string country = Console.ReadLine();
            bool flag = true;

            foreach (char letter in country)
            {
                if (letter == 'a' || letter == 'A')
                {
                    country = country.ToLower();
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                country = country.ToUpper();
            }

            System.Console.WriteLine(country);

        }
    

    static void ChangeStringToUpperOrLowerA()
        {
            Console.WriteLine("please enter a country");

            string country = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < country.Length; i++)
            {
                char currentChar = country[i];
                if (currentChar == 'a')
                {
                    country = country.ToLower();
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                country = country.ToUpper();
            }
            Console.WriteLine(country);

        }
    }
}
