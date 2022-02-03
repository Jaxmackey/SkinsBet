#pragma checksum "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da01f3a7165416bb2532bfe6a2e451fdd6fa3a8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da01f3a7165416bb2532bfe6a2e451fdd6fa3a8", @"/Views/Main/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c200bae9f48d4c7618bfcd05c1215e4a2ed2dd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Questionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("style", " style=\"", 4, "\"", 12, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n  <div class=\"col-md-4\">\r\n    <label for=\"validationCustom01\" class=\"form-label\">Никнейм youtube (как в чате)</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"validationCustom01\"");
            BeginWriteAttribute("value", " value=\"", 202, "\"", 210, 0);
            EndWriteAttribute();
            WriteLiteral(@" required>
    <div id=""coolLoginYoutube"" style=""display: none; color: #1e7e34"">
      Выглядит отлично!
    </div>
    <div id=""wrongLoginYoutube"" style=""display: none; color: red"">
      Не может быть пустым
      </div>
  </div>
  <div class=""col-md-4"">
    <label for=""validationCustom02"" class=""form-label"">Никнейм steam</label>
    <input type=""text"" class=""form-control"" id=""validationCustom02""");
            BeginWriteAttribute("value", " value=\"", 622, "\"", 630, 0);
            EndWriteAttribute();
            WriteLiteral(@" required>
     <div id=""coolLoginSteam"" style=""display: none; color: #1e7e34"">
          Выглядит отлично!
        </div>
        <div id=""wrongLoginSteam"" style=""display: none; color: red"">
          Не может быть пустым
          </div>
  </div>
  <div class=""col-md-4"">
    <label for=""validationCustomUsername"" class=""form-label"">Email (должен быть валидный - возможно будет отсылаться сообщеине с кодом)</label>
    <input type=""text"" class=""form-control"" id=""validationCustomUsername"" required>
      <div id=""coolEmail"" style=""display: none; color: #1e7e34"">
        Выглядит отлично!
      </div>
      <div id=""wrongEmail"" style=""display: none; color: red"">
        Не может быть пустым
      </div>
    </div>
  <div class=""col-12"">
    <button class=""btn btn-primary"" onclick=""playInLotto()"">Участвовать в розыгрыше.</button>
  </div>
  <div id=""StatusInsert""></div>
      <h2>Участники:</h2>
  <div style=""padding-top: 20px;"" id=""players"">
  </div>
</div>
<script type=""application/jav");
            WriteLiteral(@"ascript"">
getPlayers().then(data => {
  makerTablePlayers(data);
});
function makerTablePlayers(data)
{
  removeAllChildNodes(document.getElementById(""players""));
    for (step = 0; step < data.length; step++) {
      const newElem = document.createElement(""div"");
      newElem.setAttribute(""class"", ""row"");
      newElem.innerText = data[step].loginYoutube
      document.getElementById(""players"").appendChild(newElem)
    }
}
function removeAllChildNodes(parent) {
    while (parent.firstChild) {
        parent.removeChild(parent.firstChild);
    }
}
function playInLotto()
{
  debugger;
  let inputLoginYoutube = document.getElementById('validationCustom01');
  let inputLoginSteam = document.getElementById('validationCustom02');
  let inputEmail = document.getElementById('validationCustomUsername');
  let validate = true;
  if (inputLoginYoutube.value === '')
  {
    document.getElementById('coolLoginYoutube').style.display = 'none';
    document.getElementById('wrongLoginYoutube').s");
            WriteLiteral(@"tyle.display = null;
    validate = false;
  }
  else
  {
    document.getElementById('wrongLoginYoutube').style.display = 'none';
    document.getElementById('coolLoginYoutube').style.display = null;
  }
  debugger;
  if(inputLoginSteam.value === '')
  {
     document.getElementById('coolLoginSteam').style.display = 'none';
        document.getElementById('wrongLoginSteam').style.display = null;
        validate = false;
  }
  else 
  {
      document.getElementById('wrongLoginSteam').style.display = 'none';
          document.getElementById('coolLoginSteam').style.display = null;
  }
  if (inputEmail.value === '')
  {
     document.getElementById('coolEmail').style.display = 'none';
            document.getElementById('wrongEmail').style.display = null;
            validate = false;
  }
  else
  {
    document.getElementById('wrongEmail').style.display = 'none';
              document.getElementById('coolEmail').style.display = null;
  }
  if (validate)
  {
    
  }
}
asy");
            WriteLiteral(@"nc function insertInfo()
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
    document.getElementById('StatusInsert').textContent = status;
}
async function getPlayers()
{
  debugger;
      const rawResponse = await fetch('/Betting/GetPlayers");
            WriteLiteral(@"', 
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
