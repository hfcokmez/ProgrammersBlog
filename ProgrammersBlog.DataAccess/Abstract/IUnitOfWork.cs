using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
    }
}
