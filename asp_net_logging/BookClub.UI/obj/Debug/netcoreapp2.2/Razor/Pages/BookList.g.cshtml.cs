#pragma checksum "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b415637b5fc7f594788766b1188a5be4144294a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookClub.UI.Pages.Pages_BookList), @"mvc.1.0.razor-page", @"/Pages/BookList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/BookList.cshtml", typeof(BookClub.UI.Pages.Pages_BookList), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b415637b5fc7f594788766b1188a5be4144294a", @"/Pages/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba3b2ace4c09c604c8f8df87271204afd1a63bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
  
    ViewData["Title"] = "Book List";

#line default
#line hidden
            BeginContext(74, 33, true);
            WriteLiteral("\r\n<h1>Book List</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(107, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b415637b5fc7f594788766b1188a5be4144294a4363", async() => {
                BeginContext(128, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(142, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(235, 50, false);
#line 16 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(285, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(341, 51, false);
#line 19 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Author));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 54, false);
#line 22 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Submitter));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 59, false);
#line 25 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Classification));

#line default
#line hidden
            EndContext();
            BeginContext(617, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(673, 50, false);
#line 28 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(723, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(779, 54, false);
#line 31 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Thumbnail));

#line default
#line hidden
            EndContext();
            BeginContext(833, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(889, 54, false);
#line 34 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].PageCount));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 56, false);
#line 37 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayNameFor(model => model.Books[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
     foreach (var item in Model.Books) {

#line default
#line hidden
            BeginContext(1183, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1232, 40, false);
#line 46 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1328, 41, false);
#line 49 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1425, 44, false);
#line 52 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Submitter));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1525, 49, false);
#line 55 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classification));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1630, 40, false);
#line 58 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1748, 1);
#line 61 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
WriteAttributeValue("", 1734, item.InfoLink, 1734, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1749, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1754, "\"", 1775, 1);
#line 61 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
WriteAttributeValue("", 1760, item.Thumbnail, 1760, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1776, 62, true);
            WriteLiteral(" /></a>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1839, 40, false);
#line 64 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(model => item.PageCount));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1935, 108, false);
#line 67 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
           Write(Html.DisplayFor(model => item.Description, new { htmlAttributes = new { style = "white-space: pre-line" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2098, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b415637b5fc7f594788766b1188a5be4144294a14032", async() => {
                BeginContext(2143, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2151, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2171, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b415637b5fc7f594788766b1188a5be4144294a16406", async() => {
                BeginContext(2219, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2230, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2250, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b415637b5fc7f594788766b1188a5be4144294a18786", async() => {
                BeginContext(2297, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2307, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "D:\code\git\learn\aspnetcore-effective-logging\AspNetCore-Effective-Logging\BookClub.UI\Pages\BookList.cshtml"
    }

#line default
#line hidden
            BeginContext(2350, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListModel>)PageContext?.ViewData;
        public BookListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591