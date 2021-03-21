// Name: Aseed Ali Khokhar
// Reg NO: FA18-BSE-015 
// Class: BSE 6A
// Lab Assignment 2 Visual Programming
// 24th March, 2021

using System;
using System.Collections.Generic;

namespace Lab_Assignment_2
{
    /// <summary>
    ///     Activity 1 Starts
    /// </summary>
    internal class DayCollection
    {
        public string[] Days { get; set; } =
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

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

    internal class Activity1Test
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
    ///     Activity 1 Ends
    /// </summary>
    /// <summary>
    ///     Activity 2 Starts
    /// </summary>
    internal class Box
    {
        protected Box()
        {
        }

        protected Box(double length, double breadth, double height)
        {
            this.Length = length;
            this.Breadth = breadth;
            this.Height = height;
        }

        public double Length { get; set; }

        public double Breadth { get; set; }

        public double Height { get; set; }

        public double GetVolume()
        {
            return Height * Length * Height;
        }
    }

    internal class BoxExtended : Box, IEquatable<BoxExtended>
    {
        public bool Equals(BoxExtended other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BoxExtended) obj);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public BoxExtended()
        {
        }

        public BoxExtended(double length, double breadth, double height) : base(length, breadth, height)
        {
        }

        public static BoxExtended operator +(BoxExtended b1, BoxExtended b2)
        {
            var box = new BoxExtended
            {
                Length = b1.Length + b2.Length, Breadth = b1.Breadth + b2.Breadth, Height = b1.Height + b2.Height
            };
            return box;
        }

        public static bool operator <(BoxExtended b1, BoxExtended b2)
        {
            return b1.Length < b2.Length && b1.Height < b2.Height && b1.Breadth < b2.Breadth;
        }

        public static bool operator >(BoxExtended b1, BoxExtended b2)
        {
            return b1.Length > b2.Length && b1.Height > b2.Height && b1.Breadth > b2.Breadth;
        }

        public static bool operator <=(BoxExtended b1, BoxExtended b2)
        {
            return b1.Length <= b2.Length && b1.Height <= b2.Height && b1.Breadth <= b2.Breadth;
        }

        public static bool operator >=(BoxExtended b1, BoxExtended b2)
        {
            return b1.Length >= b2.Length && b1.Height >= b2.Height && b1.Breadth >= b2.Breadth;
        }

        public static bool operator !=(BoxExtended b1, BoxExtended b2)
        {
            return !(b2 is null) && !(b1 is null)
                                 && Math.Abs(b1.Length - b2.Length) == 0
                                 && Math.Abs(b1.Height - b2.Height) == 0
                                 && Math.Abs(b1.Breadth - b2.Breadth) == 0;
        }

        public static bool operator ==(BoxExtended b1, BoxExtended b2)
        {
            return !(b2 is null) && !(b1 is null)
                                 && Math.Abs(b1.Length - b2.Length) == 0
                                 && Math.Abs(b1.Height - b2.Height) == 0
                                 && Math.Abs(b1.Breadth - b2.Breadth) == 0;
        }
    }

    internal class Activity2Test
    {
        public static void Menu()
        {
            var box1 = new BoxExtended(); // Declare Box1 of type Box 
            var box2 = new BoxExtended(); // Declare Box2 of type Box 

            // box 1 specification 
            box1.Length = 6.0;
            box1.Breadth = 7.0;
            box1.Height = 5.0;

// box 2 specification 
            box2.Length = 12.0;
            box2.Breadth = 13.0;
            box2.Height = 10.0;

//displaying the Boxes using the overloaded ToString(): 
            Console.WriteLine("Box 1: {0}", box1);
            Console.WriteLine("Box 2: {0}", box2);

// volume of box 1 
            var volume = box1.GetVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

// volume of box 2 
            volume = box2.GetVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

// Add two object as follows: 
            var box3 = box1 + box2;
            Console.WriteLine("Box 3: {0}", box3);

// volume of box 3 
            volume = box3.GetVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

//comparing the boxes 
            if (box1 > box2)
                Console.WriteLine("Box1 is greater than Box2");
            else
                Console.WriteLine("Box1 is greater than Box2");

            if (box1 < box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");

            if (box1 >= box2)
                Console.WriteLine("Box1 is greater or equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");

            if (box1 <= box2)
                Console.WriteLine("Box1 is less or equal to Box2");
            else
                Console.WriteLine("Box1 is not less or equal to Box2");

            if (box1 != box2)
                Console.WriteLine("Box1 is not equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");

            var box4 = box3;

            if (box3 == box4)
                Console.WriteLine("Box3 is equal to Box4");
            else
                Console.WriteLine("Box3 is not equal to Box4");
            Console.ReadKey();
        }
    }

