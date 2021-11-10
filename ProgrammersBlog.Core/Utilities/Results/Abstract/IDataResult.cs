using ProgrammersBlog.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> 
    {
        T Data { get; }
    }
}
