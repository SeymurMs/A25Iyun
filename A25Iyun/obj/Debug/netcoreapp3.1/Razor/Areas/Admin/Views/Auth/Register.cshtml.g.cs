#pragma checksum "C:\Users\devel0per\source\repos\A25Iyun\A25Iyun\Areas\Admin\Views\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d868ce973cdff0dcf4765f88ffcb998633f494c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Auth_Register), @"mvc.1.0.view", @"/Areas/Admin/Views/Auth/Register.cshtml")]
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
#line 1 "C:\Users\devel0per\source\repos\A25Iyun\A25Iyun\Areas\Admin\Views\_ViewImports.cshtml"
using A25Iyun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\A25Iyun\A25Iyun\Areas\Admin\Views\_ViewImports.cshtml"
using A25Iyun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d868ce973cdff0dcf4765f88ffcb998633f494c5", @"/Areas/Admin/Views/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e006873a998851f1d12344c1c36ac2c595748b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\devel0per\source\repos\A25Iyun\A25Iyun\Areas\Admin\Views\Auth\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container pl-101"">
    <div class=""d-flex align-items-center justify-content-center text-center h-100vh"">
            <div class=""form-wrapper m-auto"">
                <div class=""form-container my-4"">
                    <div class=""register-logo text-center mb-4"">
                        <img src=""assets/dist/img/logo2.html""");
            BeginWriteAttribute("alt", " alt=\"", 391, "\"", 397, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""panel"">
                        <div class=""panel-header text-center mb-3"">
                            <h3 class=""fs-24"">Sign up for your account!</h3>
                            <p class=""text-muted text-center mb-0"">Start your 15-day trial, no credit card required</p>
                        </div>
                        <a class=""btn btn-linkedin btn-block bg-white text-left font-weight-normal position-relative mb-3""  href=""#"">
                            <span>Sign up with LinkedIn</span>
                        </a>
                        <a class=""btn  btn-google btn-block bg-white text-left font-weight-normal position-relative mb-3"" href=""#"">
                            <span>Sign up with Google</span>
                        </a>
                        <p class=""text-muted text-center"">We won't post anything without your permission and your personal details are kept private</p>
                        <div class=""divider f");
            WriteLiteral("ont-weight-bold text-uppercase text-dark d-table text-center my-3\">Or</div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d868ce973cdff0dcf4765f88ffcb998633f494c55609", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" id=""f_name"" placeholder=""First name"">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" id=""l_name"" placeholder=""Last name"">
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control is-invalid"" id=""emial"" placeholder=""Enter email"">
                                <div class=""invalid-feedback text-left"">Enter your valid email</div>
                            </div>
                            <div class=""form-group"">
                                <input type=""password"" class=""form-control"" id=""pass"" placeholder=""Password"">
                            </div>
                            <div class=""custom-control custom-checkbox mb-3"">
                          ");
                WriteLiteral(@"      <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                <label class=""custom-control-label"" for=""customCheck1"">By signing up, you agree to the <a href=""#"">terms of service</a></label>
                            </div>
                            <button type=""submit"" class=""btn btn-success btn-block"">Sign up</button>
                            <p class=""text-muted text-center mt-3 mb-0"">
                                By signing up, you agree to our <a class=""external"" href=""#"">terms of use</a>.
                            </p>
                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n\r\n\r\n");
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
