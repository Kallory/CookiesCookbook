using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    
    internal class Recipe {
        public List<Ingredient> ingredients { get; set; }

        public Recipe() {
            this.ingredients = new List<Ingredient>();
        }
    }
}
