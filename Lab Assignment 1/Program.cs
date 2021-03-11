using System;
using System.Collections.Generic;

namespace Lab_Assignment_1
{
    internal static class Program
    {
        private enum Campus
        {
            Isb,
            Lhr,
            Abb,
            Wah
        }

        private enum Session
        {
            FA,
            SP
        }

        private enum Year
        {
            FaSp18 = 2018,
            FaSp19 = 2019,
            FaSp20 = 2020,
            FaSp21 = 2021
        }

        private enum CourseProgram
        {
            Bse,
            Bcs,
            Bee,
            Bba,
            Bpy
        }

        private struct Student
        {
            private string _name;
            private string _regNo;
            private string _email;
            private string _gender;
            private Campus _campus;
            private Session _session;
            private Year _year;
            private CourseProgram _courseProgram;
            private int _rollNo;
            private int _sessionYear;
            private bool _isDeleted;

            public Student(bool noInfoAdded) : this("Default Student", "Male", Campus.Isb, Session.SP, Year.FaSp21,
                CourseProgram.Bcs, 1)
            {
                if (!noInfoAdded)
                    add_student();
            }

            private Student(string name, string gender, Campus campus, Session session, Year year,
                CourseProgram courseProgram, int rollNo)
            {
                _campus = campus;
                _session = session;
                _year = year;
                _courseProgram = courseProgram;
                _rollNo = rollNo;
                _sessionYear = Convert.ToInt32(_year) % 100;
                _regNo = "";
                _email = "";
                _name = name;
                _gender = gender;
                _isDeleted = false;
                string_Roll_No();
                set_Reg_NO();
                set_email();
            }

            private void string_Roll_No()
            {
                var temp = Convert.ToString(_rollNo);
                var length = temp.Length;
                for (var i = 3; i > length; i--) temp = "0" + temp;

                _regNo = temp;
            }

            public override string ToString()
            {
                if (!_isDeleted) return "CUI/" + _regNo + "/" + _campus;
                return "Student Record Not Found!";
            }

            private void set_Reg_NO()
            {
                var courseProgramString = _courseProgram.ToString();
                _regNo = "" + _session + _sessionYear + "-"  + courseProgramString.ToUpper() + "-" + _regNo;
            }

            private void set_email()
            {
                _email = "" + _regNo + "@isbstudent.comsats.edu.pk";
            }

            private void add_student()
            {
                Console.Write("Enter Your Name:");
                _name = Console.ReadLine();
                Console.Write("Enter Your Gender:");
                _gender = Console.ReadLine();

                while (true)
                    try
                    {
                        Console.Write("Enter Your Roll No:");
                        _rollNo = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (_rollNo >= 1 && _rollNo <= 999) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                int choice;
                while (true)
                    try
                    {
                        Console.Write("Enter Your Campus:\n Enter 1 For ISB\n Enter 2 For LHR\n" +
                                      " Enter 3 For ABB\n Enter 4 For WAH\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 4) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _campus = Campus.Isb;
                        break;
                    case 2:
                        _campus = Campus.Lhr;
                        break;
                    case 3:
                        _campus = Campus.Abb;
                        break;
                    case 4:
                        _campus = Campus.Wah;
                        break;
                }

                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For FA\n Enter 2 For SP\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice == 1 || choice == 2) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _session = Session.FA;
                        break;
                    case 2:
                        _session = Session.SP;
                        break;
                }

                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For 2018\n Enter 2 For 2019\n" +
                                      " Enter 3 For 2020\n Enter 4 For 2021\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 4) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _year = Year.FaSp18;
                        break;
                    case 2:
                        _year = Year.FaSp19;
                        break;
                    case 3:
                        _year = Year.FaSp20;
                        break;
                    case 4:
                        _year = Year.FaSp21;
                        break;
                }

                _sessionYear = Convert.ToInt32(_year) % 100;
                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For BSE\n Enter 2 For BCS\n" +
                                      " Enter 3 For BEE\n Enter 4 For BBA\n Enter 5 For BPY\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 5) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _courseProgram = CourseProgram.Bse;
                        break;
                    case 2:
                        _courseProgram = CourseProgram.Bcs;
                        break;
                    case 3:
                        _courseProgram = CourseProgram.Bee;
                        break;
                    case 4:
                        _courseProgram = CourseProgram.Bba;
                        break;
                    case 5:
                        _courseProgram = CourseProgram.Bpy;
                        break;
                }

                string_Roll_No();
                set_Reg_NO();
                set_email();
            }

