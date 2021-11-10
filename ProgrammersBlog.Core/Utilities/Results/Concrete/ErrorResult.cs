using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Concrete
{
    public class ErrorResult : ResultBase
    {
        public ErrorResult(string message) : base(success : false, message)
        {
        }
        public ErrorResult() : base(success : false)
        {
        }
    }
}
