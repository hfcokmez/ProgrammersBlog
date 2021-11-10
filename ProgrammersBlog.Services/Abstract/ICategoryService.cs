using ProgrammersBlog.Core.Utilities.Results.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> Get(int categoryId);
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAllByNonDeleted();
        IDataResult<List<Category>> GetAllByNonDeletedAndActive();
        IResult Add(CategoryAddDto categoryAddDto, string createdByName);
        IResult Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        IResult Delete(int categoryId, string modifiedByName);
        IResult HardDelete(int categoryId);
    }
}
