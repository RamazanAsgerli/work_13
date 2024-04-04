using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task13
{
    internal class Group
    {
        public Student[] Students = { };

        public string GroupNo;
        private int _studentlimit;
        public int StudentLimit
        {
            get { return _studentlimit; }
            set
            {
                if (value >= 0 && value <= 18)
                {
                    value = _studentlimit;
                }
                else { Console.WriteLine("Limit kecilib"); }
            }
        }

        public Group(string groupNo,int studentlimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentlimit;
        }

        public bool CheckGroupNo(string groupNo)
        {
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            bool check4 = false;

            if (char.IsUpper(groupNo[0])) check = true;
            if (char.IsUpper(groupNo[1])) check = true;
            if (char.IsDigit(groupNo[2])) check = true;
            if (char.IsDigit(groupNo[3])) check = true;
            if (char.IsDigit(groupNo[4])) check = true;

            return check && check1 && check2 && check3 && check4;
        }

        public void AddStudent(Student student)
        {

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void GetStudent(int id)
        {
            
            for(int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Students[i].StudentInfo();
                }
            }
            
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }



    }
}
