namespace FirstWebMVC.Models
{
    public class GradeModel
    {
        public double A { get; set; } // Điểm thành phần A
        public double B { get; set; } // Điểm thành phần B
        public double C { get; set; } // Điểm thành phần C
        
        // Tính điểm tổng kết theo công thức (có thể thay đổi nếu cần)
        public double FinalScore => (A * 0.6) + (B * 0.3) + (C * 0.1);
    }
}
