namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManage manage = new UniversityManage();

            manage.FilterStudentsUniversity("Tec Morelia");
            manage.FilterStudentsUniversity("Bunsan Academy");

            manage.SortByAge();

            manage.StudentsAndUniversityName();
        }
    }

    class UniversityManage { 
        public List<Student> students = new List<Student>();
        public List<University> universities = new List<University>();

        public UniversityManage() {
            universities.Add(new University{ Id = 1, Name = "Bunsan Academy" });
            universities.Add(new University { Id = 2, Name = "Tec Morelia" });

            students.Add(new Student { Id = 1, Name = "Jocabed Ríos", Age = 23, Gender = "Female", UniversityId = 1 });
            students.Add(new Student { Id = 1, Name = "Esther Ríos", Age = 22, Gender = "Female", UniversityId = 2 });
            students.Add(new Student { Id = 1, Name = "Student 1", Age = 24, Gender = "Male", UniversityId = 1 });
            students.Add(new Student { Id = 1, Name = "Student 2", Age = 25, Gender = "Male", UniversityId = 1 });
        }

        public void FilterStudentsUniversity(string universityName) {
            var universityStudents = from student in students join university in universities
                                     on student.UniversityId equals university.Id
                                     where university.Name == universityName
                                     select student;

            Console.WriteLine("\n{0} students:", universityName);
            foreach (var student in universityStudents) {
                student.Print();
            }
        }

        public void SortByAge()
        {
            var sortStudents1 = from student in students
                                     orderby student.Age
                                     select student;

            Console.WriteLine("\nStudents order by Age:");
            Console.WriteLine("Younger - Older");
            foreach (var student in sortStudents1)
            {
                student.Print();
            }

            var sortStudents2 = from student in students
                               orderby student.Age descending
                               select student;

            Console.WriteLine("Older - Younger");
            foreach (var student in sortStudents2)
            {
                student.Print();
            }
        }

        public void StudentsAndUniversityName() {
            var collections = from student in students
                              join university in universities
                              on student.UniversityId equals university.Id
                              orderby student.Name
                              select new{StudentName = student.Name, UniversityName = university.Name};

            Console.WriteLine("\nStudent - University:");
            foreach (var col in collections) {
                Console.WriteLine("{0} studies at {1}.", col.StudentName, col.UniversityName);
            }
        }
    }


    class University {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print() {
            Console.WriteLine("University {0} with id {1}.", Name, Id);
        }
    }

    class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with id {1}.", Name, Id);
        }

    }
}