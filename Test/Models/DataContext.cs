using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class CategoryInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<CategoryModel> categories = new List<CategoryModel>
            {
                new CategoryModel { Name = "Cars"},
                new CategoryModel { Name = "Phones"},
                new CategoryModel { Name = "Watches"}
            };
            foreach (CategoryModel category in categories)
            {
                context.CategoryModels.Add(category);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }

    public class DataContext : DbContext
    {
        public DataContext(): base("DataContext")
        {
            Database.SetInitializer<DataContext>(new CategoryInitializer());
        }

        public DbSet<CategoryModel> CategoryModels { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
    }
}