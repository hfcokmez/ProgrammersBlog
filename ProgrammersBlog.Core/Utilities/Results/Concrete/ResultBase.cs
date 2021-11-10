using ProgrammersBlog.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Concrete
{
    public class ResultBase : IResult
    {
        public ResultBase(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        public ResultBase(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
