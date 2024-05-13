//1. Write a class: “Student” with private data members:
//StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member.
//Instantiate the class and assign data to properties. Display the data back on console.

namespace Assignment2._1
{
    public class Program
    {
        static void Main(string[] args)
        {
         Student myStudent = new Student();
            myStudent.StudentId = 12345;
            myStudent.StudentFName = "Mike";
            myStudent.StudentLName = "Flores";
            myStudent.StudentGrade = 'A';

            Console.WriteLine("The student ID is: " + myStudent.StudentId);
            Console.WriteLine("The student first name is: " + myStudent.StudentFName);
            Console.WriteLine("The student last name is: " + myStudent.StudentLName);
            Console.WriteLine("The student grade is: " + myStudent.StudentGrade);
        }
    }
    public class Student
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        private string _studentFName;
        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }

        private string _studentLName;
        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        private char _studentGrade;
        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }

    }

}
