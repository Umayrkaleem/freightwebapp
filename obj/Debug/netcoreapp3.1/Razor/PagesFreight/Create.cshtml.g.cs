#pragma checksum "/Users/umayr/Documents/freightWebApp/PagesFreight/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459e9cd754d9da3dcd07eb2543e9ab18956eaf53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PagesFreight_Create), @"mvc.1.0.razor-page", @"/PagesFreight/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459e9cd754d9da3dcd07eb2543e9ab18956eaf53", @"/PagesFreight/Create.cshtml")]
    public class PagesFreight_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/umayr/Documents/freightWebApp/PagesFreight/Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Freight</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Freight.BrokerName"" class=""control-label""></label>
                <input asp-for=""Freight.BrokerName"" class=""form-control"" />
                <span asp-validation-for=""Freight.BrokerName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Freight.Date"" class=""control-label""></label>
                <input asp-for=""Freight.Date"" class=""form-control"" />
                <span asp-validation-for=""Freight.Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Freight.Commodity"" class=""control-label""></label>
                <input asp-for=""Freight.Commodity"" class=""form-control"" />
                <span");
            WriteLiteral(@" asp-validation-for=""Freight.Commodity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Freight.Linehaul"" class=""control-label""></label>
                <input asp-for=""Freight.Linehaul"" class=""form-control"" />
                <span asp-validation-for=""Freight.Linehaul"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "/Users/umayr/Documents/freightWebApp/PagesFreight/Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<freightWebApp.PagesFreight.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<freightWebApp.PagesFreight.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<freightWebApp.PagesFreight.CreateModel>)PageContext?.ViewData;
        public freightWebApp.PagesFreight.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
