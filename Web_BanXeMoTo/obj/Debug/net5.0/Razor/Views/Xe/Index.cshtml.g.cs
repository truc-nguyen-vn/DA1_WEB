#pragma checksum "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27780c85bbc36092249f76ae262a1437a1eea063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Xe_Index), @"mvc.1.0.view", @"/Views/Xe/Index.cshtml")]
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
#line 1 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27780c85bbc36092249f76ae262a1437a1eea063", @"/Views/Xe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef18d2d17df22618c30da944529771f87216aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Xe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_BanXeMoTo.Models.MauXe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
  

    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutManager.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27780c85bbc36092249f76ae262a1437a1eea0634409", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27780c85bbc36092249f76ae262a1437a1eea0635576", async() => {
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Find by name: <input type=\"text\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 375, "\"", 402, 1);
#nullable restore
#line 18 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
WriteAttributeValue("", 383, ViewData["search"], 383, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27780c85bbc36092249f76ae262a1437a1eea0636441", async() => {
                    WriteLiteral("Back to Full List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idmau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idkm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiaBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HinhAnh1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HinhAnh2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HinhAnh3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaoHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Idmau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Idkm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Idhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("\r\n                ");
#nullable restore
#line 78 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
            Write((int)@item.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p> <img");
            BeginWriteAttribute("src", " src=\"", 2287, "\"", 2331, 1);
#nullable restore
#line 81 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
WriteAttributeValue("", 2293, Url.Content("~/img/" + item.HinhAnh1), 2293, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" /> </p>\r\n            </td>\r\n            <td>\r\n                <p> <img");
            BeginWriteAttribute("src", " src=\"", 2428, "\"", 2472, 1);
#nullable restore
#line 84 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
WriteAttributeValue("", 2434, Url.Content("~/img/" + item.HinhAnh2), 2434, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" /> </p>\r\n            </td>\r\n            <td>\r\n                <p> <img");
            BeginWriteAttribute("src", " src=\"", 2569, "\"", 2613, 1);
#nullable restore
#line 87 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
WriteAttributeValue("", 2575, Url.Content("~/img/" + item.HinhAnh3), 2575, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" /> </p>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaoHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 96 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 97 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 98 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 101 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\DA1\Web_BanXeMoTo\Views\Xe\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_BanXeMoTo.Models.MauXe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
