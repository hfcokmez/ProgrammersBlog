using ProgrammersBlog.Core.Entities.Abstract;
using ProgrammersBlog.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.DataAccess.Abstract
{
    public interface IEntityRepositoryBase<T>
        where T : class, IEntity, new()
    {
        T Get(dynamic param, string sProcedure);
        int GetCount(dynamic param, string propertyName, string sProcedure);
        IList<T> GetList(string sProcedure);
        IList<T> GetList(dynamic param, string sProcedure);
        bool Add(T entity, string sProcedure);
        bool Delete(dynamic param, string sProcedure);
        bool DeleteList(IList<int> entityList, string sProcedure);
        bool Update(T entity, string sProcedure);
    }
}
