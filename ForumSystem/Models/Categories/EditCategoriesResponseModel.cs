namespace ForumSystem.Models.Categories
{
    using System;
    using AutoMapper;
    using ForumSystem.Infrastructure.Mapping;

    public class EditCategoriesResponseModel : IMapFrom<Category>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Visibility Visibility { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<Category, EditCategoriesResponseModel>();
        }
    }
}