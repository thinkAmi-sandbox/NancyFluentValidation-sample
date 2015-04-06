using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFluentValidationSample
{
    using FluentValidation;
    public class HomeValidator : FluentValidation.AbstractValidator<HomeModel>
    {
        public HomeValidator()
        {
            // Emptyでないか
            RuleFor(model => model.Text).NotEmpty();

            // Emptyでないか & 自作のメッセージを表示
            RuleFor(model => model.Tel).NotEmpty().WithMessage("Required!!");

            // 入力必須、かつ、文字長が1-10文字
            RuleFor(model => model.TextArea)
            .NotEmpty()
            .Length(1, 10);

            // 正規表現にマッチしているか
            RuleFor(model => model.Url).Matches(@"^http://");

            // メールアドレスの形式にマッチしているか
            RuleFor(model => model.Email).EmailAddress();

            // 日付の大小関係は正しいか
            RuleFor(model => model.DateFrom).GreaterThan(DateTime.Parse("2015/01/01"));

            // 日付の大小関係を確認し、独自エラーメッセージ中に、Modelのプロパティ値を参照して表示
            RuleFor(model => model.DateTo).LessThan(DateTime.Parse("2015/02/01"))
            .WithMessage("{0} is not less than '2015/2/1'", model => model.DateTo);

            // 2つの日付間の大小関係は正しいか
            RuleFor(model => model.DateFrom).LessThanOrEqualTo(model => model.DateTo);
        }
    } 
}
