using System.ComponentModel.DataAnnotations;

namespace Shoppy.Models
{
    public class Category
    {
        // создаем столбцы и первичный ключ Key
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public int DisplayOrder { get; set; }   
        
    }
}
