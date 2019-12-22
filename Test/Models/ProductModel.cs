using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class ProductModel
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [StringLength(1000,ErrorMessage = "Поле Description должно быть не длиннее 100 символов")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Выберите категорию")]
        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; }

    }
}