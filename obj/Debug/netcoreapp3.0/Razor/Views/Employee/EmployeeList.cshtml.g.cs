#pragma checksum "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e69b1d2afaf444b3860f58c9a85f40dbe99e560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeList), @"mvc.1.0.view", @"/Views/Employee/EmployeeList.cshtml")]
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
#line 1 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e69b1d2afaf444b3860f58c9a85f40dbe99e560", @"/Views/Employee/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>.card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color: rgba(214, 224, 226, 0.2);
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card .card-heading {
    padding: 0 20px;
    margin: 0;
}

.card .card-heading.simple {
    font-size: 20px;
    font-weight: 300;
    color: #777;
    border-bottom: 1px solid #e5e5e5;
}

.card .card-heading.image img {
    display: inline-block;
    width: 46px;
    height: 46px;
    margin-right: 15px;
    vertical-align: top;
    border: 0;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.ca");
            WriteLiteral(@"rd .card-heading.image .card-heading-header h3 {
    margin: 0;
    font-size: 14px;
    line-height: 16px;
    color: #262626;
}

.card .card-heading.image .card-heading-header span {
    font-size: 12px;
    color: #999999;
}

.card .card-body {
    padding: 0 20px;
    margin-top: 20px;
}

.card .card-media {
    padding: 0 20px;
    margin: 0 -14px;
}

.card .card-media img {
    max-width: 100%;
    max-height: 100%;
}

.card .card-actions {
    min-height: 30px;
    padding: 0 20px 20px 20px;
    margin: 20px 0 0 0;
}

.card .card-comments {
    padding: 20px;
    margin: 0;
    background-color: #f8f8f8;
}

.card .card-comments .comments-collapse-toggle {
    padding: 0;
    margin: 0 20px 12px 20px;
}

.card .card-comments .comments-collapse-toggle a,
.card .card-comments .comments-collapse-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card");
            WriteLiteral(@"-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 500px;
    height: 300px;
    padding-top: 0;
    margin-left: 20px;
    overflow: hidden;
    vertical-align: top;
}

.card.people:first-child {
    margin-left: 0;
}

.card.people .card-top {
    position: absolute;
    top: 0;
    left: 0;
    display: inline-block;
    width: 170px;
    height: 150px;
    background-color: #ffffff;
}

.card.people .card-top.green {
    background-color: #53a93f;
}

.card.people .card-top.blue {
    background-color: #427fed;
}

.card.people .card-info {
    position: absolute;
    top: 150px;
    display: inline-block;
    width: 100%;
    height: 101px;
    overflow: hidden;
    background: #ffffff;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px ");
            WriteLiteral(@"0 14px;
    overflow: hidden;
    font-size: 16px;
    font-weight: bold;
    line-height: 18px;
    color: #404040;
}

.card.people .card-info .desc {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 12px;
    line-height: 16px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.people .card-bottom {
    position: absolute;
    bottom: 0;
    left: 0;
    display: inline-block;
    width: 100%;
    padding: 10px 20px;
    line-height: 29px;
    text-align: center;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.hovercard {
    position: relative;
    padding-right: 15px;
    padding-left: 15px;
    overflow: hidden;
    text-align: center;
    background-color: rgba(214, 224, 226, 0.2);
}

  
.card.hovercard .cardheader {
    background-color: rgba(214, 224, 226, 0.2);
    height: 500px;
}
.card.hovercard .cardjudul {
    background: #0c0f11;
    background-siz");
            WriteLiteral(@"e: cover;
    height: 350px;
}

.card.hovercard .body {
    background-size: cover;
    height: 300px;
}

.card.hovercard .avatar {
    position: relative;
    top: -50px;
    margin-bottom: -50px;
}

.card.hovercard .avatar img {
    width: 100px;
    height: 100px;
    max-width: 100px;
    max-height: 100px;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
    border: 5px solid rgba(20,105,148,0.5);
}

.card.hovercard .info {
    padding: 4px 8px 10px;
}

.card.hovercard .info .title {
    margin-bottom: 4px;
    font-size: 24px;
    line-height: 1;
    color: #262626;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}

</style>

 <br>

<div class=""container"">
    <div class=""column"">
        <div class=""col-lg-12 co");
            WriteLiteral(@"l-sm-5"">
        <h3><b>Employee List</b></h3></div>
    <div class=""column text-right""> <div class=""col-lg-12 col-sm-5"">
<button class=""btn btn-primary""><b>Export CSV</b></button>
<button class=""btn btn-primary""><b>Export CSV (All)</b></button>
<button class=""btn btn-primary""><b>Import CSV</b></button>
<button class=""btn btn-primary""><b>Add New Employee</b></button> </div></div> </div>
        <div class=""col-lg-12 col-sm-5"">
             <div class=""card hovercard"">
                    <div class=""row"" style=""background-color: #215086;"">
                   <div class=""col-lg-3 col-sm-3"">
                   </div>
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a onclick=""location.href='/Employee/EmployeeList?status_employee=permanent'"" style=""color:#E4F1FF; font-family:Helvetica, sans-serif""><b>Permanent</b></a>
                   </div>
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a ");
            WriteLiteral(@"onclick=""location.href='/Employee/EmployeeList?status_employee=contract'"" style=""color:#C2D0E0; font-family:Helvetica, sans-serif"">Contract</a>
                   </div>
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a onclick=""location.href='/Employee/EmployeeList?status_employee=probation'"" style=""color:#C2D0E0; font-family:Helvetica, sans-serif"">Probation</a>
                   </div>
                   <div class=""col-lg-3 col-sm-3"">
                   </div>
                   </div>
                   <br>
                   <div class=""col-lg-12 col-sm-4"">
                       <div class=""row"">
                   <div class=""col-lg-11 col-sm-5"">
                    <input type=""text"" name=""search"" class=""form-control"" placeholder=""Type to search""></div>
                   <div>
                    <button class=""btn btn-success"" style=""font-family:Helvetica, sans-serif"" type=""submit""><span class=""glyphicon glyphicon-search""> search</");
            WriteLiteral("span>\r\n                    </button></div>\r\n                    </div><br>    \r\n                <div class=\"body\">\r\n\r\n<table class=\"table text-left\">\r\n            <tbody>\r\n");
#nullable restore
#line 303 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
     
    var items = ViewBag.items;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br>
    <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Email</th>
      <th scope=""col"">Phone</th>
      <th scope=""col"">Occupation</th>
      <th scope=""col"">Placement</th>
      <th scope=""col""></th>
    </tr>
  </thead>    
");
#nullable restore
#line 316 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", "  id=\"", 7777, "\"", 7791, 2);
            WriteAttributeValue("", 7783, "Id-", 7783, 3, true);
#nullable restore
#line 318 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 7786, a.Id, 7786, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 7792, "\"", 7805, 1);
#nullable restore
#line 318 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 7800, a.Id, 7800, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                <td><b>");
#nullable restore
#line 320 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
                  Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td>");
#nullable restore
#line 321 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
               Write(a.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 322 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
               Write(a.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 323 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
                                 Write(a.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 324 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
                                 Write(a.Placement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\"><a");
            BeginWriteAttribute("id", " id=\"", 8148, "\"", 8162, 2);
            WriteAttributeValue("", 8153, "btn-", 8153, 4, true);
#nullable restore
#line 325 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 8157, a.Id, 8157, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:EmployeeDetail(this)\"><span class=\"glyphicon glyphicon-chevron-right\"></span></a></td>\r\n            </tr> \r\n");
#nullable restore
#line 327 "D:\TRAININGC#\MARET\FinalProject\FinalProject\Views\Employee\EmployeeList.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </tbody> 
    </table>
                </div>
            <br>
        </div>
    </div>
</div>
	</div>
</div>
  </div>
</div>

<div class=""container"">
<div class=""column"">
<div class=""col-lg-12 col-sm-5"">
<nav aria-label=""..."">
  <ul class=""pagination marginleft"">
    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?prev=1"">Previous</a>
    </li>
    <li class=""page-item""><a class=""page-link"" value=""1"" id=""btn1"" href=""/Employee/EmployeeList?_crntpage=1"">1</a></li>
    <li class=""page-item""><a class=""page-link"" value=""2"" id=""btn2"" href=""/Employee/EmployeeList?_crntpage=2"">2</a></li>
    <li class=""page-item""><a class=""page-link"" value=""3"" id=""btn3"" href=""/Employee/EmployeeList?_crntpage=3"">3</a></li>
    <li class=""page-item""><a class=""page-link"" value=""4"" id=""btn4"" href=""/Employee/EmployeeList?_crntpage=4"">4</a></li>
    <li class=""page-item""><a class=""page-link"" value=""5"" id=""btn5"" href=""/Employee/EmployeeList?_crntpage=5"">5</a></li>
    <li class=""page-item""><a");
            WriteLiteral(@" class=""page-link"" value=""6"" id=""btn6"" href=""/Employee/EmployeeList?_crntpage=6"">6</a></li>
    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?next=1"">Next</a>
    </li>
  </ul>
<br><br><br></div></div>


<script type=""text/javascript"">
function EmployeeDetail(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Employee/EmployeeDetail?Id='+Id;
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
