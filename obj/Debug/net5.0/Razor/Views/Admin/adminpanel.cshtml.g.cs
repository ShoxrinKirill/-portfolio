#pragma checksum "/home/kirill/app/c#/-portfolio/Views/Admin/adminpanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6149582864a287062e28ba194c00b3601181afd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_portfolio.Views.Admin.Views_Admin_adminpanel), @"mvc.1.0.view", @"/Views/Admin/adminpanel.cshtml")]
namespace _portfolio.Views.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/kirill/app/c#/-portfolio/Views/_ViewImports.cshtml"
using _portfolio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6149582864a287062e28ba194c00b3601181afd", @"/Views/Admin/adminpanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde1aff4240cc6519df78baffce56d0d40ba4b68", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_adminpanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/kirill/app/c#/-portfolio/Views/Admin/adminpanel.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .btn {
        position: relative;
        top: 50%;
        transform: translate(0, -50%);
    }
    h3 {
        padding-top: 15px;
        padding-bottom: 15px;
        color: #1b1919;
    }
</style>

<div class=""container my-3 mb-1 text-center"">
	<h2 style=""margin-top: 5px; margin-bottom: 20px;"">Админ панель</h2>
	<div class=""row mb-3 portfolio d-flex justify-content-center"" style=""border-bottom: 1px solid #1b1919;"">
        <h3>Добавить в портфолио</h3>
        <div class=""col""></div>
        <div class=""col"">
            <div style=""border: 1px solid black; height: 200px; width: 200px;"">
                <img");
            BeginWriteAttribute("src", " src=\"", 662, "\"", 668, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <button class=""btn btn-primary mb-3"">Загрузить фото</button>
            </div>
        </div>
        <div class=""col"">
            <div>
                <input type=""text"" class=""form-control"" placeholder=""Название""><br>
                <input type=""text"" class=""form-control"" placeholder=""Описание""><br>
                <input type=""text"" class=""form-control"" placeholder=""Ссылка на GitHub""><br>
            </div>
        </div>
        <div class=""col""></div>
        <div class=""col-12""></div>
        <div class=""col""></div>
        <div class=""col my-3 mb-5"">
            <button class=""btn btn-primary"">Добавить</button>
        </div>
        <div class=""col""></div>
	</div>
    <div class=""row"">
        <h3>Добавить диплом</h3>
        <div class=""col""></div>
        <div class=""col"">
            <div class=""mb-1"" style=""border: 1px solid black; height: 200px; width: 200px;"">
                <img");
            BeginWriteAttribute("src", " src=\"", 1598, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <button class=""btn btn-primary mb-3"">Загрузить фото</button>
            </div>
        </div>
        <div class=""col"">
            <div>
                <input type=""text"" class=""form-control"" placeholder=""Название""><br>
            </div>
        </div>
        <div class=""col""></div>
        <div class=""col-12""></div>
        <div class=""col""></div>
        <div class=""col mb-1"">
            <button class=""btn btn-primary mb-3"">Добавить</button>
        </div>
        <div class=""col""></div>
    </div>
    <div class=""row resume d-flex justify-content-center"">
		<div class=""col"">
            
        </div>
	</div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
