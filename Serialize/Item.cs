using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    /// <summary>
    /// 自訂 ComboBox Item 物件
    /// </summary>
    class Item
    {
        /// <summary>
        /// 
        /// </summary>
        private string _text;

        /// <summary>
        /// 
        /// </summary>
        private string _value;

        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
        }

        public Item(string text, string value)
	    { 
	        _text = text;
            _value = value; 
	    }



        public override string ToString()
	    { 
	        return _text; 
	    } 

    }
}
