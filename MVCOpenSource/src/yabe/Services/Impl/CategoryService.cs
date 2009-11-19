namespace Services
{
    using System;
    using System.Collections.Generic;
    using Common;
    using DataAccess;
    using Domain;

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        #region ICategoryService Members

        public void Create(CategoryDTO category)
        {
            var entity = category.ToEntity();
            entity.CreatedDate = DateTime.Now;

            categoryRepository.Create(entity);
        }

        public void Update(CategoryDTO category)
        {
            var entity = category.ToEntity();
            categoryRepository.Update(entity);
        }

        public void Delete(CategoryDTO category)
        {
            var entity = category.ToEntity();
            categoryRepository.Delete(entity);
        }

        public IList<CategoryDTO> RetrieveAll()
        {
            IList<Category> categories = categoryRepository.RetrieveAll();
            var result = categories.ConvertAll(entity => entity.ToDTO());

            return new List<CategoryDTO>(result);
        }

        public CategoryDTO Retrieve(string name)
        {
            var entity = categoryRepository.GetCategoryByName(name);
            return entity.ToDTO();
        }

        #endregion
    }
}