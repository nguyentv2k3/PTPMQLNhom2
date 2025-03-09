namespace YourNamespace.Models
{
    public class BMIModel
    {
        public double Height { get; set; } // Chiều cao (m)
        public double Weight { get; set; } // Cân nặng (kg)

        // Tính chỉ số BMI
        public double BMI => (Height > 0) ? Weight / (Height * Height) : 0;

        // Đánh giá BMI
        public string BMICategory
        {
            get
            {
                if (BMI <= 0) return "Chưa có dữ liệu";
                if (BMI < 18.5) return "Gầy";
                if (BMI < 24.9) return "Bình thường";
                if (BMI < 29.9) return "Thừa cân";
                return "Béo phì";
            }
        }
    }
}
