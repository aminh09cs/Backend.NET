using System;
namespace Unit6.StudentManagement
{
    public class Student
    {
       
            public Guid id { get; set; } = Guid.NewGuid();
            public string name { get; set; }
            public int sex { get; set; }
            public int age { get; set; }
            public double mathScore { get; set; }
            public double physicsScore { get; set; }
            public double chemistryScore { get; set; }
            public double avgScore => (mathScore + physicsScore + chemistryScore) / 3;

            public string academicPerformance()
            {
                return avgScore >= 8 ? "Giỏi" 
                                    : avgScore >= 6.5 ? "Khá" 
                                    : avgScore >= 5 ? "Trung Bình" 
                                    : "Yếu";
            }
        }
    
}