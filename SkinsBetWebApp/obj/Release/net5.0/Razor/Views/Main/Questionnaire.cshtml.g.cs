#pragma checksum "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0335c287ad968bdd0f445516926393e4a2325c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Questionnaire), @"mvc.1.0.view", @"/Views/Main/Questionnaire.cshtml")]
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
#line 1 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\_ViewImports.cshtml"
using SkinsBetWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\_ViewImports.cshtml"
using SkinsBetWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0335c287ad968bdd0f445516926393e4a2325c8", @"/Views/Main/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c200bae9f48d4c7618bfcd05c1215e4a2ed2dd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Questionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("style", " style=\"", 4, "\"", 12, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0335c287ad968bdd0f445516926393e4a2325c83723", async() => {
                WriteLiteral("\r\n  <div class=\"col-md-4\">\r\n    <label for=\"validationCustom01\" class=\"form-label\">Никнейм youtube (как в чате)</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"validationCustom01\"");
                BeginWriteAttribute("value", " value=\"", 254, "\"", 262, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
    <div class=""valid-feedback"">
      Выглядит отлично!
    </div>
  </div>
  <div class=""col-md-4"">
    <label for=""validationCustom02"" class=""form-label"">Никнейм steam</label>
    <input type=""text"" class=""form-control"" id=""validationCustom02""");
                BeginWriteAttribute("value", " value=\"", 527, "\"", 535, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
    <div class=""valid-feedback"">
      Выглядит отлично!
    </div>
  </div>
  <div class=""col-md-4"">
    <label for=""validationCustomUsername"" class=""form-label"">Email (должен быть валидный - возможно будет отсылаться сообщеине с кодом)</label>
    <div class=""input-group has-validation"">
      <input type=""text"" class=""form-control"" id=""validationCustomUsername"" aria-describedby=""inputGroupPrepend"" required>
      <div class=""invalid-feedback"">
        Пожалуйсто заполните поле email.
      </div>
    </div>
  </div>
  <div class=""col-12"">
    <button class=""btn btn-primary"" type=""submit"">Участвовать в розыгрыше.</button>
  </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  <div id=""StatusInsert""></div>
  <div style=""padding-top: 20px;"" id=""players"">
    <h2>Участники:</h2>
  </div>
</div>
<script type=""application/javascript"">
getPlayers().then(data => {
  debugger;
  for (step = 0; step < data.length; step++) {
    const newElem = document.createElement(""div"");
    newElem.setAttribute(""class"", ""row"");
    newElem.innerText = data[step].loginYoutube
    document.getElementById(""players"").appendChild(newElem)
  }
});
(function () {
  'use strict'
  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  var forms = document.querySelectorAll('.needs-validation')

  // Loop over them and prevent submission
  Array.prototype.slice.call(forms)
    .forEach(function (form) {
      form.addEventListener('submit', function (event) {
          debugger;
        if (!form.checkValidity()) {
          event.preventDefault()
          event.stopPropagation()
        }
        else
        {
            insertInfo().then(data => 
");
            WriteLiteral(@"            {
                changeInsertText(data);
            });
        }

        form.classList.add('was-validated')
      }, false)
    })
})()
async function insertInfo()
{
    debugger;
    const rawResponse = await fetch('/Betting/InsertInfo', 
                                  {
                                    method: 'POST',
                                    headers: {
                                      'Accept': 'application/json',
                                      'Content-type': 'application/json'
                                    },
                                    body: JSON.stringify({loginYoutube : document.getElementById('validationCustom01').value, loginSteam : document.getElementById('validationCustom02').value, email : document.getElementById('validationCustomUsername').value}),
                                  });
                                  return await rawResponse.json();
}
function changeInsertText(status)
{
    debugger;
    docu");
            WriteLiteral(@"ment.getElementById('StatusInsert').textContent = status;
}
async function getPlayers()
{
  debugger;
      const rawResponse = await fetch('/Betting/GetPlayers', 
                                    {
                                      method: 'GET',
                                      headers: {
                                        'Accept': 'application/json',
                                        'Content-type': 'application/json'
                                      }
                                    });
                                    return await rawResponse.json();
}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
