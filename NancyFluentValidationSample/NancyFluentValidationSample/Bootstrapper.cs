
namespace NancyFluentValidationSample
{
    public class Bootstrapper : Nancy.DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            // View用ファイルが含まれるディレクトリとして、Viewsディレクトリを見るように追加
            this.Conventions.ViewLocationConventions.Add((viewName, model, context) =>
            {
                return string.Concat("bin/Views/", viewName);
            });

            // デバッグ用に、エラーがあった時はViewに表示する
            Nancy.StaticConfiguration.DisableErrorTraces = false;
        }
    }
}
