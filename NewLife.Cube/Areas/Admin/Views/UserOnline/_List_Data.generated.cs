﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/UserOnline/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_UserOnline__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.UserOnline>>
    {
        public _Areas_Admin_Views_UserOnline__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IReadOnlyList<FieldItem>;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 22 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 791), Tuple.Create("\"", 830)
            
            #line 23 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 798), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 798), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 883), Tuple.Create("\"", 924)
            
            #line 24 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 890), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 890), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 977), Tuple.Create("\"", 1019)
            
            #line 25 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 984), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 984), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1072), Tuple.Create("\"", 1115)
            
            #line 26 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1079), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Status"))
            
            #line default
            #line hidden
, 1079), false)
);

WriteLiteral(">状态</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1168), Tuple.Create("\"", 1215)
            
            #line 27 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1175), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("OnlineTime"))
            
            #line default
            #line hidden
, 1175), false)
);

WriteLiteral(">在线时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1270), Tuple.Create("\"", 1315)
            
            #line 28 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1277), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateIP"))
            
            #line default
            #line hidden
, 1277), false)
);

WriteLiteral(">创建地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1370), Tuple.Create("\"", 1420)
            
            #line 29 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateAddress"))
            
            #line default
            #line hidden
, 1377), false)
);

WriteLiteral(">物理地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1475), Tuple.Create("\"", 1522)
            
            #line 30 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1482), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1482), false)
);

WriteLiteral(">创建时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1577), Tuple.Create("\"", 1624)
            
            #line 31 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1584), false)
);

WriteLiteral(">修改时间</a></th>\r\n");

            
            #line 32 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 39 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2040), Tuple.Create("\"", 2058)
            
            #line 44 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2048), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2048), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 45 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 47 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" style=\"max-width:600px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2392), Tuple.Create("\"", 2414)
            
            #line 49 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                , Tuple.Create(Tuple.Create("", 2400), Tuple.Create<System.Object, System.Int32>(entity.Status
            
            #line default
            #line hidden
, 2400), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                                                                                                           Write(entity.Status);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.OnlineTime.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 51 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 52 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateAddress);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 54 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 55 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 60 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 62 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
