using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen rol adı giriniz")]
        public string Name { get; set; }
    }
}
