﻿using ProgrammersBlog.Core.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Abstract
{
    public interface IArticleRepository : IEntityRepositoryBase<Article>
    {
    }
}
