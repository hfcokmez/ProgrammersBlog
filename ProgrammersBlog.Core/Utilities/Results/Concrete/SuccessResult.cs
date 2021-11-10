using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Concrete
{
    public class SuccessResult : ResultBase
    {
        public SuccessResult(string message) : base(success : true, message)
        {
        }
        public SuccessResult() : base(success: true)
        {
        }
    }
}
