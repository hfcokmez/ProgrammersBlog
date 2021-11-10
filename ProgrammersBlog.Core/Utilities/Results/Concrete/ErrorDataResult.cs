using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResultBase<T>
    {
        public ErrorDataResult(T data, string message) : base(data, success : false, message)
        {
        }
        public ErrorDataResult(T data) : base(data, success : false)
        {
        }
        public ErrorDataResult(string message) : base(data : default, success : false, message)
        {
        }
        public ErrorDataResult() : base(data : default, success : false)
        {
        }
    }
}
