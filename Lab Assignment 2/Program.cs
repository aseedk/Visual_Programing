using System;
using System.Collections.Generic;

namespace Lab_Assignment_2
{
    /// <summary>
    /// Activity 1 Starts
    /// </summary>
    internal class DayCollection
    {
        public string[] Days { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        public int this[string day]
        {
            get
            {
                switch (day)
                {
                    case "Monday":
                        return 1;
                    case "Tuesday":
                        return 2;
                    case "Wednesday":
                        return 3;
                    case "Thursday":
                        return 4;
                    case "Friday":
                        return 5;
                    case "Saturday":
                        return 6;
                    case "Sunday":
                        return 7;
                    default:
                        return 0;
                }
            }
        }
    }

    class Activity1Test
    {
        public void Menu()
        {
            while (true)
            {
                var week = new DayCollection();
                Console.Write("Enter a Day: ");
                var day = Console.ReadLine();
                Console.WriteLine($"{day}: Returns {week[day]}");
                Console.Write("Enter 1 to continue" +
                              "\nEnter Any Key To Exit" +
                              "\nEnter Your Choice: ");
                var choice = Console.ReadLine();
                if (choice == "1") continue;
                Console.Write("Exiting Day Collection!!!");
                break;
            }
        }
    }
    /// <summary>
    /// Activity 1 Ends
    /// </summary>
    
    
    /// <summary>
    /// Activity 3 Starts
    /// </summary>
    internal interface IPerson
    {
        void Add();
        void Update();
        void Delete();
    }

    internal abstract class AbsStudent: IPerson
    {
        public virtual void Add()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }
    }

