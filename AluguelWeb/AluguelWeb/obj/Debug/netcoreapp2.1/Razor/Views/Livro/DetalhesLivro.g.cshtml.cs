#pragma checksum "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7020ee3670592ca66d3ea247dbd75f7c1b1b195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_DetalhesLivro), @"mvc.1.0.view", @"/Views/Livro/DetalhesLivro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/DetalhesLivro.cshtml", typeof(AspNetCore.Views_Livro_DetalhesLivro))]
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
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\_ViewImports.cshtml"
using AluguelWeb;

#line default
#line hidden
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\_ViewImports.cshtml"
using AluguelWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7020ee3670592ca66d3ea247dbd75f7c1b1b195", @"/Views/Livro/DetalhesLivro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e04a3b660597a82f65f5c0702ed6b525deab2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_DetalhesLivro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AluguelWeb.Models.Entidades.Livro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
  
    ViewData["Title"] = "DetalhesLivro";

#line default
#line hidden
            BeginContext(93, 129, true);
            WriteLiteral("\r\n<h2>Detalhes do Livro</h2>\r\n\r\n<div>\r\n    <h4>Livro</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(223, 38, false);
#line 14 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 34, false);
#line 17 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(383, 40, false);
#line 20 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 36, false);
#line 23 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(503, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Codigo Autor\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(602, 39, false);
#line 29 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayFor(model => model.AutorID));

#line default
#line hidden
            EndContext();
            BeginContext(641, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Codigo Editora\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(742, 41, false);
#line 35 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayFor(model => model.EditoraID));

#line default
#line hidden
            EndContext();
            BeginContext(783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(827, 42, false);
#line 38 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(913, 38, false);
#line 41 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(951, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(999, 75, false);
#line 46 "C:\Users\gabri\OneDrive\Área de Trabalho\DesafioCast\AluguelWeb\AluguelWeb\Views\Livro\DetalhesLivro.cshtml"
Write(Html.ActionLink("Edit", "EdicaoLivro", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1082, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "335851e06ce54d75a9a37a70f137bb1e", async() => {
                BeginContext(1104, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1120, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AluguelWeb.Models.Entidades.Livro> Html { get; private set; }
    }
}
#pragma warning restore 1591
