using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Output
    {


        private string printContent()
        {
            String result = "Rental Record for " + this.getName() + "\n";
            result += "\t" + "Title" + "\t" + "\t" + "Days" + "\t" + "Amount" + "\n";
            return result;
        }


    }
}
