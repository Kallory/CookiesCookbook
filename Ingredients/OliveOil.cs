﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    internal class OliveOil : CookingOil, IBakingMoisture {
        public OliveOil(int id, string name, string instruction) : base(id, name, instruction) {
        }

        public DateTime dateTime => throw new NotImplementedException();

        public DateTime TimeToLetSit(int minutes) {
            throw new NotImplementedException();
        }
    }
}
