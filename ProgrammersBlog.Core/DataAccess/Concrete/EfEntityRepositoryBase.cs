using ProgrammersBlog.Core.DataAccess.Abstract;
using ProgrammersBlog.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<T> : IEntityRepositoryBase<T>
        where T : class, IEntity, new()
    {
        public bool Add(T entity, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public bool Delete(dynamic param, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public bool DeleteList(IList<int> entityList, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public T Get(dynamic param, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public int GetCount(dynamic param, string propertyName, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetList(string sProcedure)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetList(dynamic param, string sProcedure)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity, string sProcedure)
        {
            throw new NotImplementedException();
        }
    }
}
