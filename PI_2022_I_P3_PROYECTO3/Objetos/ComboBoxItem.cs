using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class ComboBoxItem
    {

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text; 
        }
        public ComboBoxItem(string pText, object pValue) 
        { 
        Text        =pText;
        Value       =pValue;
        }
    }
}
