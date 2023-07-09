using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AblastFromThePast
{
    public class CustomButtonClass
    {
        public Button field { get; set; }
        public int value { get; set; }

        public CustomButtonClass(Button myProperty, int value)
        {
            field = myProperty;
            this.value = value;
        }
    }
}
