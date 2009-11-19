namespace SampleMvcApplication.Models
{
    public interface IModelValidator
    {
        bool IsValid<TModel>(TModel model);
    }
}