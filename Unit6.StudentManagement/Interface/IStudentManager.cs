using System;
using System.Collections.Generic;

namespace Unit6.StudentManagement.Interface
{
    public interface IStudentManager
    {
        int AddStudent(Student student);
        int UpdateStudent(Guid id, Student student);
        int DeleteStudent(Guid id);
        List<Student> FindStudent(string name);
        List<Student> SortByAverageScore(int order);
        List<Student> SortByName(int order);
        List<Student> SortById(int order);
        List<Student> ShowStudents();
    }
}