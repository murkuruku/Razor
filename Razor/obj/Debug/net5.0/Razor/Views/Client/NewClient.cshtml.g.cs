#pragma checksum "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c63a25b6b31ead047ba00f9bd23abe420cdbb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_NewClient), @"mvc.1.0.view", @"/Views/Client/NewClient.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c63a25b6b31ead047ba00f9bd23abe420cdbb2", @"/Views/Client/NewClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_NewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Razor.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">
                Add a New Client <br />
                <small>We're always happy to gain new customers.</small>
            </h1>
        </div>
    </div>
   
");
#nullable restore
#line 15 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
     using (Html.BeginForm("NewClient", "Client", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 19 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.FirstName, "First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.LastName, "Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.CompanyName, "Company Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.CompanyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.Phone, "Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.Email, "Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.ContactDate, "Contact Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.ContactDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.ClientType, "Client Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.DropDownListFor(u => u.ClientType, FormDatHelper.GetClientTypes(), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.NearestLocation, "Client Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.DropDownListFor(u => u.ClientType, FormDatHelper.GetLocations(), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 54 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(await Component.InvokeAsync("InventoryWIdget", new { threshold = 20 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 form-group\">\r\n                ");
#nullable restore
#line 59 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(Html.LabelFor(u => u.Notes, "Notes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(Html.TextBoxFor(u => u.Notes, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 form-group\">\r\n                <label>Subscribe to:</label>\r\n                <div>\r\n");
#nullable restore
#line 67 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                     for (var i = 0; i < Model.EmailPromos.Count; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.CheckBoxFor(e => e.EmailPromos[i].IsSubscribed));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 70 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                         Write(Model.EmailPromos[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 71 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.HiddenFor(e => e.EmailPromos[i].Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.HiddenFor(e => e.EmailPromos[i].Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                                                                    
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <h3>Billing Address</h3>
                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        ");
#nullable restore
#line 82 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 83 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.Street, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 86 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 87 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 92 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 93 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 96 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 97 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.Zip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <h3>Mailing Address</h3>
                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        ");
#nullable restore
#line 107 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 108 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.Street, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 111 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 112 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 117 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 118 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 121 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 122 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.Zip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <input type=\"submit\" class=\"pull-right btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 128 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Footer", async() => {
                WriteLiteral("\r\n    <p>Make sure to send new clients a welcome package.</p>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Razor.Services.IFormDataService FormDatHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Razor.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
