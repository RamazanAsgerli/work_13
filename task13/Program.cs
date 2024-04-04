using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Group group = new Group("BB342",5);
            

            
            bool check = true;

            do
            {
                Console.WriteLine("1.Yeni user yarat");
                Console.WriteLine("2.Konsoldan qrupa melumat yolla");
                Console.WriteLine("3.yeni menu gelir asagidaki emeliyatlar olur");

                string a = Console.ReadLine();

                switch(a)
                {
                    case "1":
                        Console.WriteLine("Ad: ");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Point: ");
                        int point;
                        string pointStr;
                        do
                        {
                            pointStr = Console.ReadLine();
                        }while(!int.TryParse(pointStr, out point));
                        Student student = new Student(fullname,point);
                        group.AddStudent(student);
                        break;
                        case "2":
                        bool check1 = true;
                            Console.WriteLine("1.ShowInfo");
                            Console.WriteLine("2.Teze Grup yarat");
                            string b = Console.ReadLine();
                            switch (b)
                            {
                                case "1":
                                    Student[] students = group.GetAllStudents();
                                    for (int i = 0; i < students.Length; i++)
                                    {
                                        students[i].StudentInfo();
                                    }
                                    break;
                                case "2":
                                Console.WriteLine("GroupNo daxil edin:");
                                string groupno = Console.ReadLine();
                                Console.WriteLine("Limit daxil edin");
                                int studentlimit;
                                string studentlimitStr;
                                do
                                {
                                 studentlimitStr = Console.ReadLine();
                                }while(int.TryParse(studentlimitStr, out studentlimit));
                                group = new Group(groupno, studentlimit);
                                Console.WriteLine("Teze qrup yaradildi");
                                break;
                            }
                        break;
                        case "3":
                        Console.WriteLine("1.Butun telebeli goster");
                        Console.WriteLine("2.Id-e gore telebeni tap");
                        Console.WriteLine("3.Student Elave et");
                        Console.WriteLine("0.Proqrami bitir");

                        string c =Console.ReadLine();

                        switch (c) 
                        {
                            case "1":
                                Student[] students = group.GetAllStudents();
                                for (int i = 0; i < students.Length; i++)
                                {
                                    students[i].StudentInfo();
                                }
                                break;
                            case "2":
                                
                                int _id;
                                do
                                {
                                    Console.WriteLine("id daxil et:");

                                } while (!int.TryParse(Console.ReadLine(), out _id));
                                group.GetStudent(_id);
                                break;
                            case "3":
                                Console.WriteLine("Ad: ");
                                string Fullname = Console.ReadLine();
                                Console.WriteLine("Point: ");
                                int Point;
                                string PointStr;
                                do
                                {
                                    PointStr = Console.ReadLine();
                                } while (!int.TryParse(PointStr, out Point));
                                Student student1 = new Student(Fullname, Point);
                                group.AddStudent(student1);
                                break;
                            case "0":
                                check = false;
                                break;
                        }
                          break;

                    default: Console.WriteLine("Duzgun eded daxil edin!!!");
                        break;
                }

            }while(check);
        }
    }
}
