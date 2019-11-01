using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired and error!";
    }
}
