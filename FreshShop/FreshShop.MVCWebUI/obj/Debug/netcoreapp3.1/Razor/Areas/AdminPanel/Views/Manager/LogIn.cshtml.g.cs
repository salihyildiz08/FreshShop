#pragma checksum "C:\Users\eksen\Desktop\.NET proje\Proje\FreshShop\FreshShop.MVCWebUI\Areas\AdminPanel\Views\Manager\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812f66f00c96da76e4b51162659579ae4c81a6f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Manager_LogIn), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Manager/LogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812f66f00c96da76e4b51162659579ae4c81a6f6", @"/Areas/AdminPanel/Views/Manager/LogIn.cshtml")]
    public class Areas_AdminPanel_Views_Manager_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "812f66f00c96da76e4b51162659579ae4c81a6f63186", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<title>FreshShop</title>
	<!-- Tell the browser to be responsive to screen width -->
	<meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
	<!-- Bootstrap 3.3.7 -->
	<link rel=""stylesheet"" href=""/AdminPanelContent/bower_components/bootstrap/dist/css/bootstrap.min.css"">
	<!-- Font Awesome -->
	<link rel=""stylesheet"" href=""/AdminPanelContent/bower_components/font-awesome/css/font-awesome.min.css"">
	<!-- Ionicons -->
	<link rel=""stylesheet"" href=""/AdminPanelContent/bower_components/Ionicons/css/ionicons.min.css"">
	<!-- Theme style -->
	<link rel=""stylesheet"" href=""/AdminPanelContent/dist/css/AdminLTE.min.css"">
	<!-- iCheck -->
	<link rel=""stylesheet"" href=""/AdminPanelContent/plugins/iCheck/square/blue.css"">

	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->");
                WriteLiteral(@"
	<!--[if lt IE 9]>
	<script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
	<script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
	<![endif]-->
	<!-- Google Font -->
	<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "812f66f00c96da76e4b51162659579ae4c81a6f65602", async() => {
                WriteLiteral(@"
	<div class=""login-box"">
		<div class=""login-logo"">
			<a href=""../../index2.html""><b>FreshShop</b></a>
		</div>
		<!-- /.login-logo -->
		<div class=""login-box-body"">
			<p class=""login-box-msg"">Sign in to start your session</p>

			<form>
				<div class=""form-group has-feedback"">
					<input type=""text"" id=""txtUserName"" class=""form-control"" placeholder=""User Name"">
					<span class=""glyphicon glyphicon-user form-control-feedback""></span>
				</div>
				<div class=""form-group has-feedback"">
					<input type=""password"" id=""txtPassword"" class=""form-control"" placeholder=""Password"">
					<span class=""glyphicon glyphicon-lock form-control-feedback""></span>
				</div>
				<div class=""row"">
					<div class=""col-xs-8"">
						<div class=""checkbox icheck"">
							<label>
								<input type=""checkbox"" id=""remember""> Remember Me
							</label>
						</div>
					</div>
					<!-- /.col -->
					<div class=""col-xs-4"">
						<button type=""button"" id=""btnLogIn"" class=""btn btn-primary btn-block ");
                WriteLiteral(@"btn-flat"">Sign In</button>
					</div>
					<!-- /.col -->
				</div>
			</form>

			

			<a href=""#"">I forgot my password</a><br>
			

		</div>
		<!-- /.login-box-body -->
	</div>
	<!-- /.login-box -->
	<!-- jQuery 3 -->
	<script src=""/AdminPanelContent/bower_components/jquery/dist/jquery.min.js""></script>
	<!-- Bootstrap 3.3.7 -->
	<script src=""/AdminPanelContent/bower_components/bootstrap/dist/js/bootstrap.min.js""></script>
	<!-- iCheck -->
	<script src=""/AdminPanelContent/plugins/iCheck/icheck.min.js""></script>




	<script>
		$(document).ready(function () {
			$(""#btnLogIn"").click(function () {

				var clientData = {
					UserName: $(""#txtUserName"").val(),
					Password: $(""#txtPassword"").val(),
					RememberMe: $(""#remember"").is(""checked""),
				};

				$.ajax({
					url: ""/admin"",
					method: ""post"",
					dataType: ""json"",
					data: { vm: clientData },
					success: function (resp) {
						if (resp.isOk)
							window.location.href = ""/AdminPanel/DashBoard/In");
                WriteLiteral(@"dex"";
						else
							alert(resp.message);
					}
				});
			});
		});


		$(function () {
    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' /* optional */
    });
		});
	</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
