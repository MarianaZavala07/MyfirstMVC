using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models
{
    public class DegreModel : BaseModel
    {
        public DegreModel()
        {
        }
        [Required]
        public string name { get; set; }
    }
}