#pragma checksum "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134efd52a366403904e7e3417cc18c9d3242e535"
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
#line 1 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\_ViewImports.cshtml"
using WebSiteP1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\_ViewImports.cshtml"
using WebSiteP1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134efd52a366403904e7e3417cc18c9d3242e535", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d469c0cbfd26f6fd2de86986a29e2484042e0559", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <style type=\"text/css\">\r\n        .actionlink {\r\n            font-size: larger;\r\n            color: black;\r\n        }\r\n    </style>\r\n    ");
#nullable restore
#line 14 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\Home\Index.cshtml"
Write(Html.ActionLink("Class List", "ClassList", "Home", null, new { @class = "text-center", @style = "font-size:larger;color:black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"text-center\">\r\n    <style type=\"text/css\">\r\n        .actionlink {\r\n            font-size: larger;\r\n            color: black;\r\n        }\r\n    </style>\r\n    ");
#nullable restore
#line 24 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\Home\Index.cshtml"
Write(Html.ActionLink("Enroll in classes", "Enroll", "Home", null, new { @class = "text-center", @style = "font-size:larger;color:black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"text-center\">\r\n    <style type=\"text/css\">\r\n        .actionlink {\r\n            font-size: larger;\r\n            color: black;\r\n        }\r\n    </style>\r\n    ");
#nullable restore
#line 35 "C:\Users\67luk\ZoroRepo\WebSiteP1\WebSiteP1\Views\Home\Index.cshtml"
Write(Html.ActionLink("Your Classes", "StudentClasses", "Home", null, new { @class = "text-center", @style = "font-size:larger;color:black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
