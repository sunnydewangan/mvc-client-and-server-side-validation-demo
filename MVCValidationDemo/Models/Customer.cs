using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Models
{
    public sealed class Customer
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer code is required")]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$", ErrorMessage = "Invalid Customer Code")]  //ABC1234
        public string CustomerCode { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer name is required")]
        public string CustomerName { get; set; }
    }
}