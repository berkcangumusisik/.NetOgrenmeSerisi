using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Classes
{
    public class Student
    {

        public Student()
        {
            Console.WriteLine("Constructor Çalıştı");
        }
        public Student(int id , String fullName, String classes)
        {
            this.ID = id;
            this.FullName = fullName;
            this.Class = classes;
        } 
        //Property : Özellikler burada tanımlanır.
        public int ID { get; set; }

        public String FullName { get; set; }

        public String Class { get; set; }

        public void Info()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Class: " + Class);
        }
    }

}
