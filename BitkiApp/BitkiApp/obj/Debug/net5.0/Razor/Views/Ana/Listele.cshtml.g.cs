#pragma checksum "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46729018e343fa9be7b05acfd634f1d6fa04a97c4e126e3f12c2cd1437df3213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ana_Listele), @"mvc.1.0.view", @"/Views/Ana/Listele.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\_ViewImports.cshtml"
using BizimBotanikApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"46729018e343fa9be7b05acfd634f1d6fa04a97c4e126e3f12c2cd1437df3213", @"/Views/Ana/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dbc027fd2e2e8cfed88866d49fda7c0c1f1cba3a01ccabd2fc1a875d10c08dd8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ana_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListeleViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46729018e343fa9be7b05acfd634f1d6fa04a97c4e126e3f12c2cd1437df32133186", async() => {
                WriteLiteral("\r\n    <title>Bizim Botanik</title>\r\n    <link rel=\"stylesheet\" href=\"/css/styletwo.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46729018e343fa9be7b05acfd634f1d6fa04a97c4e126e3f12c2cd1437df32134272", async() => {
                WriteLiteral(@"
    
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 mt-6"">
                <div class=""list-group"">
                    <a href=""/Listele"" class=""list-group-item list-group-item-action"" aria-current=""true"">
                        Tüm Bitkiler
                    </a>
");
#nullable restore
#line 15 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                     foreach (var kategori in Model.Kategoriler)
                    {
                        if (ViewBag.kategoriId == kategori.Id)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 665, "\"", 699, 2);
                WriteAttributeValue("", 672, "/ana/Listele/", 672, 13, true);
#nullable restore
#line 19 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
WriteAttributeValue("", 685, kategori.Id, 685, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action active\">");
#nullable restore
#line 19 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                                                                                                                   Write(kategori.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 887, "\"", 921, 2);
                WriteAttributeValue("", 894, "/ana/Listele/", 894, 13, true);
#nullable restore
#line 23 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
WriteAttributeValue("", 907, kategori.Id, 907, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 23 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                                                                                                            Write(kategori.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                        }
                        
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"col-md-9 mt-6\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 32 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                     if (Model.Cicekler.Count == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-info\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                       Write(Model.Kategori.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" kategorisinde ürün bulunmamaktadadır.\r\n                        </div>\r\n");
#nullable restore
#line 37 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p class=\"display-7 text-center text-danger\">");
#nullable restore
#line 40 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                                                                Write(Model.Kategori.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Ürünleri</p>\r\n");
#nullable restore
#line 41 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                        foreach (var cicek in Model.Cicekler)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-lg-6 mb-3\">\r\n                                <div class=\"card py-4 px-2\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1859, "\"", 1884, 2);
                WriteAttributeValue("", 1865, "/img/", 1865, 5, true);
#nullable restore
#line 45 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
WriteAttributeValue("", 1870, cicek.Resim, 1870, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin:auto; height:400px; width:350px\" class=\"card-img-top\" alt=\"...\">\r\n                                    <div class=\"card-body text-center\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 47 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                                                          Write(cicek.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                        <h4 class=\"card-title text-info\">");
#nullable restore
#line 48 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                                                                    Write(cicek.Aciklama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 2255, "\"", 2287, 2);
                WriteAttributeValue("", 2262, "/ana/Hakkinda/", 2262, 14, true);
#nullable restore
#line 49 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
WriteAttributeValue("", 2276, cicek.Id, 2276, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Detayı Gör</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 53 "C:\Users\bakka\OneDrive\Masaüstü\BitkiApp\BitkiApp\Views\Ana\Listele.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListeleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
