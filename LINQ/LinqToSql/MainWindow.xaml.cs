using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.Linq;

namespace LinqToSql
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.csharpDB0ConnectionString"].ConnectionString;
            dataContext = new LinqToSqlClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudensLecturesAssociation();
            //GetStudenUniversity("Jocabed Ríos");
            //GetStudenLecture("Esther Ríos");
            //GetUniversitiesWithWomen();
            //GetLecturesUniversity("Bunsan");
            //UpdateStudentName("Student 1", "Haru");
            //DeleteStudent("Student 2");

        }

        public void InsertUniversities() {
            dataContext.ExecuteCommand("delete from University;");

            University university = new University();
            university.Name = "Bunsan";
            dataContext.University.InsertOnSubmit(university);

            University university2 = new University();
            university2.Name = "Tec Morelia";
            dataContext.University.InsertOnSubmit(university2);

            dataContext.SubmitChanges();
            MainDataGrrid.ItemsSource = dataContext.University;
        }

        public void InsertStudents() {
            University bunsan = dataContext.University.First(u => u.Name.Equals("Bunsan"));
            University tec = dataContext.University.First(u => u.Name.Equals("Tec Morelia"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Id = 1, Name = "Jocabed Ríos", Gender = "Female", UniversityId = bunsan.Id });
            students.Add(new Student { Id = 1, Name = "Esther Ríos", Gender = "Female", UniversityId = tec.Id });
            students.Add(new Student { Id = 1, Name = "Student 1", Gender = "Male", UniversityId = bunsan.Id});
            students.Add(new Student { Id = 1, Name = "Student 2", Gender = "Male", UniversityId = tec.Id });

            dataContext.Student.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrrid.ItemsSource = dataContext.Student;
        }

        public void InsertLectures()
        {
            Lecture quijote = new Lecture();
            quijote.Name = "El Quijote de la Mancha";
            dataContext.Lecture.InsertOnSubmit(quijote);

            Lecture love = new Lecture();
            love.Name = "El amor en tiempos de cólera";
            dataContext.Lecture.InsertOnSubmit(love);

            dataContext.SubmitChanges();
            MainDataGrrid.ItemsSource = dataContext.Lecture;
        }

        public void InsertStudensLecturesAssociation() {
            Student student3 = dataContext.Student.First(e => e.Name.Equals("Jocabed Ríos"));
            Student student4 = dataContext.Student.First(e => e.Name.Equals("Esther Ríos"));
            Student student1 = dataContext.Student.First(e => e.Name.Equals("Student 1"));
            Student student2 = dataContext.Student.First(e => e.Name.Equals("Student 2"));

            Lecture quijote = dataContext.Lecture.First(l => l.Name.Equals("El Quijote de la Mancha"));
            Lecture love = dataContext.Lecture.First(l => l.Name.Equals("El amor en tiempos de cólera"));

            List<StudentLecture> studentLectures = new List<StudentLecture>();

            studentLectures.Add(new StudentLecture {StudentId = student1.Id, LectureId = quijote.Id });
            studentLectures.Add(new StudentLecture { StudentId = student2.Id, LectureId = quijote.Id });
            studentLectures.Add(new StudentLecture { StudentId = student3.Id, LectureId = love.Id });
            studentLectures.Add(new StudentLecture { StudentId = student4.Id, LectureId = love.Id });

            dataContext.StudentLecture.InsertAllOnSubmit(studentLectures);
            dataContext.SubmitChanges();

            MainDataGrrid.ItemsSource = dataContext.StudentLecture;
        }

        public void GetStudenUniversity(string studentName) { 
            Student student = dataContext.Student.First(e => e.Name.Equals(studentName));
            University studentUniversity = student.University;

            List<University> universities = new List<University>(); 
            universities.Add(studentUniversity);

            MainDataGrrid.ItemsSource = universities;
        }

        public void GetStudenLecture(string studentName)
        {
            Student student = dataContext.Student.First(e => e.Name.Equals(studentName));

            var lectures = from s in student.StudentLecture select s.Lecture;

            MainDataGrrid.ItemsSource = lectures;
        }

        public void GetUniversitiesWithWomen()
        {
            var universities = from s in dataContext.Student
                               join u  in dataContext.University
                               on s.UniversityId equals u.Id
                               where s.Gender == "Female"
                               select u;

            MainDataGrrid.ItemsSource = universities;
        }

        public void GetLecturesUniversity(string universityName)
        {
            var lectures = from sl in dataContext.StudentLecture
                               join s in dataContext.Student
                               on sl.StudentId equals s.Id
                               where s.University.Name == universityName
                               select sl.Lecture;

            MainDataGrrid.ItemsSource = lectures;
        }

        public void UpdateStudentName(string studentName, string newName)
        {
            Student student = dataContext.Student.First(e => e.Name.Equals(studentName));
            student.Name = newName;

            dataContext.SubmitChanges();

            MainDataGrrid.ItemsSource = dataContext.Student;
        }

        public void DeleteStudent(string studentName)
        {
            Student student = dataContext.Student.First(e => e.Name.Equals(studentName));
            dataContext.Student.DeleteOnSubmit(student);
            dataContext.SubmitChanges();

             MainDataGrrid.ItemsSource = dataContext.Student;
        }
    }
}
