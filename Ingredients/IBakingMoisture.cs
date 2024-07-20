using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies_Cookbook.Ingredients {
    public interface IBakingMoisture { 

        DateTime dateTime { get;}

        DateTime TimeToLetSit(int minutes);
    }
}
