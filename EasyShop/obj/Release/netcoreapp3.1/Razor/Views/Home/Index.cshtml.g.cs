#pragma checksum "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84a8b101e0d4bdaf106d39c0da609adebe4fdcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Csharp projects\EasyShop\EasyShop\Views\_ViewImports.cshtml"
using EasyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Csharp projects\EasyShop\EasyShop\Views\_ViewImports.cshtml"
using EasyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
using EasyShop.DataAccessLayer.Models.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84a8b101e0d4bdaf106d39c0da609adebe4fdcd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffde10a58fa69d4333ff84df2a0fe5701c60a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Picture>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Main Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n");
#nullable restore
#line 11 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
     using (Html.BeginForm("AddPicture", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 16 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 18 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "D:\Csharp projects\EasyShop\EasyShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Picture> Html { get; private set; }
    }
}
#pragma warning restore 1591
