namespace Services
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Common;
    using Domain;

    internal static class RepositoryExt
    {
        static RepositoryExt()
        {
            Mapper.CreateMap<Post, PostDTO>();
            Mapper.CreateMap<Category, CategoryDTO>();
            Mapper.CreateMap<Comment, CommentDTO>();

            Mapper.CreateMap<PostDTO, Post>()
                .ForMember(dest => dest.Categories, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore());

            Mapper.CreateMap<CategoryDTO, Category>();
            Mapper.CreateMap<CommentDTO, Comment>();
        }

        public static Post ToEntity(this PostDTO dto)
        {
            return Mapper.Map<PostDTO, Post>(dto);
        }

        public static PostDTO ToDTO(this Post entity)
        {
            var post = Mapper.Map<Post, PostDTO>(entity);            
            return post;
        }

        public static Category ToEntity(this CategoryDTO dto)
        {
            return Mapper.Map<CategoryDTO, Category>(dto);
        }

        public static CategoryDTO ToDTO(this Category entity)
        {
            return Mapper.Map<Category, CategoryDTO>(entity);
        }

        public static Comment ToEntity(this CommentDTO dto)
        {
            return Mapper.Map<CommentDTO, Comment>(dto);
        }

        public static CommentDTO ToDTO(this Comment entity)
        {
            return Mapper.Map<Comment, CommentDTO>(entity);
        }
    }
}