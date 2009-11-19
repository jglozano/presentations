namespace Services
{
    using System.Collections.Generic;

    public interface IPostService
    {
        void Create(PostDTO post);
        void Update(PostDTO post);
        void Delete(PostDTO post);

        IList<PostDTO> RetrieveYearlyPosts(PostDateDTO dateDto);
        IList<PostDTO> RetrieveMonthlyPosts(PostDateDTO dateDto);
        IList<PostDTO> RetrieveDailyPosts(PostDateDTO dateDto);
        IList<PostDTO> RetrieveAll();
    }
}
