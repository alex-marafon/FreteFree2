#pragma checksum "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9383d3a7560c89d4e1f9252642013786082636f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemCarregamento__Delete_Delete), @"mvc.1.0.view", @"/Views/OrdemCarregamento/_Delete_Delete.cshtml")]
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
#line 1 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\_ViewImports.cshtml"
using FreteFree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\_ViewImports.cshtml"
using FreteFree.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9383d3a7560c89d4e1f9252642013786082636f3", @"/Views/OrdemCarregamento/_Delete_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7671106d954bc6331e33885c5d2ac36d82b7a825", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemCarregamento__Delete_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreteFree.Models.Motorista.OrdemCarregamento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>OrdemCarregamento</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empresa.CidadeEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MotoristaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.MotoristaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Medida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.Medida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataOrdemCarregamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataOrdemCarregamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Trut4\Source\Repos\FreteFree2\FreteFree\Views\OrdemCarregamento\_Delete_Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreteFree.Models.Motorista.OrdemCarregamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
