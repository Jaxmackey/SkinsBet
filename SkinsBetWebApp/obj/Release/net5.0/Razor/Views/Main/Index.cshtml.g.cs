#pragma checksum "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b1092c8fd8ff6cface6dbf5092121372badf6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b1092c8fd8ff6cface6dbf5092121372badf6c", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c200bae9f48d4c7618bfcd05c1215e4a2ed2dd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Skin[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""application/javascript"">
let chances = 3;
let items = [];
function clearRed()
{
    let itemsUI = document.getElementsByClassName(""item"");
    for (let item of itemsUI) 
    {
        if (item.style.border !== ""thick solid rgb(0, 0, 255)"")
        {
            item.style.border = ""none"";   
        }
    }
}
function selectItemProcess()
{
    let total = items.length - 1;
    let rand = Math.floor(Math.random() * (total));
    let currentItem = document.getElementById(""id__""+ items[rand].id+"" classid__"" + items[rand].classId);
    let seleted = false;
    if (currentItem.style.border === ""thick solid rgb(0, 0, 255)"")
    {
        seleted = true;
    }
    currentItem.style.border = ""thick solid #D78112"";
    setTimeout(() => 
    {
        if (seleted)
        {
            currentItem.style.border = ""thick solid #0000FF""
        }
        else
        {
          currentItem.style.border = ""none"";
        }
    }, 50);
    
}
function takeResult()
{
   ");
            WriteLiteral(@" if (chances < 3)
    {
        debugger;
        let bettingSound = new Audio(""/Betting/GetAudioFile?name=04796.mp3"");
        bettingSound.volume = 0.1;
        let fail = new Audio(""/Betting/GetAudioFile?name=736b557f79b5489.mp3"");
         fail.volume = 0.1;
        let win = new Audio(""/Betting/GetAudioFile?name=3283ff775b4b474.mp3"");
         win.volume = 0.1;
        bettingSound.play();
            clearRed();
            let foobarTimeout = setInterval(selectItemProcess, 100);
            selectItemProcess();
            (async () => {
              const rawResponse = await fetch('/Betting/TakeResult', 
              {
                method: 'POST',
                headers: {
                  'Accept': 'application/json',
                  'Content-type': 'application/json'
                },
                body: JSON.stringify(items),
              });
              const content = await rawResponse.json();
              bettingSound.pause();
              bettingSound.c");
            WriteLiteral(@"urrentTime = 0;
              clearInterval(foobarTimeout);
              if (content.select)
              {
                  document.getElementById(""id__""+ content.id+"" classid__"" + content.classId).style.border = ""thick solid #08FF00"";
                  await win.play();
                  win.currentTime = 0;
              }else
              {
                  document.getElementById(""id__""+ content.id+"" classid__"" + content.classId).style.border = ""thick solid #FF0000"";
                  await fail.play();
                  fail.currentTime = 0;
              }
              console.log(content);
            })();
    }
    else
    {
        console.log(""Сделайте выбор."")
    }
}
function loadItems(modelItems)
{
    debugger;
    for (let j = 0; j < modelItems.length; j++){
        items.push(modelItems[j]);
    }
    loadChances();
}
function loadChances()
{
    let chancesTotal =  document.getElementById(""chances"");
    if (chancesTotal !== null)
    {
        docu");
            WriteLiteral(@"ment.getElementById(""chances"").textContent = chances.toString();
    }
}
function selectItem(id, classId)
{
    let currentItem = items.filter(i => i.id === id && i.classId == classId);
    if (chances !== 0)
    {
         if (currentItem[0].select == false)
         {
            currentItem[0].select = true;
            document.getElementById(""id__""+ currentItem[0].id+"" classid__"" + currentItem[0].classId).style.border = ""thick solid #0000FF"";
            chances--;
         }
         else
         {
             chances++;
             currentItem[0].select = false;
             document.getElementById(""id__""+ currentItem[0].id+"" classid__"" + currentItem[0].classId).style.border = ""none"";
         }   
    }
    else
    {
         if (currentItem[0].select == true)
         {
              chances++;
              currentItem[0].select = false;
              document.getElementById(""id__""+ currentItem[0].id+"" classid__"" + currentItem[0].classId).style.border = ""none"";
      ");
            WriteLiteral("   }\r\n    }\r\n    loadChances();\r\n}\r\n</script>\r\n<script type=\"text/javascript\">loadItems(");
#nullable restore
#line 134 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
                                    Write(Json.Serialize(@Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(");</script>\r\n  <div class=\"row\">\r\n    <div class=\"col-sm\">\r\n      <table>\r\n");
#nullable restore
#line 138 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
             var counter = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n");
#nullable restore
#line 140 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <td");
            BeginWriteAttribute("id", " id=\"", 4444, "\"", 4484, 4);
            WriteAttributeValue("", 4449, "id__", 4449, 4, true);
#nullable restore
#line 142 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
WriteAttributeValue("", 4453, item.Id, 4453, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4461, "classid__", 4462, 10, true);
#nullable restore
#line 142 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
WriteAttributeValue("", 4471, item.ClassId, 4471, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4498, "\"", 4543, 5);
            WriteAttributeValue("", 4508, "selectItem(", 4508, 11, true);
#nullable restore
#line 142 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
WriteAttributeValue("", 4519, item.Id, 4519, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4527, ",", 4527, 1, true);
#nullable restore
#line 142 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
WriteAttributeValue(" ", 4528, item.ClassId, 4529, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4542, ")", 4542, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n          <img style=\" height:90px;\r\n                       width:auto;/*maintain aspect ratio*/\r\n                       max-width:90px;\"");
            BeginWriteAttribute("src", " src=\"", 4684, "\"", 4716, 1);
#nullable restore
#line 145 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
WriteAttributeValue("", 4690, Url.Content(item.IconUrl), 4690, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\"/>\r\n                  </td>\r\n");
#nullable restore
#line 147 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
                  if (counter % 10 == 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      ");
            WriteLiteral("</tr>\r\n                      ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 151 "D:\Projects\SkinsBetMain\SkinsBetWebApp\Views\Main\Index.cshtml"
                  }
                  counter++;
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tr>\r\n      </table>\r\n    </div>\r\n    <div class=\"col-sm\">\r\n        <p>Количество фишек: <span id=\"chances\">3</span></p>\r\n        <button onclick=\"takeResult()\">Сыграть</button>\r\n    </div>\r\n  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Skin[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