            public void update_student()
            {
                _isDeleted = false;
                Console.Write("Enter Your Name:");
                _name = Console.ReadLine();
                Console.Write("Enter Your Gender:");
                _gender = Console.ReadLine();

                while (true)
                    try
                    {
                        Console.Write("Enter Your Roll No:");
                        _rollNo = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (_rollNo >= 1 && _rollNo <= 999) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                int choice;
                while (true)
                    try
                    {
                        Console.Write("Enter Your Campus:\n Enter 1 For ISB\n Enter 2 For LHR\n" +
                                      " Enter 3 For ABB\n Enter 4 For WAH\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 4) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _campus = Campus.Isb;
                        break;
                    case 2:
                        _campus = Campus.Lhr;
                        break;
                    case 3:
                        _campus = Campus.Abb;
                        break;
                    case 4:
                        _campus = Campus.Wah;
                        break;
                }

                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For FA\n Enter 2 For SP\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice == 1 || choice == 2) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _session = Session.FA;
                        break;
                    case 2:
                        _session = Session.SP;
                        break;
                }

                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For 2018\n Enter 2 For 2019\n" +
                                      " Enter 3 For 2020\n Enter 4 For 2021\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 4) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _year = Year.FaSp18;
                        break;
                    case 2:
                        _year = Year.FaSp19;
                        break;
                    case 3:
                        _year = Year.FaSp20;
                        break;
                    case 4:
                        _year = Year.FaSp21;
                        break;
                }

                _sessionYear = Convert.ToInt32(_year) % 100;
                while (true)
                    try
                    {
                        Console.Write("Enter Your Session:\n Enter 1 For BSE\n Enter 2 For BCS\n" +
                                      " Enter 3 For BEE\n Enter 4 For BBA\n Enter 5 For BPY\n Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 1 && choice <= 5) break;

                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Correct Option");
                    }

                switch (choice)
                {
                    case 1:
                        _courseProgram = CourseProgram.Bse;
                        break;
                    case 2:
                        _courseProgram = CourseProgram.Bcs;
                        break;
                    case 3:
                        _courseProgram = CourseProgram.Bee;
                        break;
                    case 4:
                        _courseProgram = CourseProgram.Bba;
                        break;
                    case 5:
                        _courseProgram = CourseProgram.Bpy;
                        break;
                }

                string_Roll_No();
                set_Reg_NO();
                set_email();
            }

            public void delete_Student()
            {
                _isDeleted = true;
            }

