using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients
{
    public abstract class Ingredient
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }

        public Ingredient(int id, string name, string instruction) {
            this.id = id;
            this.Name = name;
            this.Instruction = instruction;
        }

        public override string ToString() {
            return $"";
        }

        
    }
}
