#pragma checksum "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7773589a833ffeea403109f8f2dfdb5f831e06c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fotoes_Recientes), @"mvc.1.0.view", @"/Views/Fotoes/Recientes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fotoes/Recientes.cshtml", typeof(AspNetCore.Views_Fotoes_Recientes))]
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
#line 1 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\_ViewImports.cshtml"
using InstaFeiGram;

#line default
#line hidden
#line 2 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\_ViewImports.cshtml"
using InstaFeiGram.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7773589a833ffeea403109f8f2dfdb5f831e06c3", @"/Views/Fotoes/Recientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06164fb4b613aaff78cff7a90170043e03b1a211", @"/Views/_ViewImports.cshtml")]
    public class Views_Fotoes_Recientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InstaFeiGram.Models.Foto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
  
    ViewData["Title"] = "Recientes";

#line default
#line hidden
            BeginContext(93, 30, true);
            WriteLiteral("\r\n<h2>Recientes</h2>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(156, 109, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\"></div>\r\n        <div class=\"col-md-4\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 265, "\"", 295, 2);
            WriteAttributeValue("", 271, "\\images\\", 271, 8, true);
#line 17 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
WriteAttributeValue("", 279, item.rutaimagen, 279, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 296, "\"", 315, 1);
#line 17 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
WriteAttributeValue("", 302, item.resumen, 302, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 80, true);
            WriteLiteral(" class=\"img-thumbnail\">\r\n            <div class=\"caption\">\r\n                <h3>");
            EndContext();
            BeginContext(397, 11, false);
#line 19 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
               Write(item.titulo);

#line default
#line hidden
            EndContext();
            BeginContext(408, 28, true);
            WriteLiteral("</h3>\r\n                <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 436, "\"", 482, 2);
            WriteAttributeValue("", 443, "/Comentarios/Create?FotoId=", 443, 27, true);
#line 20 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
WriteAttributeValue("", 470, item.idfoto, 470, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(483, 98, true);
            WriteLiteral(" class=\"btn btn-sm btn-primary\" role=\"button\">Comentarios</a></p>\r\n                |<a class=\"btn\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 581, "\"", 624, 2);
            WriteAttributeValue("", 588, "/Fotoes/DarGusta?idFoto=", 588, 24, true);
#line 21 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
WriteAttributeValue("", 612, item.idfoto, 612, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(625, 32, true);
            WriteLiteral(">Me gusta</a>|\r\n                ");
            EndContext();
            BeginContext(657, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd83a2f79d7e4cf581b231131ebe6ab1", async() => {
                BeginContext(709, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
                                          WriteLiteral(item.idfoto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(721, 89, true);
            WriteLiteral("|\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\"></div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\EHECA\source\repos\InstaFeiGram\InstaFeiGram\Views\Fotoes\Recientes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InstaFeiGram.Models.Foto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
