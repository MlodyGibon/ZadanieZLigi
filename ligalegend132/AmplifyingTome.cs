using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
   
    public class AmplifyingTome : Item
    {
        
        public AmplifyingTome()
        {
           
            name = "Amplifying Tome";
            
            price = 435;
            
            AddStat(Stat.AP, 20);
        }
    }
}
