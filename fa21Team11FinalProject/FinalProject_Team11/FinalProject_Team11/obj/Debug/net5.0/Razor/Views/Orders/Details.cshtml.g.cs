#pragma checksum "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1dd3038567775d9e7b5aed3e6e67dd8dac37fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_Team11.Views.Orders.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
namespace FinalProject_Team11.Views.Orders
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
#line 13 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\_ViewImports.cshtml"
using FinalProject_Team11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dd3038567775d9e7b5aed3e6e67dd8dac37fba", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649865e2201ccd796a1943f5083fd2adea151ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject_Team11.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Review Your Order</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(ModelItem => ModelItem.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(ModelItem => ModelItem.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(ModelItem => ModelItem.User.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(ModelItem => ModelItem.User.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(ModelItem => ModelItem.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(ModelItem => ModelItem.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(ModelItem => ModelItem.OrderNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(ModelItem => ModelItem.OrderNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>


    </dl>
</div>

<h5>Properties on this Order</h5>
<table class=""table table-primary"">
    <tr>
        <th>Check-in Date</th>
        <th>Check-out Date</th>
        <th>Address</th>
        <th>City</th>
        <th>State</th>
        <th>CleaningFee</th>
        <th>Guests Number</th>
        <th>Stay Price</th>
        <th>Discount Percentage</th>
        <th>Will get a discount if reservation days larger than:</th>
        <th>Subtotal</th>
        <th>Individual Reservation Total</th>

    </tr>
");
#nullable restore
#line 61 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
     foreach (Reservation r in Model.Reservations)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Checkin_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 65 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Checkout_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.PropertyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 67 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 68 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.PropertyState));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 69 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 70 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.PropertyGuest));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 71 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.StayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 72 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.DiscountPercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 73 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Property.DiscountNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 74 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 75 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
   Write(Html.DisplayFor(ModelItem => r.TotalFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n</tr>");
#nullable restore
#line 78 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<h5>Order Summary</h5>\r\n<table class=\"table table-sm table-bordered\" style=\"width:30%\">\r\n    <tr>\r\n        <th colspan=\"2\" style=\"text-align:center\">Order Summary</th>\r\n    </tr>\r\n    <tr>\r\n        <td>Order Subtotal:</td>\r\n        <td>");
#nullable restore
#line 87 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Sales Tax:</td>\r\n        <td>");
#nullable restore
#line 91 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Order Total:</td>\r\n        <td>");
#nullable restore
#line 95 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n<div> \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1dd3038567775d9e7b5aed3e6e67dd8dac37fba13225", async() => {
                WriteLiteral("Edit Your Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1dd3038567775d9e7b5aed3e6e67dd8dac37fba15404", async() => {
                WriteLiteral("Confirm Your order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Orders\Details.cshtml"
                                                           WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1dd3038567775d9e7b5aed3e6e67dd8dac37fba17845", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject_Team11.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591