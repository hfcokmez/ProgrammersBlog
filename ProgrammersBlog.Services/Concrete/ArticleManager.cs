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
    public class ArticleManager : IArticleService
    {
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        public ArticleManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public IResult Add(ArticleAddDto articleAddDto, string createdByName)
        {
            Article article = _mapper.Map<Article>(articleAddDto);
            article.CreatedByName = createdByName;
            article.ModifiedByName = createdByName;
            bool result = _unitOfWork.Articles.Add(article, StoredProcedures.AddArticle);
            if (result) return new SuccessResult(Messages.ArticleAddSuccess);
            else return new ErrorResult(Messages.ArticleAddFail);
        }

        public IResult Delete(int articleId, string modifiedByName)
        {
            Article article = _unitOfWork.Articles.Get(articleId, StoredProcedures.GetArticleById);
            if(article != null)
            {
                article.IsDeleted = true;
                article.ModifiedByName = modifiedByName;
                article.ModifiedDate = DateTime.Now;
                bool result = _unitOfWork.Articles.Update(article, StoredProcedures.UpdateArticle);
                if (result) return new SuccessResult(Messages.ArticleDeleteSuccess);
                else return new ErrorResult(Messages.ArticleDeleteFail);
            }
            else return new ErrorResult(Messages.ArticleDeleteFail);
            
        }

        public IDataResult<Article> Get(int id)
        {
            Article article = _unitOfWork.Articles.Get(new { Id = id }, StoredProcedures.GetArticleById);
            if (article != null) return new SuccessDataResult<Article>(article);
            else return new ErrorDataResult<Article>(Messages.GetArticleFail);
        }

        public IDataResult<List<Article>> GetAll()
        {
            List<Article> articles = _unitOfWork.Articles.GetList(StoredProcedures.GetAllArticles).ToList();
            if (articles.Count > 0) return new SuccessDataResult<List<Article>>(articles);
            else return new ErrorDataResult<List<Article>>(Messages.GetArticleFail);
        }

        public IDataResult<List<Article>> GetAllByCategory(int categoryId)
        {
            List<Article> articles = _unitOfWork.Articles.GetList(StoredProcedures.GetAllArticles).ToList();
            if (articles.Count > 0) return new SuccessDataResult<List<Article>>(articles);
            else return new ErrorDataResult<List<Article>>(Messages.GetArticleFail);
        }

        public IDataResult<List<Article>> GetAllByNonDeleted()
        {
            List<Article> articles = _unitOfWork.Articles.GetList(StoredProcedures.GetAllNonDeletedArticles).ToList();
            if (articles.Count > 0) return new SuccessDataResult<List<Article>>(articles);
            else return new ErrorDataResult<List<Article>>(Messages.GetArticleFail);
        }

        public IDataResult<List<Article>> GetAllByNonDeletedAndActive()
        {
            List<Article> articles = _unitOfWork.Articles.GetList(StoredProcedures.GetAllNonDeletedAndActiveCategories).ToList();
            if (articles.Count > 0) return new SuccessDataResult<List<Article>>(articles);
            else return new ErrorDataResult<List<Article>>(Messages.GetArticleFail);
        }

        public IResult HardDelete(int articleId)
        {
            bool result = _unitOfWork.Articles.Delete(new { Id = articleId}, StoredProcedures.DeleteArticle);
            if (result) return new SuccessResult(Messages.ArticleDeleteSuccess);
            else return new ErrorResult(Messages.ArticleDeleteFail);
        }

        public IResult Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            Article article = _mapper.Map<Article>(articleUpdateDto);
            article.ModifiedByName = modifiedByName;
            article.ModifiedDate = DateTime.Now;
            var result = _unitOfWork.Articles.Update(article, StoredProcedures.UpdateArticle);
            if (result) return new SuccessResult(Messages.ArticleUpdateSuccess);
            else return new ErrorResult(Messages.ArticleUpdateFail);
        }
    }
}
