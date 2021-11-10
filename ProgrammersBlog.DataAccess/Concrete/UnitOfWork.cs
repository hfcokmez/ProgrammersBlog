using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.DataAccess.Concrete.DapperRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private DapperArticleRepository _dapperArticleRepository;
        private DapperCategoryRepository _dapperCategoryRepository;
        private DapperCommentRepository _dapperCommentRepository;
        private DapperRoleRepository _dapperRoleRepository;
        private DapperUserRepository _dapperUserRepository;
        public IArticleRepository Articles => _dapperArticleRepository ?? new DapperArticleRepository();

        public ICategoryRepository Categories => _dapperCategoryRepository ?? new DapperCategoryRepository();

        public ICommentRepository Comments => _dapperCommentRepository ?? new DapperCommentRepository();

        public IRoleRepository Roles => _dapperRoleRepository ?? new DapperRoleRepository();

        public IUserRepository Users => _dapperUserRepository ?? new DapperUserRepository();
    }
}
