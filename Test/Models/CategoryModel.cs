using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class CategoryModel
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, StringLength(100,ErrorMessage ="Поле Name должно быть не длиннее 100 символов")]
        public string Name { get; set; }

        public ICollection<ProductModel> Products { get; set; }
        public CategoryModel()
        {
            Products = new List<ProductModel>();
        }
    }
}