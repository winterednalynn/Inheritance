using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sea : Vehicle
    {
        // FIELDS ✅ 
        //string type; // As in boat or submarine. Extra credit for making it an enumerator✅ 
        public enum typeOfseamobile { boat, submarine };
        typeOfseamobile _seamobile;

        // CONSTRUCTOR ✅ 

        public Sea(string color, typeOfseamobile _seamobile) : base(color) 
        {
            this._seamobile = _seamobile; 
        }

 
        //OVERRIDE ✅ 
        public override string ToString()
        {
            return base.ToString() + $"- it is a {_seamobile}"; 
        }

        
        

    }
}
