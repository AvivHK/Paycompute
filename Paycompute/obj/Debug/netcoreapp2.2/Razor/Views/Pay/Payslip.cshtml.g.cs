#pragma checksum "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3baced3d68be4038402e588cc514c12fa26edb83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_Payslip), @"mvc.1.0.view", @"/Views/Pay/Payslip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pay/Payslip.cshtml", typeof(AspNetCore.Views_Pay_Payslip))]
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
#line 1 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3baced3d68be4038402e588cc514c12fa26edb83", @"/Views/Pay/Payslip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b159a1e9feef9039727131d2d4070f602f1724", @"/Views/_ViewImports.cshtml")]
    public class Views_Pay_Payslip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentRecordDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
   ViewBag.Title = "Payslip";

#line default
#line hidden
            BeginContext(68, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
   Layout = null;

#line default
#line hidden
            BeginContext(88, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(89, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3baced3d68be4038402e588cc514c12fa26edb834440", async() => {
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
            BeginContext(160, 537, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-md-3 pl-0"">
                        <p class=""mt-5 mb-2""><b>PayCompute Ltd</b></p>
                        <p>11 Downing Street<br />London<br />W1C 2XB</p>
                    </div>
                    <div class=""col-md-3 pr-0"">
                        <p class=""mt-5 mb-2 text-right""><b>Pay Date: ");
            EndContext();
            BeginContext(698, 36, false);
#line 19 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                                Write(Model.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(734, 65, true);
            WriteLiteral("</b></p>\n                        <p class=\"text-right\">Tax Code: ");
            EndContext();
            BeginContext(800, 13, false);
#line 20 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                   Write(Model.TaxCode);

#line default
#line hidden
            EndContext();
            BeginContext(813, 12, true);
            WriteLiteral("<br />Year: ");
            EndContext();
            BeginContext(826, 10, false);
#line 20 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                                             Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(836, 186, true);
            WriteLiteral("<br />HMRC</p>\n                    </div>\n                </div><br /><br />\n\n                <div class=\"col-md-12 row\">\n                    <div class=\"col-md-8\"><h5>Employee\'s Name : ");
            EndContext();
            BeginContext(1023, 14, false);
#line 25 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                           Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 86, true);
            WriteLiteral("</h5></div>\n                    <div class=\"col-md-4\"><h5>National Insurance Number : ");
            EndContext();
            BeginContext(1124, 10, false);
#line 26 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.NiNo);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 800, true);
            WriteLiteral(@"</h5></div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 table-responsive-md"">
                    <table class=""table table-striped"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Earnings</th>
                                <th>Hours</th>
                                <th>Rates</th>
                                <th>Amount</th>
                                <th>Deductions</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Basic :</b></td>
                                <td>");
            EndContext();
            BeginContext(1935, 36, false);
#line 45 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2014, 30, false);
#line 46 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HourlyRate.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2087, 39, false);
#line 47 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 96, true);
            WriteLiteral("</td>\n                                <td><b>Tax :</b></td>\n                                <td>");
            EndContext();
            BeginContext(2223, 23, false);
#line 49 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.Tax.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 168, true);
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td><b>Overtime :</b></td>\n                                <td>");
            EndContext();
            BeginContext(2415, 33, false);
#line 53 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2448, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2491, 33, false);
#line 54 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeRate.ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(2524, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2567, 36, false);
#line 55 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 96, true);
            WriteLiteral("</td>\n                                <td><b>NIC :</b></td>\n                                <td>");
            EndContext();
            BeginContext(2700, 23, false);
#line 57 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.NIC.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2723, 333, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>Union :</b></td>
                                <td>");
            EndContext();
            BeginContext(3057, 34, false);
#line 65 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.UnionFee.Value.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 331, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>SLC :</b></td>
                                <td>");
            EndContext();
            BeginContext(3423, 29, false);
#line 73 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.SLC.Value.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3452, 165, true);
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td><b>Total :</b></td>\n                                <td>");
            EndContext();
            BeginContext(3618, 17, false);
#line 77 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HoursWorked);

#line default
#line hidden
            EndContext();
            BeginContext(3635, 84, true);
            WriteLiteral("</td>\n                                <td></td>\n                                <td>");
            EndContext();
            BeginContext(3720, 33, false);
#line 79 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3753, 84, true);
            WriteLiteral("</td>\n                                <td></td>\n                                <td>");
            EndContext();
            BeginContext(3838, 34, false);
#line 81 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalDeduction.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3872, 438, true);
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class=""table-dark""><b>NET PAY :</b></td>
                                <td class=""table-dark"">");
            EndContext();
            BeginContext(4311, 30, false);
#line 91 "C:\Users\avivhkn\Desktop\Pay-Compute-master\Paycompute\Views\Pay\Payslip.cshtml"
                                                  Write(Model.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4341, 176, true);
            WriteLiteral("</td>\n                            </tr>\n                        </tfoot>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentRecordDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591