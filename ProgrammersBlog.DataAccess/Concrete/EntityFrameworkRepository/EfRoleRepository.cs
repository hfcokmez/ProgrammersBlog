using ProgrammersBlog.Core.DataAccess.Concrete;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Concrete.EntityFrameworkRepository
{
    public class EfRoleRepository : EfEntityRepositoryBase<Role>, IRoleRepository
    {
    }
}
