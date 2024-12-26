using System.ComponentModel.DataAnnotations;

namespace SolevogueBackend.Models
{
    public class ShippingAddress
    {
public int Id { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(6, ErrorMessage = "Full name must not exceed 25 characters")]
        public string FullName { get; set; }


        [Required(ErrorMessage = "Address is required")]

        [MaxLength(70, ErrorMessage = "Address cannot exceed more than 70 characters!")]
        public string Address { get; set; }



        [Required(ErrorMessage = "District is required")]

        [MaxLength(20, ErrorMessage = "District must not exceed more than 20 characters")]
        public string District { get; set; }




        [Required(ErrorMessage = "State is required")]

        [MaxLength(20, ErrorMessage = "State must not exceed more than 20 characters")]
        public string State { get; set; }


        [MaxLength(50, ErrorMessage = " LandMark must not exceed more than 50 characters")]
        public string? LandMark { get; set; }

    }
}