    internal abstract class AbsTeacher: IPerson
    {
        public virtual void Add()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }
    }

    internal class Student : AbsStudent
    {
        private string _name;
        private string _registrationNo;
        private double _cgpa;
        private string _gender;
        private bool _isDeleted;

        public Student()
        {
            _name = null;
            _registrationNo = null;
            _cgpa = 0.0;
            _gender = null;
            _isDeleted = false;
            Add();
        }

        public sealed override void Add()
        {
            Console.Write("Enter Your Name:");
            _name = Console.ReadLine();
            Console.Write("Enter Your Registration No:");
            _registrationNo = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter Your CGPA:");
                    _cgpa = double.Parse(Console.ReadLine() ?? string.Empty);
                    if (_cgpa > 0.0) break;
                    throw new Exception("CGPA Cannot be Less than 0.0\n Enter A Proper CGPA!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Correct CGPA");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Correct CGPA");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Correct CGPA");
                }
            }
            Console.Write("Enter Your Gender:");
            _gender = Console.ReadLine();
        }

        public override void Update()
        {
            _isDeleted = false;
            Add();
        }

        public override void Delete()
        {
            _isDeleted = true;
        }

        public override string ToString()
        {
            if (_isDeleted) return "Student Record Deleted";
            var display = $" Name + {_name}\n Registration No: {_registrationNo}\n CGPA: {_cgpa}\n";
            return display;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string RegistrationNo
        {
            get => _registrationNo;
            set => _registrationNo = value;
        }

        public double Cgpa
        {
            get => _cgpa;
            set => _cgpa = value;
        }

        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public bool IsDeleted
        {
            get => _isDeleted;
            set => _isDeleted = value;
        }
    }

    internal class Teacher : AbsTeacher
    {
        private string _name;
        private string _course;
        private string _highestDegree;
        private DateTime _dateOfJoining;
        private string _gender;
        private bool _isDeleted;

        public Teacher()
        {
            _name = null;
            _course = null;
            _highestDegree = null;
            _dateOfJoining = new DateTime();
            _gender = null;
            _isDeleted = false;
            Add();
        }

        public sealed override void Add()
        {
            Console.Write("Enter Your Name:");
            _name = Console.ReadLine();
            Console.Write("Enter Your Course:");
            _course = Console.ReadLine();
            Console.Write("Enter Your Highest Degree:");
            _highestDegree = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter Your Day:");
                    var day = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Enter Your Month:");
                    var month = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Enter Your Year:");
                    var year = int.Parse(Console.ReadLine() ?? string.Empty);
                    _dateOfJoining = new DateTime(day, month, year);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Correct Date Of Birth");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Correct Date Of Birth");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Correct Date Of Birth");
                }
            }
            Console.Write("Enter Your Gender:");
            _gender = Console.ReadLine();
        }

        public override void Update()
        {
            _isDeleted = false;
            Add();
        }

        public override void Delete()
        {
            _isDeleted = true;
        }
        public override string ToString()
        {
            if (_isDeleted) return "Teacher Record Deleted!";
            var display = $" Name: {_name}\n Course: {_course}";
            return display;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Course
        {
            get => _course;
            set => _course = value;
        }

        public string HighestDegree
        {
            get => _highestDegree;
            set => _highestDegree = value;
        }

        public DateTime DateOfJoining
        {
            get => _dateOfJoining;
            set => _dateOfJoining = value;
        }

        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }
    }

    internal class Activity3Test
    {
        public Activity3Test()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void Menu()
        {
            string choice = "-1";
            while (choice != "3" )
            {
                Console.Write("Welcome to University Management System!!!" +
                              "\nEnter 1 For Student Management System" +
                              "\nEnter 2 For Teacher Management System" +
                              "\nEnter 3 To Exit" +
                              "\nEnter Your Choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                 case "1":
                     StudentMainMenu();
                     break;
                 case "2":
                     TeacherMainMenu();
                     break;
                 case "3":
                     choice = "3";
                     break;
                 default:
                     Console.WriteLine("Enter A proper Choice: ");
                     break;
                }

                if (choice == "3") 
                {
                    Console.WriteLine("Exiting University Management System!!!");
                    break;
                }
                Console.Write("Welcome to University Management System!!!" +
                              "\nEnter 1 For Student Management System" +
                              "\nEnter 2 For Teacher Management System" +
                              "\nEnter 3 To Exit" +
                              "\nEnter Your Choice: ");
                choice = Console.ReadLine();
            }
        }

        private void StudentMainMenu()
        {
            var choice = "-1";
            while (choice != "5")
            {
                Console.Write("Welcome to Student Management System!!!" +
                              "\nEnter 1 To Add Student" +
                              "\nEnter 2 To Update Student" +
                              "\nEnter 3 To Delete Student" +
                              "\nEnter 4 To Display Student" +
                              "\nEnter 5 To Exit" +
                              "\nEnter Your Choice: ");   
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Students.Add(new Student());
                        Console.Write("Student Added!!!");
                        break;
                    case "2":
                        try
                        {
                            var index = int.Parse(Console.ReadLine() ?? string.Empty);
                            if (index >= 0 && index < Students.Count)
                            {
                                Students[index].Update();
                            }
                            else
                            {
                                throw new Exception("Enter Proper Index");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                        Console.WriteLine("Student Updated!!!");
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Enter Index: ");
                            var index = int.Parse(Console.ReadLine() ?? string.Empty);
                            if (index >= 0 && index < Students.Count)
                            {
                                Students[index].Delete();
                            }
                            else
                            {
                                throw new Exception("Enter Proper Index");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                        Console.WriteLine("Student Deleted!!!");
                        break;
                    case "4":
                        foreach (var t in Students)
                        {
                            Console.Write(t);
                        }
                        Console.WriteLine("All Student Displayed!!!");
                        break;
                    case "5":
                        choice = "5";
                        break;
                    default:
                        Console.WriteLine("Enter A proper Choice: ");
                        break;
                }
            }
            
        }

        private void TeacherMainMenu()
        {
            var choice = "-1";
            while (choice != "5")
            {
                Console.Write("Welcome to Teacher Management System!!!" +
                              "\nEnter 1 To Add Teacher" +
                              "\nEnter 2 To Update Teacher" +
                              "\nEnter 3 To Delete Teacher" +
                              "\nEnter 4 To Display Teacher" +
                              "\nEnter 5 To Exit" +
                              "\nEnter Your Choice: ");   
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Teachers.Add(new Teacher());
                        Console.Write("Teacher Added!!!");
                        break;
                    case "2":
                        try
                        {
                            Console.Write("Enter Index: ");
                            var index = int.Parse(Console.ReadLine() ?? string.Empty);
                            if (index >= 0 && index < Teachers.Count)
                            {
                                Teachers[index].Update();
                            }
                            else
                            {
                                throw new Exception("Enter Proper Index");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                        Console.WriteLine("Student Updated!!!");
                        break;
                    case "3":
                        try
                        {
                            Console.Write("Enter Index: ");
                            var index = int.Parse(Console.ReadLine() ?? string.Empty);
                            if (index >= 0 && index < Teachers.Count)
                            {
                                Teachers[index].Delete();
                            }
                            else
                            {
                                throw new Exception("Enter Proper Index");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                        Console.WriteLine("Teacher Deleted!!!");
                        break;
                    case "4":
                        foreach (var t in Teachers)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("All Teacher Displayed!!!");
                        break;
                    case "5":
                        choice = "5";
                        break;
                    default:
                        Console.WriteLine("Enter A proper Choice: ");
                        break;
                }
            }
            
        }

        private List<Student> Students { get; set; }

        private List<Teacher> Teachers { get; set; }
    }
    /// <summary>
    /// Activity 3 Ends
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var activity1Test = new Activity1Test();
            var activity3Test = new Activity3Test();
            activity1Test.Menu();
            activity3Test.Menu();
        }
    }
}