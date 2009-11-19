using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using NHibernate;
using NHibernate.Linq;

namespace DataAccess
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        #region IPostRepository Members

        public IList<Post> GetPostsByYear(int year)
        {
            var date = new DateTime(year, 1, 1);
            return GetPostsByDate(date);
        }

        public IList<Post> GetPostsByMonth(int year, int month)
        {
            var date = new DateTime(year, month, 1);
            return GetPostsByDate(date);
        }

        public IList<Post> GetPostsByDay(int year, int month, int day)
        {
            var date = new DateTime(year, month, day);
            return GetPostsByDate(date);
        }

        public Post GetPostByTitle(string title)
        {
            using (ISession session = GetSession())
            {
                IQueryable<Post> result = from post in session.Linq<Post>()
                                          where post.Title == title
                                          select post;

                return result.Distinct().SingleOrDefault();
            }
        }

        #endregion

        private IList<Post> GetPostsByDate(DateTime date)
        {
            using (ISession session = GetSession())
            {
                IQueryable<Post> result = from post in session.Linq<Post>()
                                          where post.PostedDate >= date
                                          select post;

                return result.ToList();
            }
        }
    }
}