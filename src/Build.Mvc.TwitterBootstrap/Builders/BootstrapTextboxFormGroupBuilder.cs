using System.Web.Mvc;

namespace Build.Mvc.TwitterBootstrap
{
    public class BootstrapTextboxFormGroupBuilder : BootstrapFormGroupBuilder<TextBoxFormGroupConfig>
    {
        public BootstrapTextboxFormGroupBuilder(HtmlHelper htmlHelper, TextBoxFormGroupConfig config) : base(htmlHelper, config)
        {
        }
    }

    public class BootstrapTextboxFormGroupBuilder<TModel, TProperty> : BootstrapFormGroupBuilder<TextBoxFormGroupConfig<TModel, TProperty>>
    {
        public BootstrapTextboxFormGroupBuilder(HtmlHelper htmlHelper, TextBoxFormGroupConfig<TModel, TProperty> config) : base(htmlHelper, config)
        {
        }
    }
}