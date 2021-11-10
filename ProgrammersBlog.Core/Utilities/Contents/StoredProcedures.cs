using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Core.Utilities.Contents
{
    public class StoredProcedures
    {
        //Article SP's:
        public static string AddArticle = "AddArticle";
        public static string DeleteArticle = "DeleteArticle";
        public static string UpdateArticle = "UpdateArticle";
        public static string GetArticleById = "GetArticleById";
        public static string GetAllArticles = "GetAllArticles";
        public static string GetAllNonDeletedArticles = "GetAllNonDeletedArticles";
        public static string GetAllArticlesByCategory = "GetAllArticlesByCategory";
        //Category SP's:
        public static string AddCategory = "AddCategory";
        public static string DeleteCategory = "DeleteCategory";
        public static string UpdateCategory = "UpdateCategory";
        public static string GetCategoryById = "GetCategoryById";
        public static string GetAllCategories = "GetAllCategories";
        public static string GetAllNonDeletedCategories = "GetAllNonDeletedCategories";
        public static string GetAllNonDeletedAndActiveCategories = "GetAllNonDeletedAndActiveCategories";
    }
}
