namespace SampleMvcApplication.Filters
{
    using Services;

    public abstract class BaseFilter
    {
        protected BaseFilter(IMessageService service)
        {
            MessageService = service;
        }

        public IMessageService MessageService { get; private set; }

        public string GetFilterMessage()
        {
            return string.Format("Default message: '{0}' from filter '{1}'",
                MessageService.GetDefaultMessage(), GetType().Name);
        }
    }
}