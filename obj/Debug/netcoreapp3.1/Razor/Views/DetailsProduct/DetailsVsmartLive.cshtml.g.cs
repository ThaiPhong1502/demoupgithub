#pragma checksum "D:\năm 4\PhoneWeb\Views\DetailsProduct\DetailsVsmartLive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailsProduct_DetailsVsmartLive), @"mvc.1.0.view", @"/Views/DetailsProduct/DetailsVsmartLive.cshtml")]
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
#line 1 "D:\năm 4\PhoneWeb\Views\_ViewImports.cshtml"
using PhoneWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\năm 4\PhoneWeb\Views\_ViewImports.cshtml"
using PhoneWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c7d10daa3a2a1155df8dc721b9eb5fd30073c4", @"/Views/DetailsProduct/DetailsVsmartLive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1666a6f9d99426e110fed9e38a53d3b15797bc4", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailsProduct_DetailsVsmartLive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneWeb.Models.Domain.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListIphone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListSamsung", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListVsmart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListNokia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListOppo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\năm 4\PhoneWeb\Views\DetailsProduct\DetailsVsmartLive.cshtml"
  
    ViewData["Title"] = "DetailsVsmartLive";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Chon danh muc (chung) -->
<nav class=""navbar navbar-expand-lg navbar-light bg-white"">
    <div class=""navbar-brand disabled"" href=""#"">DANH MỤC SẢN PHẨM</div>
    <div class=""collapse navbar-collapse"" id=""navbarNav"">
        <ul class=""navbar-nav"">
            <li class=""nav-item active"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c48407", async() => {
                WriteLiteral("IPHONE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c49927", async() => {
                WriteLiteral("SAMSUNG");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c411448", async() => {
                WriteLiteral("VSMART");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c412969", async() => {
                WriteLiteral("NOKIA");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c414489", async() => {
                WriteLiteral("OPPO");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
        </ul>
    </div>
</nav>

<!-- Ten san pham -->
<br />
<h4 class=""text-danger""><i> Chi tiết sản phẩm VsmartLive </i></h4>
<hr />

<!-- Thong so san pham -->
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""row"" id=""gradient"">
            <!-- anh chinh--->
            <div class=""col-md-5"">
                <br />
                <img style=""width:400px; height:450px"" src=""https://cdn.tgdd.vn/Products/Images/42/208847/vsmart-live-blue-400x460.png"" class=""img-responsive"">
            </div>
            <!-- thong so noi bat + nut mua--->
            <div class=""col-md-7 "" id=""overview"">
                <br />
                <h3> Thông số nổi bật </h3>
                <div class=""row"">
                    <div class=""col-xs-3 col-md-3 pb-product-details-fa"">
                        <span class=""fa fa-mobile fa-lg""></span>
                        <h4><strong>6.2""</strong></h4>
                        <p>1080 x 2232 Pixels</p>
               ");
            WriteLiteral(@"     </div>
                    <div class=""col-xs-3 col-md-3 pb-product-details-fa"">
                        <span class=""fa fa-camera fa-lg""></span>
                        <h4><strong> 48 MP</strong></h4>
                        <p>	FullHD 1080p@120fps, 4K 2160p@30fps</p>
                    </div>
                    <div class=""col-xs-3 col-md-3 pb-product-details-fa"">
                        <span class=""fa fa-microchip fa-lg""></span>
                        <h4><strong>6GB RAM</strong></h4>
                        <p>Snapdragon 675 8 nhân</p>
                    </div>
                    <div class=""col-xs-3 col-md-3 pb-product-details-fa"">
                        <span class=""fa fa-battery-4 fa-lg""></span>
                        <h4><strong>4000 mAh</strong></h4>
                        <p>Li-ion</p>
                    </div>
                </div>
                <!-- anh them -->
                <div class=""row"">
                    <div class=""container"">
                    ");
            WriteLiteral(@"    <h3> Một số màu khác </h3>
                        <img style=""width:200px; height:200px"" src=""https://cdn.tgdd.vn/Products/Images/42/208847/vsmart-live-black-200-180x125.png"" class=""img-responsive"">
                        <img style=""width:200px; height:200px"" src=""https://cdn.tgdd.vn/Products/Images/42/208847/vsmart-live-white-200-180x125.png"" class=""img-responsive"">
                        <img style=""width:200px; height:200px"" src=""https://cdn.tgdd.vn/Products/Images/42/208847/vsmart-live-blue-200-180x125.png"" class=""img-responsive"">
                    </div>
                </div>
                <!--- Gia san pham-->
                <br />
                <h3>Giá: <strike>7.000.000 VNĐ </strike></h3>
                <h3 class=""text-danger"">5.000.000 VNĐ</h3>
                <!-- nut them gio hang -->
                <br />
");
#nullable restore
#line 84 "D:\năm 4\PhoneWeb\Views\DetailsProduct\DetailsVsmartLive.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c419273", async() => {
                WriteLiteral("  Thêm vào giỏ hàng ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\năm 4\PhoneWeb\Views\DetailsProduct\DetailsVsmartLive.cshtml"
                                                                    WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c7d10daa3a2a1155df8dc721b9eb5fd30073c421770", async() => {
                WriteLiteral("Trở về trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 90 "D:\năm 4\PhoneWeb\Views\DetailsProduct\DetailsVsmartLive.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <!-- thong so chi tiet--->
        <section id=""tabs"" class=""project-tab"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <!--- di chuyen trong tab -->
                        <nav>
                            <div class=""nav nav-tabs nav-fill"" id=""nav-tab"" role=""tablist"">
                                <h4></h4> <a class=""nav-item nav-link active"" id=""nav-mh-tab"" data-toggle=""tab"" href=""#nav-mh"" role=""tab"" aria-controls=""nav-mh"" aria-selected=""true"">Màn hình</a>
                                <a class=""nav-item nav-link"" id=""nav-cam-tab"" data-toggle=""tab"" href=""#nav-cam"" role=""tab"" aria-controls=""nav-cam"" aria-selected=""false"">Camera</a>
                                <a class=""nav-item nav-link"" id=""nav-cpu-tab"" data-toggle=""tab"" href=""#nav-cpu"" role=""tab"" aria-controls=""nav-cpu"" aria-selected=""false"">Hệ điều hành - CPU</a>
                                <a cl");
            WriteLiteral(@"ass=""nav-item nav-link"" id=""nav-lt-tab"" data-toggle=""tab"" href=""#nav-lt"" role=""tab"" aria-controls=""nav-lt"" aria-selected=""false"">Bộ nhớ & Lưu trữ</a>
                                <a class=""nav-item nav-link"" id=""nav-kn-tab"" data-toggle=""tab"" href=""#nav-kn"" role=""tab"" aria-controls=""nav-kn"" aria-selected=""false"">Kết nối</a>
                            </div>
                        </nav>
                        <!--- cac tab  -->
                        <div class=""tab-content"" id=""nav-tabContent"">
                            <!--- tab1 -->
                            <div class=""tab-pane fade show active"" id=""nav-mh"" role=""tabpanel"" aria-labelledby=""nav-mh-tab"">
                                <table class=""table"" cellspacing=""0"">
                                    <tr>
                                        <td>Công nghệ màn hình</td>
                                        <td>AMOLED</td>
                                    </tr>
                                    <tr>
                 ");
            WriteLiteral(@"                       <td>Độ phân giải</td>
                                        <td>Full HD+ (1080 x 2232 Pixels)</td>

                                    </tr>
                                    <tr>
                                        <td>Màn hình rộng</td>
                                        <td>6.2""</td>
                                    </tr>
                                    <tr>
                                        <td>Mặt kính cảm ứng</td>
                                        <td>Mặt kính cong 2.5D</td>
                                    </tr>
                                </table>
                            </div>
                            <!--- tab2 -->
                            <div class=""tab-pane fade"" id=""nav-cam"" role=""tabpanel"" aria-labelledby=""nav-cam-tab"">
                                <table class=""table"" cellspacing=""0"">
                                    <tr>
                                        <td>Độ phân giải camera sau</td>
   ");
            WriteLiteral(@"                                     <td>Chính 48 MP & Phụ 8 MP, 5 MP</td>
                                    </tr>
                                    <tr>
                                        <td>Độ phân giải camera trước</td>
                                        <td>20 MP</td>
                                    </tr>
                                    <tr>
                                        <td>Quay phim</td>
                                        <td>Quay phim FullHD 1080p@120fps, Quay phim 4K 2160p@30fps</td>
                                    </tr>
                                    <tr>
                                        <td>Đèn Flash</td>
                                        <td>Có</td>
                                    </tr>
                                    <tr>
                                        <td>Chụp ảnh nâng cao</td>
                                        <td>
                                            Nhận diện khuôn mặt, Làm đẹp (Beautify)");
            WriteLiteral(@", Tự động lấy nét (AF), Làm đẹp (Selfie A.I Beauty)
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <!--- tab3 -->
                            <div class=""tab-pane fade"" id=""nav-cpu"" role=""tabpanel"" aria-labelledby=""nav-cpu-tab"">
                                <table class=""table"" cellspacing=""0"">
                                    <tr>
                                        <td>Hệ điều hành	</td>
                                        <td> Android 9.0 (Pie)</td>
                                    </tr>
                                    <tr>
                                        <td>Chipset (hãng SX CPU)</td>
                                        <td>Snapdragon 675 8 nhân</td>

                                    </tr>
                                    <tr>
                                        <td> Tốc độ CPU	</td>
                  ");
            WriteLiteral(@"                      <td> 2 nhân 2.0 GHz & 6 nhân 1.8 GHz</td>

                                    </tr>
                                    <tr>
                                        <td> Chip đồ họa (GPU)</td>
                                        <td>   	Adreno 612</td>

                                    </tr>
                                </table>
                            </div>
                            <!--- tab4 -->
                            <div class=""tab-pane fade"" id=""nav-lt"" role=""tabpanel"" aria-labelledby=""nav-lt-tab"">
                                <table class=""table"" cellspacing=""0"">
                                    <tr>
                                        <td>RAM</td>
                                        <td>	6 GB</td>
                                    </tr>
                                    <tr>
                                        <td>Bộ nhớ trong</td>
                                        <td>	64 GB</td>
                             ");
            WriteLiteral(@"       </tr>
                                    <tr>
                                        <td>Bộ nhớ còn lại (khả dụng)</td>
                                        <td>Khoảng 53 GB</td>
                                    </tr>
                                    <tr>
                                        <td>Thẻ nhớ ngoài</td>
                                        <td>	Không</td>
                                    </tr>
                                </table>
                            </div>
                            <!--- tab5 -->
                            <div class=""tab-pane fade"" id=""nav-kn"" role=""tabpanel"" aria-labelledby=""nav-kn-tab"">
                                <table class=""table"" cellspacing=""0"">
                                    <tr>
                                        <td>   Mạng di động</td>
                                        <td>	Hỗ trợ 4G</td>
                                    </tr>
                                    <tr>
                   ");
            WriteLiteral(@"                     <td>SIM</td>
                                        <td>Nano SIM</td>
                                    </tr>
                                    <tr>
                                        <td>Wifi</td>
                                        <td>Wi-Fi 802.11 a/b/g/n/ac, Wi-Fi hotspot</td>
                                    </tr>
                                    <tr>
                                        <td>GPS</td>
                                        <td>A-GPS, GLONASS</td>
                                    </tr>
                                    <tr>
                                        <td>Bluetooth</td>
                                        <td>A2DP, LE, v5.0</td>
                                    </tr>
                                    <tr>
                                        <td>Cổng kết nối/sạc</td>
                                        <td>	USB Type-C</td>
                                    </tr>
                          ");
            WriteLiteral(@"          <tr>
                                        <td>Jack tai nghe</td>
                                        <td>	3.5 mm</td>
                                    </tr>
                                    <tr>
                                        <td>Kết nối khác</td>
                                        <td>OTG</td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneWeb.Models.Domain.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
