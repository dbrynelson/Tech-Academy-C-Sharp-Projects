using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesDrill
{
    class NewUser
    {
        public NewUser(string name) : this(name, 100)
        {

        }
        public NewUser(string name, int newAmount)
        {
            Name = name;
            SignUpPromo = newAmount;
            
      
        }
        public string Name { get; set; }
        public int SignUpPromo { get; set; }

    }
}
