#pragma checksum "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa42e0ba7d118c674cffe4d2ae0b401978ff69fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using ChatApplications;

#line default
#line hidden
#line 2 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using ChatApplications.Models;

#line default
#line hidden
#line 4 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa42e0ba7d118c674cffe4d2ae0b401978ff69fb", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cd8ae7341fdbfb5c75b02dac9f636f81056be9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/util.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AVATAR"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"
  
	Layout = null;

#line default
#line hidden
            BeginContext(49, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(86, 2177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ca2e215f1d4797b09e53e31b4dce8c", async() => {
                BeginContext(92, 1960, true);
                WriteLiteral(@"
	<title>Login</title>
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<!--===============================================================================================-->
	<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico"" />
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/iconic/css/material-design-iconic-font.min.css"">
	<!--===============================================================================================-->
	<link rel=""styles");
                WriteLiteral(@"heet"" type=""text/css"" href=""vendor/animate/animate.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/daterangepicker/daterangepicker.css"">
	<!--===============================================================================================-->
	");
                EndContext();
                BeginContext(2052, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9dba96c40fd74fb48ca186729b7cbc79", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2099, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(2102, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2db7714377894c599655f2ab5807ed7b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2149, 107, true);
                WriteLiteral("\r\n\t<!--===============================================================================================-->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2263, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2265, 3059, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d738ce2b8f74e9e9ecf9ebf96b4f5d3", async() => {
                BeginContext(2271, 112, true);
                WriteLiteral("\r\n\r\n\t<div class=\"limiter\">\r\n\t\t<div class=\"container-login100\">\r\n\t\t\t<div class=\"wrap-login100 p-t-85 p-b-20\">\r\n\r\n");
                EndContext();
#line 42 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"
                 using (Html.BeginForm("Login", "Account", FormMethod.Post))
				{

#line default
#line hidden
                BeginContext(2456, 5, true);
                WriteLiteral("\t\t\t\t\t");
                EndContext();
                BeginContext(2461, 1505, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "490645cc53184c88af907de9ee945869", async() => {
                    BeginContext(2503, 132, true);
                    WriteLiteral("\r\n\t\t\t\t\t\t<span class=\"login100-form-title p-b-70\">\r\n\t\t\t\t\t\t\tWelcome\r\n\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t<span class=\"login100-form-avatar\">\r\n\t\t\t\t\t\t\t");
                    EndContext();
                    BeginContext(2635, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d37de6414ae4a128aa6a6892ae9211b", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2677, 121, true);
                    WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t<div class=\"wrap-input100 validate-input m-t-85 m-b-35\" data-validate=\"Enter username\">\r\n\t\t\t\t\t\t\t");
                    EndContext();
                    BeginContext(2799, 57, false);
#line 53 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"
                       Write(Html.TextBoxFor(m=>m.Username,new { @class= "input100" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2856, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(2937, 184, true);
                    WriteLiteral("\t\t\t\t\t\t\t<span class=\"focus-input100\" data-placeholder=\"Username\"></span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"wrap-input100 validate-input m-b-50\" data-validate=\"Enter password\">\r\n\t\t\t\t\t\t\t");
                    EndContext();
                    BeginContext(3122, 62, false);
#line 59 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "input100" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(3184, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(3269, 573, true);
                    WriteLiteral(@"							<span class=""focus-input100"" data-placeholder=""Password""></span>
						</div>

						<div class=""container-login100-form-btn"">
							<button type=""submit"" class=""login100-form-btn"">
								Login
							</button>
						</div>

						<ul class=""login-more p-t-190"">
							<li class=""m-b-8"">
								<span class=""txt1"">
									Forgot
								</span>

								<a href=""#"" class=""txt2"">
									Username / Password?
								</a>
							</li>

							<li>
								<span class=""txt1"">
									Don’t have an account?
								</span>

								");
                    EndContext();
                    BeginContext(3843, 72, false);
#line 86 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"
                           Write(Html.ActionLink("Register","Register","Account", new { @class = "txt2"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(3915, 44, true);
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3966, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 91 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Account\Login.cshtml"

				}

#line default
#line hidden
                BeginContext(3977, 1340, true);
                WriteLiteral(@"			</div>
		</div>
	</div>


	<div id=""dropDownSelect1""></div>

	<!--===============================================================================================-->
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/bootstrap/js/popper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script");
                WriteLiteral(@">
	<!--===============================================================================================-->
	<script src=""vendor/countdowntime/countdowntime.js""></script>
	<!--===============================================================================================-->
	<script src=""js/main.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5324, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591