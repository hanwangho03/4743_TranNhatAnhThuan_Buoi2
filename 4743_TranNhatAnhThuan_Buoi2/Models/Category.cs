using System.ComponentModel.DataAnnotations;

namespace _4743_TranNhatAnhThuan_Buoi2.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
