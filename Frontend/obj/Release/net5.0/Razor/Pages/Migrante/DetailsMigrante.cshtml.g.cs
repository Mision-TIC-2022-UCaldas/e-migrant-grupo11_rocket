#pragma checksum "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb7239009e9f2f422e9a2fc5efd1ee0a1c852922"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Migrante.Pages_Migrante_DetailsMigrante), @"mvc.1.0.razor-page", @"/Pages/Migrante/DetailsMigrante.cshtml")]
namespace Frontend.Pages.Migrante
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
#line 1 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7239009e9f2f422e9a2fc5efd1ee0a1c852922", @"/Pages/Migrante/DetailsMigrante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_DetailsMigrante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListMigrante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalle de Informacion Personal</h1>\r\n<small>\r\n</small>\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 12 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 15 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 20 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 28 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => model.migrante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => model.migrante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd> \r\n    </div>   \r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n");
#nullable restore
#line 36 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
             switch (Model.migrante.TipoDocumento)
            {
                case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Cedula de ciudadania</a>\r\n");
#nullable restore
#line 39 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
                break;             
                case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Cedula de Extranjeria</a>\r\n");
#nullable restore
#line 41 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
                break;
                case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Tarjeta de Identidad</a>\r\n");
#nullable restore
#line 43 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
                break;
                case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Pasaporte</a>\r\n");
#nullable restore
#line 45 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
                break;
                case 5:

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Permiso Especial de Permanencia</a>\r\n");
#nullable restore
#line 47 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
                break;                                              
            }            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 51 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => model.migrante.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 56 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 59 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 64 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 67 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 72 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 75 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 80 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 83 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 88 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 91 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 96 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 99 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 104 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.SituacionLaboral));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n        ");
#nullable restore
#line 107 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Migrante\DetailsMigrante.cshtml"
   Write(Html.DisplayFor(model => Model.migrante.SituacionLaboral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>    \r\n</div>\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb7239009e9f2f422e9a2fc5efd1ee0a1c85292213083", async() => {
                WriteLiteral("<i class=\"fas fa-angle-double-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsMigranteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsMigranteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsMigranteModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsMigranteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
