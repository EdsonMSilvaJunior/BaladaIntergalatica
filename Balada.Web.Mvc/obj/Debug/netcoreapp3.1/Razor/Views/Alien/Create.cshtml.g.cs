#pragma checksum "C:\Users\Edson\Desktop\BaladaIntergalatica\Balada.Web.Mvc\Views\Alien\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828e9379d88ad902e98591b01e78ddba93a1041c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alien_Create), @"mvc.1.0.view", @"/Views/Alien/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828e9379d88ad902e98591b01e78ddba93a1041c", @"/Views/Alien/Create.cshtml")]
    public class Views_Alien_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balada.Web.Mvc.Models.Insert.AlienInsertViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Edson\Desktop\BaladaIntergalatica\Balada.Web.Mvc\Views\Alien\Create.cshtml"
  
    ViewData["Title"] = "Aliens";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Aliens</h1style=""text-align:center"">
<hr />
<div style=""text-align:center"" class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" Placeholder=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataNascimento"" class=""control-label""></label>
                <input asp-for=""DataNascimento"" Placeholder=""Data de Nascimento"" class=""form-control"" />
                <span asp-validation-for=""DataNascimento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Objeto"" class=""control-label""></label>
                <input asp-fo");
            WriteLiteral(@"r=""Objeto"" Placeholder=""Objetos"" class=""form-control"" />
                <span asp-validation-for=""Objeto"" class=""text-danger""></span>
            </div><br />
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
    <div>
        <button onclick=""chamaHome()"">Home</button>
        <script>
            function chamaHome() {
                window.location = ""https://localhost:44378/"";
            }
        </script>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Edson\Desktop\BaladaIntergalatica\Balada.Web.Mvc\Views\Alien\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balada.Web.Mvc.Models.Insert.AlienInsertViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
