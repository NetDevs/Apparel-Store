#pragma checksum "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a652640816e00560fd854adb63b59006a61ee62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_GetProducts), @"mvc.1.0.view", @"/Views/Search/GetProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/GetProducts.cshtml", typeof(AspNetCore.Views_Search_GetProducts))]
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
#line 1 "D:\ApparelStore\ApparelStoreApplication\Views\_ViewImports.cshtml"
using ApparelStoreApplication;

#line default
#line hidden
#line 2 "D:\ApparelStore\ApparelStoreApplication\Views\_ViewImports.cshtml"
using ApparelStoreApplication.Models;

#line default
#line hidden
#line 1 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
using ApparelStoreWebService.Models.DB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a652640816e00560fd854adb63b59006a61ee62", @"/Views/Search/GetProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc97fdbd143ed0cd178cecde44313362f44e1fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_GetProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
  
    ViewData["Title"] = "GetProducts";

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
   
    List<ProductViewModel> Model = (List<ProductViewModel>)ViewBag.product;

#line default
#line hidden
            BeginContext(207, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(213, 995, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe432127824c4cb8aa0ea89924fb4436", async() => {
                BeginContext(283, 214, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <input type=\"submit\" value=\"Submit\"  class=\"btn btn-success\"/>\r\n    </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\"></div>\r\n            <div class=\"col-md-5\">\r\n");
                EndContext();
#line 20 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
                BeginContext(572, 50, true);
                WriteLiteral("                <div>\r\n                    <label>");
                EndContext();
                BeginContext(623, 14, false);
#line 23 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
                      Write(Model[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(637, 29, true);
                WriteLiteral("</label> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 666, "\"", 683, 3);
                WriteAttributeValue("", 673, "[", 673, 1, true);
#line 23 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 674, i, 674, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 676, "].Title", 676, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 684, "\"", 707, 1);
#line 23 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 692, Model[i].Title, 692, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(708, 32, true);
                WriteLiteral(" />\r\n                    <label>");
                EndContext();
                BeginContext(741, 14, false);
#line 24 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
                      Write(Model[i].Price);

#line default
#line hidden
                EndContext();
                BeginContext(755, 29, true);
                WriteLiteral("</label> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", "  name=\"", 784, "\"", 802, 3);
                WriteAttributeValue("", 792, "[", 792, 1, true);
#line 24 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 793, i, 793, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 795, "].Price", 795, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 803, "\"", 826, 1);
#line 24 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 811, Model[i].Price, 811, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(827, 32, true);
                WriteLiteral(" />\r\n                    <label>");
                EndContext();
                BeginContext(860, 20, false);
#line 25 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
                EndContext();
                BeginContext(880, 29, true);
                WriteLiteral("</label> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", "  name=\"", 909, "\"", 933, 3);
                WriteAttributeValue("", 917, "[", 917, 1, true);
#line 25 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 918, i, 918, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 920, "].Description", 920, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 934, "\"", 963, 1);
#line 25 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
WriteAttributeValue("", 942, Model[i].Description, 942, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(964, 25, true);
                WriteLiteral(" />\r\n                    ");
                EndContext();
                BeginContext(990, 39, false);
#line 26 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
               Write(Html.CheckBoxFor(c=>@Model[i].Selected));

#line default
#line hidden
                EndContext();
                BeginContext(1029, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 28 "D:\ApparelStore\ApparelStoreApplication\Views\Search\GetProducts.cshtml"
                }

#line default
#line hidden
                BeginContext(1074, 127, true);
                WriteLiteral("                <div>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\"></div>\r\n        </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591