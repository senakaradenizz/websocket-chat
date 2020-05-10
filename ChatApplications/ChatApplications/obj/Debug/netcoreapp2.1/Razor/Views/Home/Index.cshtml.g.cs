#pragma checksum "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1ba91a522dbb7e81aae607990bd824572c7083"
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
#line 1 "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using ChatApplications;

#line default
#line hidden
#line 2 "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using ChatApplications.Models;

#line default
#line hidden
#line 4 "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1ba91a522dbb7e81aae607990bd824572c7083", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cd8ae7341fdbfb5c75b02dac9f636f81056be9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 734, true);
            WriteLiteral(@"<style>
    body {
        margin: 0px;
        padding: 0px;
    }

    .msg {
        position: absolute;
        top: 20px;
        bottom: 30px;
        border: 0.5px solid black;
        margin-bottom: auto;
        display: block;
        overflow: scroll;
        width: 50%;
        height: 50%;
        white-space: nowrap;
    }
</style>
<div class=""msg"">
    <div style=""position:absolute; bottom: 10px; margin-left: 10px;"" id=""msgs""></div>
</div>

<div style=""position:absolute;height:30px;bottom:430px; display:block;width:50%"">
    <input type=""text"" style=""max-width: unset; width: 100%; max-width: 100%; bottom: 10px;"" id=""MessageField"" placeholder=""type message and press enter"" />
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(812, 61, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n        var userName = \'");
                EndContext();
                BeginContext(874, 5, false);
#line 35 "C:\Repositories\websocket-chat\ChatApplications\ChatApplications\Views\Home\Index.cshtml"
                   Write(Model);

#line default
#line hidden
                EndContext();
                BeginContext(879, 952, true);
                WriteLiteral(@"';

        var protocol = location.protocol === ""https:"" ? ""wss:"" : ""ws:"";
        var wsUri = protocol + ""//"" + window.location.host;
        var socket = new WebSocket(wsUri);
        socket.onopen = e => {
            console.log(""socket opened"", e);
        };

        socket.onclose = function (e) {
            console.log(""socket closed"", e);
        };

        socket.onmessage = function (e) {
            console.log(e);
            $('#msgs').append(e.data + '<br />');
        };

        socket.onerror = function (e) {
            console.error(e.data);
        };

        $('#MessageField').keypress(function (e) {
            if (e.which != 13) {
                return;
            }

            e.preventDefault();

            var message = userName + "": "" + $('#MessageField').val();
            socket.send(message);
            $('#MessageField').val('');
        });
    });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
