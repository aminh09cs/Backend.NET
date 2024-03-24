using System;
using System.Collections.Generic;
using Unit6.StudentManagement.Interface;

namespace Unit6.StudentManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            
            int service = 0;
            Console.WriteLine("1. Thêm sinh viên.");
            Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID.");
            Console.WriteLine("3. Xóa sinh viên bởi ID.");
            Console.WriteLine("4. Tìm kiếm sinh viên theo tên.");
            Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình (GPA).");
            Console.WriteLine("6. Sắp xếp sinh viên theo tên.");
            Console.WriteLine("7. Sắp xếp sinh viên theo ID.");
            Console.WriteLine("8. Hiển thị danh sách sinh viên.");
            Console.WriteLine("9. Thoát");
            do
            {
                Console.Write("Nhập lựa chọn của bạn: ");
                
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out service);
                

                switch (service)
                {
                    case 1: 
                        Student student = new Student();
                        Console.Write("Nhập tên sinh viên: ");
                        student.name = Console.ReadLine();
                        Console.Write("Nhập giới tính sinh viên: (1: Man, 2: Woman, 3: Other): ");
                        student.sex = int.Parse(Console.ReadLine());
                        Console.Write("Nhập tuổi sinh viên: ");
                        student.age = int.Parse(Console.ReadLine());
                        Console.Write("Nhập điểm toán sinh viên: ");
                        student.mathScore = double.Parse(Console.ReadLine());
                        Console.Write("Nhập điểm lý sinh viên: ");
                        student.physicsScore = double.Parse(Console.ReadLine());
                        Console.Write("Nhập điểm hóa sinh viên: ");
                        student.chemistryScore = double.Parse(Console.ReadLine());
                        int flag = studentManager.AddStudent(student);

                        if (flag == 1)
                        {
                            Console.WriteLine("Đã thêm sinh viên thành công.");
                        }
                        else
                        {
                            Console.WriteLine("Lỗi đâu đó rồi, chưa thêm sinh viên không thành công.");
                        }
                       
                        break;
                    case 2: 
                        Student info = new Student();
                        
                        Console.Write("Nhập id sinh viên cần đổi: ");
                        Guid updatedStudentId = Guid.Parse(Console.ReadLine());
                        
                        Console.Write("Nhập tên sinh viên: ");
                        info.name = Console.ReadLine();
                        
                        Console.Write("Nhập giới tính sinh viên: (1: Man, 2: Woman, 3: Other): ");
                        info.sex = int.Parse(Console.ReadLine());
                        
                        Console.Write("Nhập tuổi sinh viên: ");
                        info.age = int.Parse(Console.ReadLine());
                        
                        Console.Write("Nhập điểm toán sinh viên: ");
                        info.mathScore = double.Parse(Console.ReadLine());
                        
                        Console.Write("Nhập điểm lý sinh viên: ");
                        info.physicsScore = double.Parse(Console.ReadLine());
                        
                        Console.Write("Nhập điểm hóa sinh viên: ");
                        info.chemistryScore = double.Parse(Console.ReadLine());


                        int flagUpdateStudent = studentManager.UpdateStudent(updatedStudentId, info);

                        if (flagUpdateStudent == 1)
                        {
                            Console.WriteLine("Đã thêm sinh viên thành công.");
                        }
                        else
                        {
                            Console.WriteLine("Lỗi đâu đó rồi, cập nhật sinh viên không thành công.");
                        }
                        break;
                    case 3: 
                        Console.Write("Nhập id sinh viên cần đổi: ");
                        Guid deletedStudentId = Guid.Parse(Console.ReadLine());
                        
                        int flagDeleteStudent = studentManager.DeleteStudent(deletedStudentId);
                        
                        if (flagDeleteStudent == 1)
                        {
                            Console.WriteLine("Đã xoá sinh viên thành công.");
                        }
                        else
                        {
                            Console.WriteLine("Lỗi đâu đó rồi, xoá sinh viên không thành công.");
                        }
                        break;
                    case 4: 
                        Console.Write("Nhập tên sinh viên cần xem: ");
                        string findedName = Console.ReadLine();
                        List<Student> findStudent = studentManager.FindStudent(findedName);
                        if (findStudent != null && findStudent.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên là:");
                            foreach (var st in findStudent)
                            {
                                Console.WriteLine("{0} - {1} - {2} - {3} - {4:F2} - {5}", st.id, st.name, st.sex, st.age, st.avgScore, st.academicPerformance());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách chưa có sinh viên nào.");
                        }
                        break;
                    case 5: 
                        List<Student> studentsByAvg = studentManager.SortByAverageScore(1);
                        if (studentsByAvg != null && studentsByAvg.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên là:");
                            foreach (Student st in studentsByAvg)
                            {
                                Console.WriteLine("{0} - {1} - {2} - {3} - {4:F2} - {5}", st.id, st.name, st.sex, st.age, st.avgScore, st.academicPerformance());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách chưa có sinh viên nào.");
                        }
                        break;;
                    case 6: 
                        List<Student> studentsByName = studentManager.SortByName(1);
                        if (studentsByName != null && studentsByName.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên là:");
                            foreach (Student st in studentsByName)
                            {
                                Console.WriteLine("{0} - {1} - {2} - {3} - {4:F2} - {5}", st.id, st.name, st.sex, st.age, st.avgScore, st.academicPerformance());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách chưa có sinh viên nào.");
                        }
                        break;
                    case 7: 
                        List<Student> studentsByID = studentManager.SortById(1);
                        if (studentsByID != null && studentsByID.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên là:");
                            foreach (var st in studentsByID)
                            {
                                Console.WriteLine("{0} - {1} - {2} - {3} - {4:F2} - {5}", st.id, st.name, st.sex, st.age, st.avgScore, st.academicPerformance());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách chưa có sinh viên nào.");
                        }
                        break;
                    case 8: 
                     
                        List<Student> students = studentManager.ShowStudents();
                        if (students != null && students.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên là:");
                            foreach (Student st in students)
                            {
                                Console.WriteLine("{0} - {1} - {2} - {3} - {4:F2} - {5}", st.id, st.name, st.sex, st.age, st.avgScore, st.academicPerformance());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách chưa có sinh viên nào.");
                        }
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Dịch vụ không tồn tại");
                        break;
                }
                
            } while (service != 9);
        }
    }
}