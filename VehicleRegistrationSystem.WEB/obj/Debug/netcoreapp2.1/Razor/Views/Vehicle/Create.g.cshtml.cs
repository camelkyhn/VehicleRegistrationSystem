#pragma checksum "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0947cece400ea94a5b49c90986ef8cdf84ef0a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Create), @"mvc.1.0.view", @"/Views/Vehicle/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/Create.cshtml", typeof(AspNetCore.Views_Vehicle_Create))]
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
#line 1 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/_ViewImports.cshtml"
using VehicleRegistrationSystem.WEB;

#line default
#line hidden
#line 2 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/_ViewImports.cshtml"
using VehicleRegistrationSystem.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0947cece400ea94a5b49c90986ef8cdf84ef0a76", @"/Views/Vehicle/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f187a9a272ad0a0ba5875e29a2f01bbbb88092", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRegistrationSystem.Common.Entities.Vehicle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(117, 18, true);
            WriteLiteral("\n<h2>Create</h2>\n\n");
            EndContext();
#line 10 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(168, 23, false);
#line 12 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(197, 90, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        \n        <h4>Vehicle</h4>\n        <hr/>\n        ");
            EndContext();
            BeginContext(288, 62, false);
#line 18 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
   Write(Html.ValidationSummary(true, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(350, 47, true);
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(398, 92, false);
#line 21 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.Brand, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(490, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(544, 90, false);
#line 23 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.Brand, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(634, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(652, 81, false);
#line 24 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Brand, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(733, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(815, 92, false);
#line 29 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.Model, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(907, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(961, 90, false);
#line 31 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.Model, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1069, 81, false);
#line 32 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Model, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1232, 91, false);
#line 37 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.Type, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1377, 89, false);
#line 39 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.Type, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1484, 80, false);
#line 40 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1646, 96, false);
#line 45 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.ModelYear, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1796, 94, false);
#line 47 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.ModelYear, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1908, 85, false);
#line 48 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.ModelYear, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(2075, 95, false);
#line 53 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.NickName, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(2224, 93, false);
#line 55 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.NickName, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2335, 84, false);
#line 56 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.NickName, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(2501, 92, false);
#line 61 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.Plate, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(2593, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(2647, 90, false);
#line 63 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.Plate, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(2737, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2755, 81, false);
#line 64 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Plate, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(2918, 92, false);
#line 69 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.Color, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(3064, 90, false);
#line 71 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.EditorFor(model => model.Color, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(3172, 81, false);
#line 72 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Color, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(3253, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(3335, 95, false);
#line 77 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
       Write(Html.LabelFor(model => model.IsActive, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
            EndContext();
            BeginContext(3430, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(3484, 95, false);
#line 79 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.CheckBoxFor(model => model.IsActive, new {htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
            EndContext();
            BeginContext(3579, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(3597, 84, false);
#line 80 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsActive, "", new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(3681, 245, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\"/>\n            </div>\n        </div>\n\n    </div>\n");
            EndContext();
#line 91 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRegistrationSystem.Common.Entities.Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
