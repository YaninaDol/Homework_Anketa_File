using System;
using System.IO;
using System.Text;

namespace Homework_Anketa_File
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Anketa one = new Anketa("Ivanov", "Ivan", "Ivanovich", 1, 4, 1982);
            Anketa two = new Anketa("Andreev", "Andrey","Andreevich", 25, 5, 1985);
            Anketa three = new Anketa("Danilova", "Olga", "Alexandrovna", 5, 10, 1980);
            Anketa four = new Anketa("Ustimenko", "Andrey", "Borisovich", 20, 3, 1965);
            Anketa five = new Anketa("Ovcharenko", "Ivan", "Andreevich", 12, 12, 1995);
            Anketa six = new Anketa("Sokolova", "Ludmila", "Igorevna", 28, 8, 1988);
            Anketa seven = new Anketa("Kovalenko", "Nikita", "Pavlovich", 2, 6, 2000);
            Anketa eight = new Anketa("Ergan", "Kristina", "Olegovna", 25, 4, 1970);
            Anketa nine = new Anketa("Reznichenko", "Andrey", "Andreevich", 22, 5, 1985);
            Anketa ten = new Anketa("Samoilova", "Oksana", "Marchenko", 25, 10, 1975);

            Anketa[] array = new Anketa[10] { one, two, three, four, five, six, seven, eight, nine, ten };

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("text.txt",$"{array[i]}");
            }
            string info = File.ReadAllText("text.txt");
           string str= info.Replace(".", " ");
            string str2 = str.Replace("\n", " ");
            string[] res=str2.Split (" ");
            
            Anketa[] array2 = new Anketa[10];

            int n = 0;

            for (int i=0;i<10; i++)
            {
                string L_name = res[n];
                string name = res[n + 1];
                string f_name = res[n + 2];
                int year = Convert.ToInt32(res[n + 5]);
                int month = Convert.ToInt32(res[n + 4]);
                int day= Convert.ToInt32(res[n + 3]);

                Anketa exampl = new Anketa(L_name,name,f_name, day,month,year);
                array2[i] = exampl;
                n+=6;
            }
            
            
            DateTime now = DateTime.Now;
           
            int max=0;
            int max_pos = 0;

        
            for (int i = 0; i < 10; i++)
            {
                if ((now.Year - array2[i].Birthday.Year) > max)
                {
                    max = (now.Year - array2[i].Birthday.Year);
                    max_pos = i;
                }

            }
            int min = max;
            int min_pos = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((now.Year - array2[i].Birthday.Year) < min)
                {
                    min = (now.Year - array2[i].Birthday.Year);
                    min_pos = i;
                }
            }

            File.WriteAllText("result.txt", $"Самый старший пользователь :  {array2[max_pos]} \nСамый младший пользователь: {array2[min_pos]} ");
            


        }
    }
}
