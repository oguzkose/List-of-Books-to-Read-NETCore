#pragma checksum "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29cf13b32f79443cc4e3d265eac3b6274a9cdc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Add), @"mvc.1.0.view", @"/Views/Book/Add.cshtml")]
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
#line 1 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\_ViewImports.cshtml"
using Kodluyoruz_Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\_ViewImports.cshtml"
using Kodluyoruz_Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29cf13b32f79443cc4e3d265eac3b6274a9cdc9", @"/Views/Book/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078ee576d9166544738bbd20cb217177015223a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 10 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.LabelFor(x => x.Id, "Sıra No", new { @class = "col-md-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Id, null, new { @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Id, null, new { @class = "col-md-2 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.LabelFor(x => x.Name, "Kitap Adı", new { @class = "col-md-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name, null, new { @class = "col-md-2 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.LabelFor(x => x.Author, "Yazar Adı", new { @class = "col-md-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Author, null, new { @class = "col-md-2 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.LabelFor(x => x.Publisher, "Yayınevi", new { @class = "col-md-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Publisher, null, new { @class = "col-md-2 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <button class=\"btn btn-primary\" type=\"submit\">Değişiklikleri Kaydet</button>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Oğuz KÖSE\source\repos\Book-Store\Kodluyoruz-Practice\Views\Book\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591