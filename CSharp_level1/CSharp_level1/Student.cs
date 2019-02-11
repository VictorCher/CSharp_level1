using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_level1
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, 
            string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        // Создаем студентов
        public static void Creator()
        {
            StreamWriter file = new StreamWriter("students.csv");
            file.WriteLine("Василий;Пупкин;МГУ;информатика;вычислительные машины;21;3;2201;Москва");
            file.WriteLine("Иван;Иванов;МГУ;информатика;вычислительные машины;20;5;2201;Москва");
            file.WriteLine("Антон;Григорьев;МГУ;информатика;вычислительные машины;20;1;2201;Москва");
            file.WriteLine("Геннадий;Залевский;МГУ;информатика;вычислительные машины;19;5;2201;Москва");
            file.WriteLine("Андрей;Воробьев;ПТУ;информатика;вычислительные машины;18;2;2201;Москва");
            file.WriteLine("Виктор;Сухоруков;МАМИ;информатика;вычислительные машины;22;2;8065;Калуга");
            file.WriteLine("Пётр;Орешкин;МАИ;информатика;вычислительные машины;18;2;2201;Орёл");
            file.Close();
        }
    }
    
}