    /// <summary>
    ///     Activity 3 Starts
    /// </summary>
    internal interface IPerson
    {
        void Add();
        void Update();
        void Delete();
    }

    internal abstract class AbsStudent : IPerson
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

    internal abstract class AbsTeacher : IPerson
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
        public Student()
        {
            Name = null;
            RegistrationNo = null;
            Cgpa = 0.0;
            Gender = null;
            IsDeleted = false;
            Add();
        }

        private string Name { get; set; }

        private string RegistrationNo { get; set; }

        private double Cgpa { get; set; }

        private string Gender { get; set; }

        public bool IsDeleted { get; set; }

        public sealed override void Add()
        {
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Your Registration No:");
            RegistrationNo = Console.ReadLine();
            while (true)
                try
                {
                    Console.Write("Enter Your CGPA:");
                    Cgpa = double.Parse(Console.ReadLine() ?? string.Empty);
                    if (Cgpa > 0.0) break;
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

            Console.Write("Enter Your Gender:");
            Gender = Console.ReadLine();
        }

        public override void Update()
        {
            IsDeleted = false;
            Add();
        }

        public override void Delete()
        {
            IsDeleted = true;
        }

        public override string ToString()
        {
            if (IsDeleted) return "Student Record Deleted";
            var display = $" Name + {Name}\n Registration No: {RegistrationNo}\n CGPA: {Cgpa}\n";
            return display;
        }
    }

    internal class Teacher : AbsTeacher
    {
        private bool _isDeleted;

        public Teacher()
        {
            Name = null;
            Course = null;
            HighestDegree = null;
            DateOfJoining = new DateTime();
            Gender = null;
            _isDeleted = false;
            Add();
        }

        private string Name { get; set; }

        private string Course { get; set; }

        private string HighestDegree { get; set; }

        private DateTime DateOfJoining { get; set; }

        private string Gender { get; set; }

        public sealed override void Add()
        {
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Your Course:");
            Course = Console.ReadLine();
            Console.Write("Enter Your Highest Degree:");
            HighestDegree = Console.ReadLine();
            while (true)
                try
                {
                    Console.Write("Enter Your Day:");
                    var day = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Enter Your Month:");
                    var month = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Enter Your Year:");
                    var year = int.Parse(Console.ReadLine() ?? string.Empty);
                    DateOfJoining = new DateTime(day, month, year);
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

            Console.Write("Enter Your Gender:");
            Gender = Console.ReadLine();
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
            var display = $" Name: {Name}\n Course: {Course}";
            return display;
        }
    }

    internal class Activity3Test
    {
        public Activity3Test()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        private List<Student> Students { get; }

        private List<Teacher> Teachers { get; }

        public void Menu()
        {
            var choice = "-1";
            while (choice != "3")
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
                                Students[index].Update();
                            else
                                throw new Exception("Enter Proper Index");
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
                                Students[index].Delete();
                            else
                                throw new Exception("Enter Proper Index");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }

                        Console.WriteLine("Student Deleted!!!");
                        break;
                    case "4":
                        foreach (var t in Students) Console.Write(t);
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
                                Teachers[index].Update();
                            else
                                throw new Exception("Enter Proper Index");
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
                                Teachers[index].Delete();
                            else
                                throw new Exception("Enter Proper Index");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }

                        Console.WriteLine("Teacher Deleted!!!");
                        break;
                    case "4":
                        foreach (var t in Teachers) Console.WriteLine(t);
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
    }

    /// <summary>
    ///     Activity 3 Ends
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var activity1Test = new Activity1Test();
            //var activity2Test = new Activity2Test();
            var activity3Test = new Activity3Test();
            activity1Test.Menu();
            Activity2Test.Menu();
            activity3Test.Menu();
        }
    }
}