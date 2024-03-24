using System;
using System.Linq;
using System.Collections.Generic;

namespace Unit6.StudentManagement.Interface
{
    enum StudentSex
    {
        man = 1,
        woman = 2,
        other = 3
    }
    
    public class StudentManager : IStudentManager
    {
        public List<Student> students = new List<Student>();
        public int AddStudent(Student student)
        {
            
            try
            {
                if (student == null
                    || string.IsNullOrEmpty(student.name)
                    || !Enum.GetValues(typeof(StudentSex)).Cast<int>().Contains(student.sex)
                    || !(Enumerable.Range(1, 100).Contains(student.age))
                    || student.mathScore <= 0
                    || student.physicsScore <= 0
                    || student.chemistryScore <= 0
                    )
                {
                    
                    return -1;   
                }
                students.Add(student);
                return 1;

            }

            catch (Exception)
            {

                throw new Exception();
            };
        }

        public int UpdateStudent(Guid id, Student student)
        {
            try
            {
                var updatedStudent = students.FirstOrDefault(st => st.id == id);
                if (updatedStudent != null)
                {
                    updatedStudent.name = student.name;
                    updatedStudent.sex = student.sex;
                    updatedStudent.age = student.age;
                    updatedStudent.mathScore = student.mathScore;
                    updatedStudent.physicsScore = student.physicsScore;
                    updatedStudent.chemistryScore = student.chemistryScore;
                    return 1;

                }

                return -1;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public int DeleteStudent(Guid id)
        {
            try
            {
                var deletedStudent = students.FirstOrDefault(st => st.id == id);
                if (deletedStudent != null)
                {
                    students.Remove(deletedStudent);
                    return 1;
                }

                return -1;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public List<Student> FindStudent(string name)
        {
            try
            {
                List<Student> studentsWithName = students.Where(student => student.name == name).ToList();
                return studentsWithName;
            }
            catch (Exception)
            {
                throw new Exception();
            }
     
        }

        public List<Student> SortByAverageScore(int order)
        {
            try
            {
                if (order == 1)
                {
                    List<Student> sortedStudents = students.OrderBy(student => student.avgScore).ToList();
                    return sortedStudents;
                }
                List<Student> sortedDStudents = students.OrderByDescending(student => student.avgScore).ToList();
                return sortedDStudents;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public List<Student> SortByName(int order)
        {
            try
            {
                if (order == 1)
                {
                    List<Student> sortedStudents = students.OrderBy(student => student.name).ToList();
                    return sortedStudents;
                }
                List<Student> sortedDStudents = students.OrderByDescending(student => student.name).ToList();
                return sortedDStudents;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public List<Student> SortById(int order)
        {
            try
            {
                if (order == 1)
                {
                    List<Student> sortedStudents = students.OrderBy(student => student.id).ToList();
                    return sortedStudents;
                }
                List<Student> sortedDStudents = students.OrderByDescending(student => student.id).ToList();
                return sortedDStudents;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public List<Student> ShowStudents()
        {
            return students.ToList();
        }
    }
}