﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    internal class AppleSauce : Ingredient, IBakingMoisture {
        public AppleSauce(int id, string name, string instruction) : base(id, name, instruction) {
        }

        private DateTime _minutesToLetSit;

        public DateTime minutesToLetSit {
            get => _minutesToLetSit;
            set => _minutesToLetSit = value;
        }

        public void TimeToLetSit(int minutes) {
            this.minutesToLetSit = this.minutesToLetSit.AddMinutes(minutes);
            //return dateTime;
        }
    }
}
