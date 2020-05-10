#pragma checksum "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4ac99e0991102e0b4ef14e7b28e93b61b1bc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4ac99e0991102e0b4ef14e7b28e93b61b1bc64", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cd8ae7341fdbfb5c75b02dac9f636f81056be9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/team.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 198, true);
            WriteLiteral("\r\n\r\n<div id=\"frame\">\r\n\t<div id=\"sidepanel\">\r\n\t\t<div id=\"profile\">\r\n\t\t\t<div class=\"wrap\">\r\n\t\t\t\t<img id=\"profile-img\" src=\"http://emilcarlsson.se/assets/mikeross.png\" class=\"online\" alt=\"\" />\r\n\t\t\t\t<p>");
            EndContext();
            BeginContext(263, 16, false);
#line 12 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
              Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(279, 1200, true);
            WriteLiteral(@"</p>
				<i class=""fa fa-chevron-down expand-button"" aria-hidden=""true""></i>
				<div id=""status-options"">
					<ul>
						<li id=""status-online"" class=""active""><span class=""status-circle""></span> <p>Online</p></li>
						<li id=""status-away""><span class=""status-circle""></span> <p>Away</p></li>
						<li id=""status-busy""><span class=""status-circle""></span> <p>Busy</p></li>
						<li id=""status-offline""><span class=""status-circle""></span> <p>Offline</p></li>
					</ul>
				</div>
				<div id=""expanded"">
					<label for=""twitter""><i class=""fa fa-facebook fa-fw"" aria-hidden=""true""></i></label>
					<input name=""twitter"" type=""text"" value=""mikeross"" />
					<label for=""twitter""><i class=""fa fa-twitter fa-fw"" aria-hidden=""true""></i></label>
					<input name=""twitter"" type=""text"" value=""ross81"" />
					<label for=""twitter""><i class=""fa fa-instagram fa-fw"" aria-hidden=""true""></i></label>
					<input name=""twitter"" type=""text"" value=""mike.ross"" />
				</div>
			</div>
		</div>
		<div id=""search"">
            WriteLiteral("\n\t\t\t<label for=\"\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i></label>\r\n\t\t\t<input type=\"text\" placeholder=\"Search contacts...\" />\r\n\t\t</div>\r\n\t\t<div id=\"contacts\">\r\n\t\t\t<ul>\r\n");
            EndContext();
#line 38 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                 foreach (var item in Model.Users.ToList())
				{

#line default
#line hidden
            BeginContext(1535, 112, true);
            WriteLiteral("\t\t\t\t\t<li class=\"contact\">\r\n\t\t\t\t\t\t<div class=\"wrap\">\r\n\t\t\t\t\t\t\t<span class=\"contact-status online\"></span>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1647, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cc1d3b17ed341d9bebdca1eaed04611", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 62, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<div class=\"meta\">\r\n\t\t\t\t\t\t\t\t<p class=\"name\">");
            EndContext();
            BeginContext(1741, 14, false);
#line 46 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                                           Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1755, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1757, 13, false);
#line 46 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                                                           Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 33, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"preview\">");
            EndContext();
            BeginContext(1804, 11, false);
#line 47 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                                              Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1815, 47, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n");
            EndContext();
#line 51 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(1869, 910, true);
            WriteLiteral(@"
			</ul>
		</div>
		<div id=""bottom-bar"">
			<button id=""addcontact""><i class=""fa fa-user-plus fa-fw"" aria-hidden=""true""></i> <span>Add contact</span></button>
			<button id=""settings""><i class=""fa fa-cog fa-fw"" aria-hidden=""true""></i> <span>Settings</span></button>
		</div>
	</div>
	<div class=""content"">
		<div class=""contact-profile"">
			<img src=""http://emilcarlsson.se/assets/harveyspecter.png"" alt="""" />
			<p>Harvey Specter</p>
			<div class=""social-media"">
				<i class=""fa fa-facebook"" aria-hidden=""true""></i>
				<i class=""fa fa-twitter"" aria-hidden=""true""></i>
				<i class=""fa fa-instagram"" aria-hidden=""true""></i>
			</div>
		</div>
		<div class=""messages"">
			<ul>
				<li class=""sent"">
					<img src=""http://emilcarlsson.se/assets/mikeross.png"" alt="""" />
					<p>How the hell am I supposed to get a jury to believe you when I am not even sure that I do?!</p>
				</li>
");
            EndContext();
#line 76 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                 foreach (var item in Model.Messages.ToList())
				{

#line default
#line hidden
            BeginContext(2838, 107, true);
            WriteLiteral("\t\t\t\t\t<li class=\"replies\">\r\n\t\t\t\t\t\t<img src=\"http://emilcarlsson.se/assets/mikeross.png\" alt=\"\" />\r\n\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(2946, 16, false);
#line 80 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                      Write(item.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(2962, 18, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</li>\r\n");
            EndContext();
#line 82 "C:\Repository\ChatApplication\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(2987, 354, true);
            WriteLiteral(@"			</ul>
		</div>
		<div class=""message-input"">
			<div class=""wrap"">
				<input id=""MessageField"" type=""text"" placeholder=""Write your message..."" />
				<i class=""fa fa-paperclip attachment"" aria-hidden=""true""></i>
				<button class=""submit""><i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>
			</div>
		</div>
	</div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3359, 1156, true);
                WriteLiteral(@"


	<script>
    $(function () {
      
        var protocol = location.protocol === ""https:"" ? ""wss:"" : ""ws:"";
        var wsUri = protocol + ""//"" + window.location.host;
        var socket = new WebSocket(wsUri);
        socket.onopen = e => {
			console.log(""socket opened"", e);

			var lineArray = chatHistory.split(""|"");
			for (var i = 1; i < lineArray.length; i++) {

				$('.messages ul').append('<li class=""replies""><p id=""reply2"">' + lineArray[i] + '<br/></p></li >')
			}
        };

        socket.onclose = function (e) {
            console.log(""socket closed"", e);
        };

        socket.onmessage = function (e) {
			console.log(e);
			$('.messages ul').append('<li class=""replies""><p id=""reply2"">'+ e.data+'<br/></p></li >')

        };

        socket.onerror = function (e) {
            console.error(e.data);
		};

        $('#MessageField').keypress(function (e) {
            if (e.which != 13) {
                return;
			}

			e.preventDefault();

			var");
                WriteLiteral(" message = $(\'#MessageField\').val();\r\n\r\n\t\t\tsocket.send(message);\r\n\r\n\t\t\t$(\'#MessageField\').val(\'\');\r\n\r\n\t\t});\r\n\r\n    });\r\n\t</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591