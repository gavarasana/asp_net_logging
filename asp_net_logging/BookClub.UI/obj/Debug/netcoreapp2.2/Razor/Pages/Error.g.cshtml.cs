#pragma checksum "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd83c08be7b4329ea95e1263dd660c91c7027f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookClub.UI.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Error.cshtml", typeof(BookClub.UI.Pages.Pages_Error), null)]
namespace BookClub.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd83c08be7b4329ea95e1263dd660c91c7027f0c", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba3b2ace4c09c604c8f8df87271204afd1a63bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(67, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
#line 10 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(217, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(270, 15, false);
#line 13 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(285, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 15 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
}

#line default
#line hidden
#line 16 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
 if (!string.IsNullOrEmpty(Model.ApiRoute))
{

#line default
#line hidden
            BeginContext(355, 43, true);
            WriteLiteral("<p>\r\n    <strong>API Route:</strong> <code>");
            EndContext();
            BeginContext(399, 14, false);
#line 19 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                 Write(Model.ApiRoute);

#line default
#line hidden
            EndContext();
            BeginContext(413, 60, true);
            WriteLiteral("</code>\r\n    <br />\r\n    <strong>API Status:</strong> <code>");
            EndContext();
            BeginContext(474, 15, false);
#line 21 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                  Write(Model.ApiStatus);

#line default
#line hidden
            EndContext();
            BeginContext(489, 61, true);
            WriteLiteral("</code>\r\n    <br />\r\n    <strong>API ErrorID:</strong> <code>");
            EndContext();
            BeginContext(551, 16, false);
#line 23 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                   Write(Model.ApiErrorId);

#line default
#line hidden
            EndContext();
            BeginContext(567, 59, true);
            WriteLiteral("</code>\r\n    <br />\r\n    <strong>API Title:</strong> <code>");
            EndContext();
            BeginContext(627, 14, false);
#line 25 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                 Write(Model.ApiTitle);

#line default
#line hidden
            EndContext();
            BeginContext(641, 60, true);
            WriteLiteral("</code>\r\n    <br />\r\n    <strong>API Detail:</strong> <code>");
            EndContext();
            BeginContext(702, 15, false);
#line 27 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
                                  Write(Model.ApiDetail);

#line default
#line hidden
            EndContext();
            BeginContext(717, 15, true);
            WriteLiteral("</code>\r\n</p>\r\n");
            EndContext();
#line 29 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\Error.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591