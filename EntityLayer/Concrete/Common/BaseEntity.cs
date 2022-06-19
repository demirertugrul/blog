using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete.Common
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public bool Status { get; set; }
    }
}
