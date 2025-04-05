using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Customer : Person 
    {
        [Display(Name = "Mã khách hàng")]
        [Required(ErrorMessage = "Mã khách hàng không hợp lệ")]
        public string? CustomerID { get; set; }
        
    }
}