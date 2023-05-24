using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Helpers;
using NewsSiteTurnDigital.Infrastructure.Repositories.Categories;
using NewsSiteTurnDigital.Infrastructure.Repositories.News;

namespace NewsSiteTurnDigital.WEB.Services
{
    public class CategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IUnitOfWork unitOfWork
        , ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }
        public async Task<NewsCategory> AddCategoryAsync(NewsCategory newsCategory)
        {
            var newCategory = _categoryRepository.AddCategory(newsCategory);
            await _unitOfWork.CommitAsync();
            return newCategory;
        }
        public async Task<List<NewsCategory>> GetAllNewsCategory()
        {
            var NewsCategories = await _categoryRepository.GetAllNewsCategory();
            return NewsCategories;
        }
        public async Task<NewsCategory> GetCategoryById(int id)
        {
            var NewsCategory = await _categoryRepository.GetById(id);
            return NewsCategory;
        }

    }
}
