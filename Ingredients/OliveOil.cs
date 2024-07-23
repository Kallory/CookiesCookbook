using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    internal class OliveOil : CookingOil, IBakingMoisture {
        public OliveOil(int id, string name, string instruction) : base(id, name, instruction) {
        }

        public int minutesToLetSit { get; set; }

        public void TimeToLetSit(int minutes) {
            this.minutesToLetSit = minutes;
        }
    }
}
