#pragma checksum "C:\Users\Admin\Documents\GitHub\demoupgithub\Areas\Admin\Views\HomeAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b0a72494927ebeb9456060697041dc802a0e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAdmin/Index.cshtml")]
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
#line 2 "C:\Users\Admin\Documents\GitHub\demoupgithub\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\demoupgithub\Areas\Admin\Views\_ViewImports.cshtml"
using PhoneWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\demoupgithub\Areas\Admin\Views\_ViewImports.cshtml"
using PhoneWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b0a72494927ebeb9456060697041dc802a0e4c", @"/Areas/Admin/Views/HomeAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72275bd775f80da750e713c6ba224a05d0bcab2c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HomeAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\demoupgithub\Areas\Admin\Views\HomeAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<h2 style=""padding-top: 1em"">
    WELCOME, Admin@gmail.com !
</h2>

<div class=""row"" style=""padding-top: 2em"">

    <div class=""col-4 "">
        <div class=""card border-primary shadow h-100 py-2 bg-primary text-white"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col md-4"">
                        <div class=""text-xs font-weight-bold text-uppercase mb-1"">Doanh thu </div>
                        <div class=""h5 mb-0 font-weight-bold ""> 0 </div>
                    </div>
                    <div class=""col md-4"">
                        <i class=""fa fa-calendar"" style=""font-size:60px; padding-left:20px"" aria-hidden=""true""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""col-4 "">
        <div class=""card border-info shadow h-100 py-2 bg-info text-white"">
            <div class=""card-body"">
                <div class=""row no-gut");
            WriteLiteral(@"ters align-items-center"">
                    <div class=""col md-4"">
                        <div class=""text-xs font-weight-bold text-uppercase mb-1"">Số lượng sản phẩm</div>
                        <div class=""h5 mb-0 font-weight-bold ""> 23 </div>
                    </div>
                    <div class=""col md-4"">
                        <i class=""fa fa-cubes"" style=""font-size:60px; padding-left:20px"" aria-hidden=""true""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-4"">
        <div class=""card border-success shadow h-100 py-2 bg-success text-white"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col md-4"">
                        <div class=""text-xs font-weight-bold  text-uppercase mb-1"">Số lượng đơn hàng</div>
                        <div class=""h5 mb-0 font-weight-bold ""> 0 </div>
                    </div>
                   ");
            WriteLiteral(@" <div class=""col md-4"">
                        <i class=""fa fa-clipboard"" style=""font-size:60px; padding-left:20px"" aria-hidden=""true""></i>
                    </div>
                </div>
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
