using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFluentValidationSample
{
    using Nancy;
    using Nancy.ModelBinding;
    using Nancy.Validation; 

    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["home", new HomeModel()];

            Post["/"] = _ =>
            {
                var model = this.BindAndValidate<HomeModel>();
                if (!ModelValidationResult.IsValid)
                {
                    if (model.ErrorMessages == null)
                    {
                        model.ErrorMessages = new List<string>();
                    }
                    else
                    {
                        model.ErrorMessages.Clear();
                    }


                    foreach (var error in ModelValidationResult.Errors)
                    {
                        var msg = error.Key + " - " + error.Value.FirstOrDefault().ErrorMessage;
                        model.ErrorMessages.Add(msg);
                    }
                }

                return View["home", model];
            }; 
        }
    }
}
