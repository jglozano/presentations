namespace SampleMvcApplication.Models
{
    public class FooValidator : IModelValidator
    {
        #region IModelValidator Members

        public bool IsValid<TModel>(TModel model)
        {
            return model is FooModel;
        }

        #endregion
    }
}