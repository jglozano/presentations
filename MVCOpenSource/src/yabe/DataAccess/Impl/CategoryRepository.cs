using System.Linq;
using Domain;
using NHibernate;
using NHibernate.Linq;

namespace DataAccess
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        #region ICategoryRepository Members

        public Category GetCategoryByName(string name)
        {
            using (ISession session = GetSession())
            {
                IQueryable<Category> result = from cat in session.Linq<Category>()
                                              where cat.Name == name
                                              select cat;

                return result.Distinct().SingleOrDefault();
            }
        }

        #endregion
    }
}