#pragma checksum "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a680597ce1ae86f63b4f9a21b43b8102b7f5f27d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Posts_Index), @"mvc.1.0.razor-page", @"/Pages/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Posts/Index.cshtml", typeof(AspNetCore.Pages_Posts_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a680597ce1ae86f63b4f9a21b43b8102b7f5f27d", @"/Pages/Posts/Index.cshtml")]
    public class Pages_Posts_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 156, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(295, 49, false);
#line 18 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Post[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 51, false);
#line 21 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Post[0].Content));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 56, false);
#line 24 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Post[0].CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(563, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
 foreach (var item in Model.Post) {

#line default
#line hidden
            BeginContext(686, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(735, 40, false);
#line 33 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(775, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(831, 42, false);
#line 36 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(929, 47, false);
#line 39 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(976, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1051, "\"", 1074, 1);
#line 42 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
WriteAttributeValue("", 1066, item.ID, 1066, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1127, "\"", 1150, 1);
#line 43 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
WriteAttributeValue("", 1142, item.ID, 1142, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1151, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1205, "\"", 1228, 1);
#line 44 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
WriteAttributeValue("", 1220, item.ID, 1220, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\taabou\Documents\Capgemini\Advanced Software Engineering Track\RPGgame\RPGgame\Portfolio\Pages\Posts\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1279, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio.Pages.Posts.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.Posts.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.Posts.IndexModel>)PageContext?.ViewData;
        public Portfolio.Pages.Posts.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591