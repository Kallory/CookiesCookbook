using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients
{
    public abstract class Ingredient
    {
        private int _id {  get; set; }
        private string _name { get; set; }
        private string _instruction { get; set; }

        public Ingredient(int id, string name, string instruction) {
            _id = id;
            _name = name;
            _instruction = instruction;
        }
    }
}
