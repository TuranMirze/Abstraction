using System.Drawing;
using System.Text.RegularExpressions;

namespace Abstraction_Turco
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double Point;
            string studentfullname;
            bool f=false;
            string fullname;
            string email;


            Console.WriteLine("Fullname daxil edin:");
            fullname = Console.ReadLine();

            Console.WriteLine("Email daxil edin:");
            email = Console.ReadLine();



            User user = new User(fullname, email);
            bool isPass = false ;
            do
            {
                Console.WriteLine("Parol daxil edin");
                string password = Console.ReadLine();
                if (user.PasswordChecker(password) == true)
                {
                    isPass = true;
                }
                else
                {
                    isPass = false;
                }

            } while (!isPass);
            string group;
            bool isGroup = false;
            do
            {
                Console.WriteLine("Qrup adi daxil edin:");
                group = Console.ReadLine();
                if (group.Length == 5 && char.IsUpper(group[0]) && char.IsUpper(group[1]) && char.IsDigit(group[2]) && char.IsDigit(group[3]) && char.IsDigit(group[4]))
                {
                    isGroup = true;
                }
                else
                {
                    isGroup = false;
                }
            } while (!isGroup);


            bool isLimit = false;
            int limit;
            do
            {
                Console.WriteLine("Limit daxil edin:");
                isLimit= int.TryParse(Console.ReadLine(), out limit);
                if(limit>4 && limit < 17)
                {
                    isLimit = true;
                }
                else
                {
                    isLimit= false;
                }
            } while (!isLimit);

            Group students = new Group(group, limit);


            do
            {               

                Console.WriteLine("1.ShowInfo_User   2.AddStudent   3.GetStudent   4.GetAllStudent  0.Exit");


                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Butun melumatlar:");
                        user.ShowInfo();
                        break;
                    case "2":
                        Console.WriteLine("Fullname daxil edin:");
                        studentfullname = Console.ReadLine();

                        bool Ispoint = false;

                        do
                        {
                            Console.WriteLine("Point daxil edin:");
                            Ispoint = double.TryParse(Console.ReadLine(), out Point);
                            if (Point >= 0 && Point <= 100)
                            {
                                Ispoint = true;
                            }
                            else
                            {
                                Ispoint = false;
                            }
                        } while (!Ispoint);
                        Student student = new Student(studentfullname, Point);
                        students.AddStudent(student);
                        break;
                    case "3":
                        int id;
                        bool Isid = false;
                        do
                        {
                            Console.WriteLine("Id daxil edin:");
                            Isid = int.TryParse(Console.ReadLine(), out id);
                            if (id > 0)
                            {
                                Isid = true;
                            }
                            else
                            {
                                Isid = false;
                            }
                        } while (!Isid);
                        students.GetStudent(id);
                        break;
                    case "4":
                        students.GetAllStudent();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            } while (!f);
        }
    }
}
