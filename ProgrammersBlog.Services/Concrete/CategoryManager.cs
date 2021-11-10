using AutoMapper;
using ProgrammersBlog.Core.Utilities.Contents;
using ProgrammersBlog.Core.Utilities.Messages;
using ProgrammersBlog.Core.Utilities.Results.Abstract;
using ProgrammersBlog.Core.Utilities.Results.Concrete;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammersBlog.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public IResult Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            Category category = _mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.CreatedDate = DateTime.Now;
            bool result = _unitOfWork.Categories.Add(category, StoredProcedures.AddCategory);
            if (result) return new SuccessResult(Messages.CategoryAddSuccess);
            else return new ErrorResult(Messages.CategoryAddFail);
        }

        public IResult Delete(int categoryId, string modifiedByName)
        {
            Category category = _unitOfWork.Categories.Get(new { Id = categoryId }, StoredProcedures.GetCategoryById);
            category.IsDeleted = true;
            category.ModifiedByName = modifiedByName;
            bool result = _unitOfWork.Categories.Update(category, StoredProcedures.UpdateCategory);
            if (result) return new SuccessResult(Messages.CategoryDeleteSuccess);
            else return new ErrorResult(Messages.CategoryDeleteFail);
        }

        public IDataResult<Category> Get(int categoryId)
        {
            Category category = _unitOfWork.Categories.Get(new { Id = categoryId }, StoredProcedures.GetCategoryById);
            if (category != null) return new SuccessDataResult<Category>(category);
            else return new ErrorDataResult<Category>(Messages.CategoryGetFail);
        }

        public IDataResult<List<Category>> GetAll()
        {
            List<Category> categories = _unitOfWork.Categories.GetList(StoredProcedures.GetAllCategories).ToList();
            if (categories.Count > 0) return new SuccessDataResult<List<Category>>(categories);
            else return new ErrorDataResult<List<Category>>(Messages.CategoryGetFail);
        }

        public IDataResult<List<Category>> GetAllByNonDeleted()
        {
            List<Category> categories = _unitOfWork.Categories.GetList(StoredProcedures.GetAllNonDeletedCategories).ToList();
            if (categories.Count > 0) return new SuccessDataResult<List<Category>>(categories);
            else return new ErrorDataResult<List<Category>>(Messages.CategoryGetFail);
        }

        public IDataResult<List<Category>> GetAllByNonDeletedAndActive()
        {
            List<Category> categories = _unitOfWork.Categories.GetList(StoredProcedures.GetAllNonDeletedAndActiveCategories).ToList();
            if (categories.Count > 0) return new SuccessDataResult<List<Category>>(categories);
            else return new ErrorDataResult<List<Category>>(Messages.CategoryGetFail);
        }

        public IResult HardDelete(int categoryId)
        {
            bool result = _unitOfWork.Categories.Delete(new { Id = categoryId }, StoredProcedures.DeleteCategory);
            if (result) return new SuccessResult(Messages.CategoryDeleteSuccess);
            else return new ErrorResult(Messages.CategoryDeleteFail);
        }

        public IResult Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            Category category = _mapper.Map<Category>(categoryUpdateDto);
            bool result = _unitOfWork.Categories.Update(category, StoredProcedures.UpdateCategory);
            if (result) return new SuccessResult(Messages.CategoryUpdateSuccess);
            else return new ErrorResult(Messages.CategoryUpdateFail);
        }
    }
}
