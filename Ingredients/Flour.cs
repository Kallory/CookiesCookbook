using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    public abstract class Flour : Ingredient {
        public Flour(int id, string name, string instruction) : base(id, name, instruction) {

        }
    }
}
