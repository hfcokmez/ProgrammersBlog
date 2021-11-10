using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResultBase<T>
    {
        public SuccessDataResult(T data, string message) : base(data, success : true, message)
        {
        }
        public SuccessDataResult(T data) : base(data, success : true)
        {
        }
        public SuccessDataResult(string message) : base(data: default, success: true, message)
        {
        }
        public SuccessDataResult() : base(data: default, success: true)
        {
        }
    }
}
