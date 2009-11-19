namespace Services
{
    using System;
    using System.Collections.Generic;
    using Common;
    using DataAccess;

    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;
        private ICommentRepository commentRepository;
        private readonly ICategoryRepository categoryRepository;

        public PostService(IPostRepository postRepository,
            ICommentRepository commentRepository,
            ICategoryRepository categoryRepository)
        {
            this.postRepository = postRepository;
            this.commentRepository = commentRepository;
            this.categoryRepository = categoryRepository;
        }

        #region IPostService Members

        public void Create(PostDTO post)
        {
            var entity = post.ToEntity();
            entity.PostedDate = DateTime.Now;

            post.Categories.ForEach(dto =>
            {
                var category = categoryRepository.Retrieve(dto.Id);
                entity.AddCategory(category);
            });

            postRepository.Create(entity);
        }

        public void Update(PostDTO post)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostDTO post)
        {
            throw new NotImplementedException();
        }

        public IList<PostDTO> RetrieveYearlyPosts(PostDateDTO dateDto)
        {
            throw new NotImplementedException();
        }

        public IList<PostDTO> RetrieveMonthlyPosts(PostDateDTO dateDto)
        {
            throw new NotImplementedException();
        }

        public IList<PostDTO> RetrieveDailyPosts(PostDateDTO dateDto)
        {
            throw new NotImplementedException();
        }

        public IList<PostDTO> RetrieveAll()
        {
            var postList = postRepository.RetrieveAll();
            var entityList = postList.ConvertAll(entity => entity.ToDTO());

            return new List<PostDTO>(entityList);
        }

        #endregion
    }
}