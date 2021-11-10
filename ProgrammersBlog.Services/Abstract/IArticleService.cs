using System;
using System.Collections.Generic;
using System.Text;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Core.Utilities.Results.Abstract;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IArticleService
    {
        IDataResult<List<Article>> GetAll();
        IDataResult<List<Article>> GetAllByNonDeleted();
        IDataResult<List<Article>> GetAllByNonDeletedAndActive();
        IDataResult<List<Article>> GetAllByCategory(int categoryId);
        IDataResult<Article> Get(int id);
        IResult Add(ArticleAddDto articleAddDto, string createdByName);
        IResult Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        IResult Delete(int articleId, string modifiedByName);
        IResult HardDelete(int articleId);
    }
}
