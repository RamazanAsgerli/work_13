using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    internal class Student
    {
        private static int _id;
        public string Fullname {  get; set; }
        public int Point { get; set; }

        public int Id { get; set; }
        public Student(string fullname,int point)
        {
            Fullname = fullname;
            Point = point;
            _id++;
            Id=_id;
        }
       

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname},Point: {Point}");
        }
    }
}
