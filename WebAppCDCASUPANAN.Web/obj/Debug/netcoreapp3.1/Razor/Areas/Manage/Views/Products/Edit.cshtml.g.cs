#pragma checksum "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf9d8bb47deb43d3fbda7ed40c785b5cc55bf2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Products_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Products/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf9d8bb47deb43d3fbda7ed40c785b5cc55bf2c", @"/Areas/Manage/Views/Products/Edit.cshtml")]
    public class Areas_Manage_Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppCDCASUPANAN.Web.Areas.Manage.ViewModels.Products.EditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/products/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf9d8bb47deb43d3fbda7ed40c785b5cc55bf2c4167", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 12 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 441, "\"", 458, 1);
#nullable restore
#line 14 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 449, Model.Id, 449, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"productStatus\" class=\"control-label mb-1\">Product Status</label>\r\n                    <select class=\"form-control\" id=\"productStatus\" name=\"ProductStatus\">\r\n");
#nullable restore
#line 19 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
                          
                            var options = Enum.GetValues(typeof(WebAppCDCASUPANAN.Web.Infrastructures.Domain.Enums.ProductStatus)).Cast<WebAppCDCASUPANAN.Web.Infrastructures.Domain.Enums.ProductStatus>();

                            foreach (WebAppCDCASUPANAN.Web.Infrastructures.Domain.Enums.ProductStatus option in options)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <option");
                BeginWriteAttribute("value", " value=\"", 1125, "\"", 1140, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1133, option, 1133, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""name"" class=""control-label mb-2"">Name</label>
                    <input type=""text"" class=""form-control"" id=""name"" name=""Name"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 1514, "\"", 1533, 1);
#nullable restore
#line 31 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1522, Model.Name, 1522, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Name"">
                </div>

                <div class=""form-group"">
                    <label for=""description"" class=""control-label mb-2"">Description</label>
                    <input type=""text"" class=""form-control"" id=""description"" name=""Description"" aria-describedby=""descriptionHelp""");
                BeginWriteAttribute("value", " value=\"", 1853, "\"", 1879, 1);
#nullable restore
#line 36 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1861, Model.Description, 1861, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Description"">
                </div>
                <div class=""form-group"">
                    <label for=""quantity"" class=""control-label mb-2"">Quantity</label>
                    <input type=""text"" class=""form-control"" id=""quantity"" name=""Quantity""");
                BeginWriteAttribute("value", " value=\"", 2157, "\"", 2180, 1);
#nullable restore
#line 40 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 2165, Model.Quantity, 2165, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""quantityHelp"" placeholder=""Enter Quantity"">
                </div>

                <div class=""form-group"">
                    <label for=""price"" class=""control-label mb-2"">Price</label>
                    <input type=""text"" class=""form-control"" id=""price"" name=""Price""");
                BeginWriteAttribute("value", " value=\"", 2477, "\"", 2497, 1);
#nullable restore
#line 45 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
WriteAttributeValue("", 2485, Model.Price, 2485, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-describedby=\"priceHelp\" placeholder=\"Enter Price\">\r\n                </div>\r\n\r\n\r\n\r\n                <div class=\"mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf9d8bb47deb43d3fbda7ed40c785b5cc55bf2c10562", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2734, "~/manage/products/details/", 2734, 26, true);
#nullable restore
#line 52 "C:\Users\VGD PC 9\source\repos\WebAppCDCASUPANAN.Web\WebAppCDCASUPANAN.Web\Areas\Manage\Views\Products\Edit.cshtml"
AddHtmlAttributeValue("", 2760, Model.Id, 2760, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppCDCASUPANAN.Web.Areas.Manage.ViewModels.Products.EditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591