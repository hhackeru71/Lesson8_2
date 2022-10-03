using System;

namespace Lesson8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
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
                    if (name[i] == 'y' || name[i] == 'Y')
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
}
