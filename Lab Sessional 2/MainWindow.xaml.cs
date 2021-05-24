using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Sessional_2 {
    public class Student {
        public Student(string name, string regNo) {
            Name = name;
            RegNo = regNo;
        }

        public string Name { get; set; }

        public string RegNo { get; set; }
    }
    public partial class MainWindow : Window {
        private readonly List<Student> _students;
        public MainWindow() {
            InitializeComponent();
            _students = new List<Student>();
        }
        private void AddStudent(object sender, RoutedEventArgs e)
        {
            var name = Name.Text;
            var regNo = RegNo.Text;
            if (_students.Any(t => t.RegNo == regNo))
            {
                MessageBox.Show("Student Already Exists");
                return;
            }
            var splitregNo = regNo.Split('-');
            
            if (splitregNo[0].Length == 4 && splitregNo[1].Length == 3 && splitregNo[2].Length == 3 )
            {
                MessageBox.Show("Valid Reg No Entered");
            }
            else
            {
                MessageBox.Show("Invalid Reg No Entered");
                return;
            }
            _students.Add(new Student(name, regNo));
            MessageBox.Show("Name: " + name + " Reg No: " + regNo + " Is Added!");
        }
        private void SearchStudent(object sender, RoutedEventArgs e)
        {
            var searchedStudent = from student in _students
                orderby student.RegNo
                where student.Name.Contains(Search.Text) || student.Name.StartsWith(Search.Text) ||
                      student.Name.EndsWith(Search.Text)
                select student;
            DisplayStudents.ItemsSource = searchedStudent;
        }

        
    }

    
}