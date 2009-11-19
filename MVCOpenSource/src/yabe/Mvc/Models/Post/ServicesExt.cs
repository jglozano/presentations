namespace Mvc.Models.Post
{
    using AutoMapper;
    using Category;
    using Services;

    internal static class ServicesExt
    {
        static ServicesExt()
        {
            Mapper.CreateMap<PostViewModel, PostDTO>();
            Mapper.CreateMap<CommentViewModel, CommentDTO>();
            Mapper.CreateMap<CategoryViewModel, CategoryDTO>();

            Mapper.CreateMap<CategoryDTO, CategoryViewModel>();
            Mapper.CreateMap<CommentDTO, CommentViewModel>();
            Mapper.CreateMap<PostDTO, PostViewModel>();
        }

        public static PostDTO ToDTO(this PostViewModel model)
        {
            return Mapper.Map<PostViewModel, PostDTO>(model);
        }

        public static PostViewModel ToViewModel(this PostDTO dto)
        {
            return Mapper.Map<PostDTO, PostViewModel>(dto);
        }

        public static CategoryDTO ToDTO(this CategoryViewModel model)
        {
            return Mapper.Map<CategoryViewModel, CategoryDTO>(model);
        }

        public static CategoryViewModel ToViewModel(this CategoryDTO dto)
        {
            return Mapper.Map<CategoryDTO, CategoryViewModel>(dto);
        }

        public static CommentDTO ToDTO(this CommentViewModel model)
        {
            return Mapper.Map<CommentViewModel, CommentDTO>(model);
        }

        public static CommentViewModel ToViewModel(this CommentDTO dto)
        {
            return Mapper.Map<CommentDTO, CommentViewModel>(dto);
        }
    }
}