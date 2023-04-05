using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //We simply apply our Student-Structure to XML. 
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Jocabed</Name>
                                <Age>23</Age>
                                <University>Bunsan</University>
                                <Semester>1</Semester>
                                <Gender>Female</Gender>
                            </Student>
                            <Student>
                                <Name>Esther</Name>
                                <Age>22</Age>
                                <University>Tec Morelia</University>
                                <Semester>9</Semester>
                                <Gender>Female</Gender>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                                <Gender>Female</Gender>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Yale</University>
                                <Semester>10</Semester>
                                <Gender>Male</Gender>
                            </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value,
                               Gender = student.Element("Gender").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her {3} Semester, his gender is {4}.", student.Name, student.Age, student.University, student.Semester, student.Gender);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2}", student.Name, student.Age, student.University);
            }

            Console.ReadLine();
        }
    }
}
