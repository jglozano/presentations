namespace Services
{    
    using System.Collections.Generic;

    public interface ICategoryService
    {
        void Create(CategoryDTO category);
        void Update(CategoryDTO category);
        void Delete(CategoryDTO category);

        IList<CategoryDTO> RetrieveAll();
        CategoryDTO Retrieve(string name);
    }
}