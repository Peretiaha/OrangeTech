#pragma checksum "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc3c5727fc109ce3921ac56d2e04508b2e994f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Work_Details), @"mvc.1.0.view", @"/Views/Work/Details.cshtml")]
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
#line 1 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\_ViewImports.cshtml"
using OrangeTech.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\_ViewImports.cshtml"
using OrangeTech.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc3c5727fc109ce3921ac56d2e04508b2e994f7", @"/Views/Work/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93dfcdadbfe69626c1d3e29cbf779cbcb2f4e5ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Work_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrangeTech.Models.Models.Work>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Works.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
  
    ViewData["Title"] = "Наши работы";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"left-side\">\r\n        <div id=\"img-container\" style=\"width: 500px\">\r\n            <img id=\"img\" height=\"300\" width=\"500\"");
            BeginWriteAttribute("src", " src=\"", 244, "\"", 319, 2);
            WriteAttributeValue("", 250, "data:image/jpeg;base64,", 250, 23, true);
#nullable restore
#line 9 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
WriteAttributeValue("", 273, Convert.ToBase64String(Model.Images[0].Img), 273, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
        <script>
            var options = {
                width: 500,
                zoomWidth: 500,
                offset: { vertical: 0, horizontal: 10 },
                scale: 1

            };
            var zoom = new ImageZoom(document.getElementById(""img-container""), options);

        </script>

        <div class=""portfolio"">
");
#nullable restore
#line 24 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
             foreach (var item in Model.Images)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"photo-item\" onclick=\"ChangeImage(event)\">\r\n                    <img height=\"50\" width=\"80\" class=\"image-fit\"");
            BeginWriteAttribute("src", " src=\"", 898, "\"", 962, 2);
            WriteAttributeValue("", 904, "data:image/jpeg;base64,", 904, 23, true);
#nullable restore
#line 27 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
WriteAttributeValue("", 927, Convert.ToBase64String(item.Img), 927, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>                \r\n");
#nullable restore
#line 29 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"right-side\">\r\n        <div class=\"work-name\">\r\n            <h4 class=\"work-name-text\">");
#nullable restore
#line 34 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        <div class=\"work-description\">\r\n            <p class=\"description-text\">\r\n                ");
#nullable restore
#line 38 "E:\Projects\OrangeTech\OrangeTech\OrangeTech.Web\Views\Work\Details.cshtml"
           Write(Model.FullDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>

    </div>
</div>

<script>
    

    function ChangeImage(event) {
        event = event || window.event;
        var targetElement = event.target || event.srcElement;

        if (targetElement.tagName == ""IMG"") {
            img.src = targetElement.getAttribute(""src"");
            zoom.kill();
            zoom = new ImageZoom(document.getElementById(""img-container""), options);
        }
    }

</script>


<div class=""bottom-container"">
    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc3c5727fc109ce3921ac56d2e04508b2e994f77894", async() => {
                WriteLiteral("Назад");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cc3c5727fc109ce3921ac56d2e04508b2e994f79076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrangeTech.Models.Models.Work> Html { get; private set; }
    }
}
#pragma warning restore 1591
