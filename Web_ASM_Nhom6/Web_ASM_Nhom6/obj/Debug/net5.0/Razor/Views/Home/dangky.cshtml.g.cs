#pragma checksum "D:\FPT POLY TEACHNIC\C# 5\Web_ASM2_Nhom6\Web_ASM_Nhom6\Web_ASM_Nhom6\Views\Home\dangky.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2697780b135f0ec69e13cdef4e2dfbc2b0862fe3c1680729b59c41b758e0ce52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dangky), @"mvc.1.0.view", @"/Views/Home/dangky.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\FPT POLY TEACHNIC\C# 5\Web_ASM2_Nhom6\Web_ASM_Nhom6\Web_ASM_Nhom6\Views\_ViewImports.cshtml"
using Web_ASM_Nhom6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPT POLY TEACHNIC\C# 5\Web_ASM2_Nhom6\Web_ASM_Nhom6\Web_ASM_Nhom6\Views\_ViewImports.cshtml"
using Web_ASM_Nhom6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2697780b135f0ec69e13cdef4e2dfbc2b0862fe3c1680729b59c41b758e0ce52", @"/Views/Home/dangky.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c7851df2479b6fe10a7e5d661f5e8ecbd969f5f357248a94a70d99b458a4e6c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_dangky : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<article class=\"container\">\r\n    <div class=\"mt-4 mb-4 register mx-auto\">\r\n        <h1 class=\"text-center fw-bold pt-4\">\r\n            Đăng Ký Tài Khoản\r\n        </h1>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2697780b135f0ec69e13cdef4e2dfbc2b0862fe3c1680729b59c41b758e0ce523990", async() => {
                WriteLiteral(@"
            <div class=""mb-3"">
                <label for=""hoten"" class=""form-label"">Tên tài khoản:</label>
                <input type=""email"" class=""form-control"" id=""hoten"" placeholder=""Trần Văn A"">
            </div>
            <div class=""mb-3"">
                <label for=""email"" class=""form-label"">Email:</label>
                <input type=""email"" class=""form-control"" id=""email"" placeholder=""TranVanA@gmail.com"">
            </div>
            <div class=""mb-3"">
                <label for=""password"" class=""form-label"">Mật khẩu:</label>
                <input type=""password"" class=""form-control"" id=""password"">
            </div>
            <div class=""mb-3"">
                <label for=""confirmpassword"" class=""form-label"">Nhập lại mật khẩu:</label>
                <input type=""password"" class=""form-control"" id=""confirmpassword"">
            </div>
            <div class=""mb-3 text-center"">
                <button class=""register-submit-btn btn btn-secondary"">Đăng ký</button>
         ");
                WriteLiteral("   </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</article>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
