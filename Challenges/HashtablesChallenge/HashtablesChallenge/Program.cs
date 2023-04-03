using System.Collections;

namespace HashtablesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student(1, "Joca", 10);
            students[1] = new Student(2, "Caleb", 10);
            students[2] = new Student(3, "Edgar", 10);
            students[3] = new Student(4, "Amir", 10);
            students[4] = new Student(1, "intruder", 10);

            Hashtable studentsTable = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsTable.ContainsKey(student.Id)) {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Succeful student stored. ID: {0}, Name: {1}, GPA: {2}.", student.Id, student.Name, student.GPA);
                } 
                else Console.WriteLine("Sorry, a student with the same ID already exists. ID: {0}.", student.Id);
            }

        }
    }

    class Student { 
        public int Id { get; set; }
        public string Name { get; set; }  
        public float GPA { get; set; }

        public Student(int id, string name, float gpa) {
            this.Id = id;
            this.Name = name;
            this. GPA = gpa;
        }
    }
}