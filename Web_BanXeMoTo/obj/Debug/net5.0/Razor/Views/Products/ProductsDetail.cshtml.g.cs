#pragma checksum "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07598bef2189a4545b4ccec8d5b193140fb61248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductsDetail), @"mvc.1.0.view", @"/Views/Products/ProductsDetail.cshtml")]
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
#line 1 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
using Web_BanXeMoTo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07598bef2189a4545b4ccec8d5b193140fb61248", @"/Views/Products/ProductsDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef18d2d17df22618c30da944529771f87216aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductsDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Models.MauXe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_LayoutCustomer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--about-us start -->
<section id=""home"" class=""about-us productDetail__banner"">
</section><!--/.about-us-->
<!--about-us end -->

<section class=""about__imgPrice"">
    <div class=""container imgPrice__container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""about__img"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 639, "\"", 673, 1);
#nullable restore
#line 22 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
WriteAttributeValue("", 645, Url.Content(Model.HinhAnh1), 645, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"package-place\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"about__price\">\r\n                    <h1 class=\"text-danger about__name line\"> ");
#nullable restore
#line 27 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
                                                         Write(Html.DisplayFor(model => model.Idhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> ");
#nullable restore
#line 27 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
                                                                                                       Write(Html.DisplayFor(model => model.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h2>Giá bán chỉ từ: </h2>\r\n                    <span>");
#nullable restore
#line 29 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
                      Write((int)Model.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>
                    <button class=""book-btn"">Đặt lịch</button>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""about__detail"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-2""></div>
            <div class=""col-md-8"">
                <div class=""about__detailDesc"">
                    <h1>Đặc điểm: </h1>
                    <p>
                        ");
#nullable restore
#line 45 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
                   Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>
</section> 


<section class=""about__moreImg"">
    <div class=""container"">
        <h3>Các hình ảnh và màu sắc khác của xe: </h3>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""about__img"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 1940, "\"", 1974, 1);
#nullable restore
#line 60 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
WriteAttributeValue("", 1946, Url.Content(Model.HinhAnh2), 1946, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"package-place\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"about__img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2146, "\"", 2180, 1);
#nullable restore
#line 65 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
WriteAttributeValue("", 2152, Url.Content(Model.HinhAnh3), 2152, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""package-place"" />
                </div>
            </div>
            <div class=""col-md-2""></div>
            <div class=""col-md-8"">
                <div class=""about__moreImgPrice"">
                    <h1>Giá bán lẻ đề xuất: </h1>
                    <span class=""text-danger"">");
#nullable restore
#line 72 "D:\18DH110321\HK II Năm 3\Đồ Án 1\DA1_WEB\Web_BanXeMoTo\Views\Products\ProductsDetail.cshtml"
                                          Write((int)(Model.GiaBan)-20000000);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                    <button class=\"book-btn\">Đặt lịch</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Models.MauXe> Html { get; private set; }
    }
}
#pragma warning restore 1591
