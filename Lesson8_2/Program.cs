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


            string name = "Yarin";
            //שינוי מחרוזת לאותיות גדולות
            Console.WriteLine(name.ToUpper());
            //שינוי מחרוזת לאותיות קטנות
            Console.WriteLine(name.ToLower());
            //אורך המחרוזת 
            Console.WriteLine(name.Length);


            while (true)
            {
                Console.WriteLine("enter name");
                //אורך של המחרוזת 
                // Console.WriteLine(name.Length);
                //char firstChar = name[0];
                //Console.WriteLine(firstChar);
                //char seconsChar = name[1];
                //Console.WriteLine(seconsChar);
                //char lastChar = name[name.Length - 2];
                //Console.WriteLine(lastChar);
                //לקלוט מהשתמש את השם שלו ואת השם משפחה 
                //אם בשם שלו קיים אות y ידפיס yes 
                int flag = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == 'y')
                    {
                        flag = 1;
                        Console.WriteLine("yes");
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine("no");

            }
    }
}
