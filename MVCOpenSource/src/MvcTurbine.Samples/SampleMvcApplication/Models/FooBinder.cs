namespace SampleMvcApplication.Models
{
    using System.Web.Mvc;

    public class FooBinder : IModelBinder
    {
        public FooBinder(IModelValidator validator)
        {
            Validator = validator;
        }

        public IModelValidator Validator { get; set; }

        #region IModelBinder Members

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return Validator.IsValid(bindingContext.Model) ? new FooModel() : null;
        }

        #endregion
    }
}