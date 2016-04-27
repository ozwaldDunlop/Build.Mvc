using System.Web.Mvc;
using System.Web.UI;
using Build.Mvc.TwitterBootstrap.Helpers;

namespace Build.Mvc.TwitterBootstrap
{
    public class BootstrapCheckBoxFormGroupBuilder : BootstrapFormGroupBuilder<CheckBoxFormGroupConfig>
    {
        public BootstrapCheckBoxFormGroupBuilder(HtmlHelper htmlHelper, CheckBoxFormGroupConfig config)
            : base(htmlHelper, config)
        {
        }

        protected override void RenderFormGroupContents(HtmlTextWriter writer, FormGroupDisplay display)
        {
            CheckBoxGroupHelper.Render(writer, Config);
        }
    }

    public class BootstrapCheckBoxFormGroupBuilder<TModel> : BootstrapFormGroupBuilder<CheckBoxFormGroupConfig<TModel>>
    {
        public BootstrapCheckBoxFormGroupBuilder(HtmlHelper htmlHelper, CheckBoxFormGroupConfig<TModel> config)
            : base(htmlHelper, config)
        {
        }

        protected override void RenderFormGroupContents(HtmlTextWriter writer, FormGroupDisplay display)
        {
            CheckBoxGroupHelper.Render(writer, Config);
        }
    }
}