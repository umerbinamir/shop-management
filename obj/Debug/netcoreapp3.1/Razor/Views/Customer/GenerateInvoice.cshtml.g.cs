#pragma checksum "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c7062c7e958bc0bf9135a9a234d244f79d3d862ed5ac8f8eda658475ae9b4e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GenerateInvoice), @"mvc.1.0.view", @"/Views/Customer/GenerateInvoice.cshtml")]
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
#line 1 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\_ViewImports.cshtml"
using SDP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\_ViewImports.cshtml"
using SDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c7062c7e958bc0bf9135a9a234d244f79d3d862ed5ac8f8eda658475ae9b4e36", @"/Views/Customer/GenerateInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1c626665d1d957a06d00149d99b49b2d200b41f90791f01dd02b42fe620f0f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_GenerateInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SDP.Models.Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/invoice.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MailInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
  
    ViewData["Title"] = "GenerateInvoice";
    DateTime dateTime = new DateTime();

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css\" rel=\"stylesheet\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7062c7e958bc0bf9135a9a234d244f79d3d862ed5ac8f8eda658475ae9b4e365146", async() => {
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
            WriteLiteral("\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.9.2/html2pdf.bundle.js\"></script>\n");
            WriteLiteral(@"<div class=""container bootstrap snippets bootdeys  events-area section-padding-100"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""panel panel-default invoice"" id=""invoice"">
                <div class=""panel-body"" id=""invoice"">
                    <div class=""invoice-ribbon""><div class=""ribbon-inner"">PAID</div></div>
                    <div class=""row"">

                        <div class=""col-sm-6 top-left"">
                            <i class=""fa fa-rocket""></i>
                        </div>

                        <div class=""col-sm-6 top-right"">
                            <h3 class=""marginright"">INVOICE</h3>
                            <span class=""marginright"">");
#nullable restore
#line 52 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                 Write(DateTime.Now.ToString("dd/mm/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";</span>
                        </div>

                    </div>
                    <hr>
                    <div class=""row"">

                        <div class=""col-xs-4 from"">
                            <p class=""lead marginbottom"">From : One Sound</p>

                        </div>

                        <div class=""col-xs-4 to"">
                            <p class=""lead marginbottom"">To : ");
#nullable restore
#line 65 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                         Write(ViewBag.customer_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n\n\n                        </div>\n\n                        <div class=\"col-xs-4 text-right payment-details\">\n                            <p class=\"lead marginbottom payment-info\">Payment details</p>\n                            <p>Date: ");
#nullable restore
#line 72 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                Write(DateTime.Now.ToString("dd/mm/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\n                            <p>VAT: DK888-777 </p>\n                            <p>Total Amount: ");
#nullable restore
#line 74 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                        Write(ViewBag.total_amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\n                            <p>Account Name: ");
#nullable restore
#line 75 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                        Write(ViewBag.customer_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        </div>

                    </div>

                    <div class=""row table-row"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th class=""text-center"" style=""width:5%"">#</th>
                                    <th style=""width:50%"">Item</th>
                                    <th class=""text-right"" style=""width:15%"">Quantity</th>
");
            WriteLiteral("                                    <th class=\"text-right\" style=\"width:15%\">Total Price</th>\n                                </tr>\n                            </thead>\n                            <tbody>\n");
#nullable restore
#line 92 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                   var count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                 foreach (var order in Model)
                                {
                                    if (order.customerId == ViewBag.customer_Id)
                                    {
                                        count = count + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td class=\"text-center\">");
#nullable restore
#line 99 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 100 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                           Write(order.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-right\">");
#nullable restore
#line 101 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                              Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-right\">");
#nullable restore
#line 102 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                              Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 104 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>

                    </div>

                    <div class=""row"">

                        <div class=""col-xs-6 text-right pull-right invoice-total"">
                            <p style="" margin-left: 800px; "">Subtotal : ");
#nullable restore
#line 114 "G:\Uni Projects\VP\Shop-Management-System-main\SDP\Views\Customer\GenerateInvoice.cshtml"
                                                                   Write(ViewBag.total_amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" INR</p>
                            <p style="" margin-left: 800px; "">Discount : Not available </p>

                        </div>
                    </div>

                </div>
                <div>
                    <div class=""col-xs-6 margintop"">
                        <p class=""lead marginbottom"">THANK YOU!</p>

                        <button class=""btn btn-success"" id=""download""><i class=""fa fa-print""></i> Print Invoice</button>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7062c7e958bc0bf9135a9a234d244f79d3d862ed5ac8f8eda658475ae9b4e3613696", async() => {
                WriteLiteral("<i class=\"fa fa-envelope-o\"></i> Mail Invoice");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    window.onload = function () {
        document.getElementById(""download"")
            .addEventListener(""click"", () => {
                const invoice = this.document.getElementById(""invoice"");
                console.log(invoice);
                console.log(window);
                var opt = {
                    margin: 1,
                    filename: 'myfile.pdf',
                    image: { type: 'jpeg', quality: 0.98 },
                    html2canvas: { scale: 2 },
                    jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
                };
                html2pdf().from(invoice).set(opt).save();
            })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SDP.Models.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
