#pragma checksum "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd38c7c443ebc55ec68ebc9b388a364bcf850f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_Team11.Views.Account.Views_Account_ChangeAdminUserStatus), @"mvc.1.0.view", @"/Views/Account/ChangeAdminUserStatus.cshtml")]
namespace FinalProject_Team11.Views.Account
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
#line 2 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
using FinalProject_Team11.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
using FinalProject_Team11.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd38c7c443ebc55ec68ebc9b388a364bcf850f9d", @"/Views/Account/ChangeAdminUserStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649865e2201ccd796a1943f5083fd2adea151ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangeAdminUserStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject_Team11.Models.AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Fire / Rehire Admin</h2>\r\n<h4>Fire Admin through activate the acccount / Rehire Admin through deactivate the account</h4>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
 using (Html.BeginForm("ChangeAdminUserStatus", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd38c7c443ebc55ec68ebc9b388a364bcf850f9d4777", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Is_Active);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n\r\n        <label class=\"radio\">");
#nullable restore
#line 17 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
                        Write(Html.RadioButton("SelectedUserStatus", UserStatusEnum.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Active    </label>\r\n        <label class=\"radio\">");
#nullable restore
#line 18 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
                        Write(Html.RadioButton("SelectedUserStatus", UserStatusEnum.Inactive));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Inactive</label>\r\n \r\n\r\n    </div>\r\n    <div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Change Admin Status\" class=\"btn btn-warning\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\ChangeAdminUserStatus.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject_Team11.Models.AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
