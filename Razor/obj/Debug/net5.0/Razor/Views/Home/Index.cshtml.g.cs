#pragma checksum "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48214c0201c85e0b1e5618f9e4f676e3103a132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\_ViewImports.cshtml"
using Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\_ViewImports.cshtml"
using Razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48214c0201c85e0b1e5618f9e4f676e3103a132", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/FeatureRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"	<!-- Begin View Wrapper -->
        <div id=""page-wrapper"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h1 class=""page-header"">
                        Welcome to the Ordering Application! <br />
                        <small>Here you can manage inventory and orders for our customers.</small>
                    </h1>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h3>Pending Orders</h3>
                        </div>
                        <div class=""panel-body"">
                            <div class=""list-group"">
");
#nullable restore
#line 19 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml"
                                  
                                    foreach (var order in ViewBag.Orders)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\" class=\"list-group-item\">\r\n                                            <h4 class=\"list-group-item-heading\">");
#nullable restore
#line 23 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml"
                                                                           Write(order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <span class=\"pull-right\">Last Updated: ");
#nullable restore
#line 24 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml"
                                                                                  Write(order.LastUpdated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                            <p class=\"list-group-item-text\">");
#nullable restore
#line 25 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml"
                                                                       Write(order.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <div class=""progress"">
                                                <div class=""progress-bar progress-bar-success progress-bar-striped"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%"">
                                                    <span class=""sr-only"">40% Complete (success)</span>
                                                </div>
                                            </div>
                                        </a>
");
#nullable restore
#line 32 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              
                            </div>
                        </div>
                        <div class=""panel-footer"">
                            <a class=""pull-right btn btn-primary"" href=""#"">See all</a> <br />
                            <span class=""clearfix""></span>
                        </div>
                    </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""panel panel-primary widget"">
                            <div class=""panel-heading"">
                                <div class=""row"">
                                    <div class=""col-xs-3"">
                                        <i class=""fa fa-comments fa-3x""></i>
                                    </div>
                                    <div class=""col-xs-9 text-right"">
                                        <h3>Coolest Product</h3>
                                    </div>
                                </div>
        ");
            WriteLiteral(@"                    </div>
                            <div class=""widget-display"">
                                <table class=""table table-fluid table-striped"">
                                    <thead>
                                        <tr>
                                            <th>Product</th>
                                            <th>Add Vote</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>Life Size Cutouts</td>
                                            <td><a href=""#"" class=""vote-up"" data-userid=""3"">Vote Up</a></td>
                                        </tr>
                                        <tr>
                                            <td>Glow in the Dark Pens</td>
                                            <td><a href=""#"" class=""vote-up"" data-userid=""4"">Vote Up</a></t");
            WriteLiteral(@"d>
                                        </tr>
                                        <tr>
                                            <td>Flags</td>
                                            <td><a href=""#"" class=""vote-up"" data-userid=""2"">Vote Up</a></td>
                                        </tr>
                                        <tr>
                                            <td>Banners</td>
                                            <td><a href=""#"" class=""vote-up"" data-userid=""1"">Vote Up</a></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <div class=""panel panel-green widget"">
                            <div class=""panel-heading"">
                                <div class=""row"">
                                    <div class=""col-xs-3"">
                                        <i class=""fa fa-t");
            WriteLiteral(@"asks fa-3x""></i>
                                    </div>
                                    <div class=""col-xs-9 text-right"">
                                        <h3>Idea Center</h3>
                                    </div>
                                </div>
                            </div>
                            <div class=""panel-body"">
                                <div class=""row"">
                                    <div class=""col-xs-12 feature-request"">
                                        <p>Have an idea for new marketing materials or methods? Don't keep it to yourself!</p>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48214c0201c85e0b1e5618f9e4f676e3103a13210828", async() => {
                WriteLiteral(@"
                                            
                                            <input type=""text"" class=""form-control"" placeholder=""Subject ""/> <br />
                                            <textarea class=""form-control"" id=""suggestion"" rows=""5"" type=""text"" placeholder=""Description"" name=""suggestion""></textarea><br />
                                            <input type=""submit"" value=""Submit"" class=""improvement btn btn-primary pull-right"" />
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            </div>
			<!-- End View Wrapper -->
");
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