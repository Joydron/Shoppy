using System.ComponentModel.DataAnnotations;

namespace Shoppy.Models
{
    public class ApplicationType
    {
        // создаем столбцы и первичный ключ Key
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }    
        
    }
}
