using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Schwartznegger", "Arnold", 78);
            Console.WriteLine(human);
            Student student = new Student("Rios", "Leonardo", 19, "metalworking", "MSO-12", 87, 79);
            Console.WriteLine(student);
            Student student2 = new Student("Chaos", "Fernando", 18, "metalworking", "MSO-12", 15, 52);
            Console.WriteLine(student2);
            Teacher teacher = new Teacher("White", "Genry", 29, "metalworking", 5);
            Console.WriteLine(teacher);
            Graduate graduate = new Graduate("Martinos", "Salvador", 21, "metalworking", "MSO-13", 68, 83, "metallurgy");
            Console.WriteLine(graduate);
            Console.WriteLine();

            Human[] group = new Human[]
            {
                new Human("Schwartznegger", "Arnold", 78),
                new Student("Rios", "Leonardo", 19, "metalworking", "MSO-12", 87, 79),
                new Student("Chaos", "Fernando", 18, "metalworking", "MSO-12", 15, 52),
                new Teacher("White", "Genry", 29, "metalworking", 5),
                new Graduate("Martinos", "Salvador", 21, "metalworking", "MSO-13", 68, 83, "metallurgy")
            };
            Console.WriteLine($"\t\tGROUP:\n");
            for (int i = 0; i < group.Length; i++) Console.WriteLine(group.ElementAt(i));

          
            // Write file:
            string path = @"C:\Users\ypron\source\repos\InhertanceCS\Academy\fileGroup.txt";
            using (StreamWriter fileGr =new StreamWriter(path))
            {
                for (int i = 0; i < group.Length; i++) fileGr.WriteLine(group.ElementAt(i));
            }

            //Read file:
            using (StreamReader fileRd = new StreamReader(path))
            {
                string text = fileRd.ReadToEnd();
               
                Console.WriteLine($"\n\tИнформация из файла:\n");
                for (int i = 0; i < text.Length; i++) Console.Write(text.ElementAt(i));
            }






        }


    }
}
