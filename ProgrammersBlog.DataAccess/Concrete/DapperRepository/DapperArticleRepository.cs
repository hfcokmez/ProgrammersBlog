using ProgrammersBlog.Core.DataAccess.Concrete;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Concrete.DapperRepository
{
    public class DapperArticleRepository : DapperEntityRepositoryBase<Article>, IArticleRepository
    {
    }
}
