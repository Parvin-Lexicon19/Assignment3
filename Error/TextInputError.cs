using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numeric only field. This fired and error!";

    }

}
