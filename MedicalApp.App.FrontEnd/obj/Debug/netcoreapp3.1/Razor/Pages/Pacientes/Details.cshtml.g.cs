#pragma checksum "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75956681f1abf8dfb32d550db2a7367bc40f8d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MedicalApp.App.FrontEnd.Pages.Pacientes.Pages_Pacientes_Details), @"mvc.1.0.razor-page", @"/Pages/Pacientes/Details.cshtml")]
namespace MedicalApp.App.FrontEnd.Pages.Pacientes
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
#line 1 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\_ViewImports.cshtml"
using MedicalApp.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75956681f1abf8dfb32d550db2a7367bc40f8d32", @"/Pages/Pacientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae070de0db9d828f14bb774b4b875246be6a2212", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalle del paciente</h1> \r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\">Tipo Identificacion</th>\r\n        <td>");
#nullable restore
#line 9 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.TipoIdentificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Identificacion</th>\r\n        <td>");
#nullable restore
#line 13 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <td>");
#nullable restore
#line 17 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Apellidos</th>\r\n        <td>");
#nullable restore
#line 21 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Genero</th>\r\n        <td>");
#nullable restore
#line 25 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Telefono</th>\r\n        <td>");
#nullable restore
#line 29 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Correo</th>\r\n        <td>");
#nullable restore
#line 33 "C:\MedicalApp\proyecto-ciclo-3\MedicalApp.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75956681f1abf8dfb32d550db2a7367bc40f8d326025", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalApp.App.FrontEnd.Page.Pacientes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MedicalApp.App.FrontEnd.Page.Pacientes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MedicalApp.App.FrontEnd.Page.Pacientes.DetailsModel>)PageContext?.ViewData;
        public MedicalApp.App.FrontEnd.Page.Pacientes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
