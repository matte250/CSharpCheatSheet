using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstEfMvc.Models
{
    public class NorthwindInitilazier :
        DropCreateDatabaseAlways<NorthwindContext>
    {
        private void AddCategory(NorthwindContext context, string categoryName)
        {
            context.Categories.Add(
            new Category()
            {
                CategoryName = categoryName
            });
        }

        protected override void Seed(NorthwindContext context)
        {
            AddCategory(context, "Beverages");
            AddCategory(context, "Condiments");
            AddCategory(context, "Confections");
            AddCategory(context, "Dairy Products");
            AddCategory(context, "Grains/Cereals");
            AddCategory(context, "Meat/Poultry");
            AddCategory(context, "Produce");
            AddCategory(context, "Seafood");
        }
    }
}