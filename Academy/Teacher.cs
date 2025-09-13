
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher : Human
    {
        public string Speciality { get; set; }
        public int  Expirians{ get; set; }

        public Teacher
            (
            string lastName, string firstName, int age, string speciality, int expirians
            ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Expirians = expirians;

         //   Console.WriteLine($"TConstructor:\t{GetHashCode().ToString("X")}"); 

        }
        public override string ToString()=> base.ToString() + $"\t{Speciality,-15} {Expirians,5}";
       
    }
}
