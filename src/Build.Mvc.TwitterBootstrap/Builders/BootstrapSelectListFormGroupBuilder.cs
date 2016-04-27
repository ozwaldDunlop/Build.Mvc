using System.Web.Mvc;

namespace Build.Mvc.TwitterBootstrap
{
    public class BootstrapSelectListFormGroupBuilder : BootstrapFormGroupBuilder<SelectListFormGroupConfig>
    {
        public BootstrapSelectListFormGroupBuilder(HtmlHelper htmlHelper, SelectListFormGroupConfig config)
            : base(htmlHelper, config)
        {
        }
    }

    public class BootstrapSelectListFormGroupBuilder<TModel, TProperty> : BootstrapFormGroupBuilder<SelectListFormGroupConfig<TModel, TProperty>>
    {
        public BootstrapSelectListFormGroupBuilder(HtmlHelper htmlHelper, SelectListFormGroupConfig<TModel, TProperty> config)
            : base(htmlHelper, config)
        {
        }
    }
}