#pragma checksum "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4e98dbd37cacc5a011750d4f98140454112ade"
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
#line 1 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\_ViewImports.cshtml"
using Shopping.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\_ViewImports.cshtml"
using Shopping.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f4e98dbd37cacc5a011750d4f98140454112ade", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d37f9fe7879306af56e99a14e3e630a5e9c725", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shopping.Client.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Products</h1>\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
         foreach (var product in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 50 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => product.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => product.ImageFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Practice\MicroserviceAksDevOps\Shopping\Shopping.Client\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shopping.Client.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
