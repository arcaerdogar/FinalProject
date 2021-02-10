using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SucessResult : Result
    {
        public SucessResult(string message) : base(true, message)
        {

        }
        public SucessResult(): base(true)
        {

        }
    }
}