            public void display_Student_Details()
            {
                if (!_isDeleted)
                    Console.WriteLine(
                        $" Name: {_name}\n Gender: {_gender}\n Registration No: {_regNo}\n Campus: {_campus}" +
                        $"\n Course Program: {_courseProgram}\n Email: {_email}\n");
                else
                    Console.WriteLine("Student Record Not Found!");
            }
        }
        private static void StaticArrayMainMenu()
        {
            Console.WriteLine("Welcome To Static Array Student Information Center !!!");
            int studentCount;
            while (true)
                try
                {
                    Console.Write("Enter The Number Of Student You Want To Add: ");
                    studentCount = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (studentCount >= 1) break;

                    Console.WriteLine("Enter A Positive or Non-Zero Number");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Number!!!");
                }

            var students = new Student[studentCount];
            for (var i = 0; i < studentCount; i++)
            {
                Console.Write($"Do You Want to Add Details of Student No: {i + 1}?\n Enter YES To Add Details\n" +
                              " Enter NO To Add Details\n Enter Your Choice: ");
                var noInfoCheck = Console.ReadLine();
                if (noInfoCheck != null)
                    switch (noInfoCheck.ToLower())
                    {
                        case "yes":
                            students[i] = new Student(false);
                            break;
                        case "no":
                            students[i] = new Student(true);
                            break;
                        default:
                            students[i] = new Student(true);
                            break;
                    }
            }

            int choice;
            Console.WriteLine(" Welcome To Static Array Student Information Center !!!");
            while (true)
                try
                {
                    Console.Write(" Enter 1 To Display Student Details\n Enter 2 To Delete Student Details\n" +
                                  " Enter 3 To Update Student Details\n Enter 4 To Display All Student Details\n" +
                                  " Enter 0 To Exit\n" + " Enter Your Choice: ");
                    choice = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (choice >= 0 && choice <= 4) break;

                    Console.WriteLine("Enter A Non-Zero Number");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Number!!!");
                }

            if (choice == 0)
                Console.WriteLine("Exiting Static Array Student Information Center !!!");
            while (choice != 0)
            {
                int index;
                switch (choice)
                {
                    case 1:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Length) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].display_Student_Details();
                        break;
                    case 2:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Length) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].delete_Student();
                        break;
                    case 3:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Length) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].update_student();
                        break;
                    case 4:
                        for (var i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"Student No: {i + 1}");
                            students[i].display_Student_Details();
                        }

                        break;
                    default:
                        Console.WriteLine("Enter A Correct Option!!!");
                        break;
                }

                Console.WriteLine(" Welcome To Static Array Student Information Center !!!");
                while (true)
                    try
                    {
                        Console.Write(" Enter 1 To Display Student Details\n Enter 2 To Delete Student Details\n" +
                                      " Enter 3 To Update Student Details\n Enter 4 To Display All Student Details\n" +
                                      " Enter 0 To Exit\n" + " Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 0 && choice <= 4) break;
                        Console.WriteLine("Enter A Non-Zero Number");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }

                if (choice != 0) continue;
                Console.WriteLine("Exiting Static Array Student Information Center !!!");
                break;
            }
        }

        private static void DynamicArrayMainMenu()
        {
            Console.WriteLine("Welcome To Dynamic Array Student Information Center !!!");
            int studentCount;
            while (true)
                try
                {
                    Console.Write("Enter The Number Of Student You Want To Add: ");
                    studentCount = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (studentCount >= 1) break;
                    Console.WriteLine("Enter A Positive or Non-Zero Number");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Number!!!");
                }

            var students = new List<Student>();
            for (var i = 0; i < studentCount; i++)
            {
                Console.Write($"Do You Want to Add Details of Student No: {i + 1}?\n Enter YES To Add Details\n" +
                              " Enter NO To Add Details\n Enter Your Choice: ");
                var noInfoCheck = Console.ReadLine();
                if (noInfoCheck != null)
                    switch (noInfoCheck.ToLower())
                    {
                        case "yes":
                            students.Add(new Student(false));
                            break;
                        case "no":
                            students.Add(new Student(true));
                            break;
                        default:
                            students.Add(new Student(true));
                            break;
                    }
            }

            Console.WriteLine(" Welcome To Dynamic Array Student Information Center !!!");
            int choice;
            while (true)
                try
                {
                    Console.Write(" Enter 1 To Display Student Details\n Enter 2 To Delete Student Details\n" +
                                  " Enter 3 To Update Student Details\n Enter 4 To Display All Student Details\n" +
                                  " Enter 5 To Add New Student Details\n" +
                                  " Enter 0 To Exit\n" + " Enter Your Choice: ");
                    choice = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (choice >= 0 && choice <= 5) break;

                    Console.WriteLine("Enter A Positive Number");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter A Number!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter A Number!!!");
                }

            if (choice == 0)
                Console.WriteLine("Exiting Dynamic Array Student Information Center !!!");
            while (choice != 0)
            {
                int index;
                switch (choice)
                {
                    case 1:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Count) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].display_Student_Details();
                        Console.WriteLine(students[index-1]);
                        break;
                    case 2:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Count) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].delete_Student();
                        break;
                    case 3:
                        while (true)
                            try
                            {
                                Console.Write("Enter Student Index: ");
                                index = int.Parse(Console.ReadLine() ?? string.Empty);
                                if (index > 0 && index <= students.Count) break;

                                Console.WriteLine("Enter A Correct Index !!! ");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter A Number!!!");
                            }

                        Console.WriteLine($"Student No: {index}");
                        students[index - 1].update_student();
                        break;
                    case 4:
                        for (var i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine($"Student No: {i + 1}");
                            students[i].display_Student_Details();
                        }

                        break;
                    case 5:
                        Console.Write(
                            $"Do You Want to Add Details of Student No: {studentCount + 1}?\n Enter YES To Add Details\n" +
                            " Enter NO To Add Details\n Enter Your Choice: ");
                        var noInfoCheck = Console.ReadLine();
                        if (noInfoCheck != null)
                            switch (noInfoCheck.ToLower())
                            {
                                case "yes":
                                    students.Add(new Student(false));
                                    break;
                                case "no":
                                    students.Add(new Student(true));
                                    break;
                                default:
                                    students.Add(new Student(true));
                                    break;
                            }

                        break;
                    default:
                        Console.WriteLine("Enter A Correct Option!!!");
                        break;
                }

                Console.WriteLine(" Welcome To Dynamic Array Student Information Center !!!");
                while (true)
                    try
                    {
                        Console.Write(" Enter 1 To Display Student Details\n Enter 2 To Delete Student Details\n" +
                                      " Enter 3 To Update Student Details\n Enter 4 To Display All Student Details\n" +
                                      " Enter 5 To Add New Student Details\n" +
                                      " Enter 0 To Exit\n" + " Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (choice >= 0 && choice <= 4) break;

                        Console.WriteLine("Enter A Positive Number");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter A Number!!!");
                    }

                if (choice != 0) continue;
                Console.WriteLine("Exiting Dynamic Array Student Information Center !!!");
                break;
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                StaticArrayMainMenu();
                DynamicArrayMainMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}