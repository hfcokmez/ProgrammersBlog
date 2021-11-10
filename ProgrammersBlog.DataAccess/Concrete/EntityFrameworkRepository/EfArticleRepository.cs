using ProgrammersBlog.Core.DataAccess.Abstract;
using ProgrammersBlog.Core.DataAccess.Concrete;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Concrete.EntityFrameworkRepository
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
    }
}
