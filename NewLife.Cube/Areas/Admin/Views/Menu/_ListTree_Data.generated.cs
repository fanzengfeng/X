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
    
    #line 6 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Menu/_ListTree_Data.cshtml")]
    public partial class _Areas_Admin_Views_Menu__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.Menu>>
    {
        public _Areas_Admin_Views_Menu__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IReadOnlyList<FieldItem>;
    var enableSelect = this.EnableSelect();
    //var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
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

            
            #line 23 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 832), Tuple.Create("\"", 871)
            
            #line 24 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 839), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 839), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 924), Tuple.Create("\"", 973)
            
            #line 25 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 931), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("TreeNodeName"))
            
            #line default
            #line hidden
, 931), false)
);

WriteLiteral(">节点名</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1027), Tuple.Create("\"", 1075)
            
            #line 26 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 1034), false)
);

WriteLiteral(">显示名</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1129), Tuple.Create("\"", 1169)
            
            #line 27 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1136), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Url"))
            
            #line default
            #line hidden
, 1136), false)
);

WriteLiteral(">链接</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1222), Tuple.Create("\"", 1263)
            
            #line 28 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1229), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sort"))
            
            #line default
            #line hidden
, 1229), false)
);

WriteLiteral(">排序</a></th>\r\n            ");

WriteLiteral("\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1414), Tuple.Create("\"", 1458)
            
            #line 30 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Visible"))
            
            #line default
            #line hidden
, 1421), false)
);

WriteLiteral(">可见</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"必要。必要的菜单，必须至少有角色拥有这些权限，如果没有则自动授权给系统角色\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1557), Tuple.Create("\"", 1603)
            
            #line 31 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
           , Tuple.Create(Tuple.Create("", 1564), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Necessary"))
            
            #line default
            #line hidden
, 1564), false)
);

WriteLiteral(">必要</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"权限子项。逗号分隔，每个权限子项名值竖线分隔\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1687), Tuple.Create("\"", 1734)
            
            #line 32 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1694), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Permission"))
            
            #line default
            #line hidden
, 1694), false)
);

WriteLiteral(">权限子项</a></th>\r\n");

            
            #line 33 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
         foreach (var entity in Model)
        {
            var p = entity.Parent as IEntityTree;
            if (p == null)
            {
                p = fact.EntityType.GetValue("Root") as IEntityTree;
            }
            var id = entity.ID;

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 51 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2483), Tuple.Create("\"", 2501)
            
            #line 53 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2491), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2491), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 54 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 55 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 56 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 57 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 58 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                  Write(entity.Sort.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                ");

WriteLiteral("\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2929), Tuple.Create("\"", 2992)
, Tuple.Create(Tuple.Create("", 2937), Tuple.Create("glyphicon", 2937), true)
, Tuple.Create(Tuple.Create(" ", 2946), Tuple.Create("glyphicon-", 2947), true)
            
            #line 62 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2957), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "ok" : "remove"
            
            #line default
            #line hidden
, 2957), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2993), Tuple.Create("\"", 3044)
, Tuple.Create(Tuple.Create("", 3001), Tuple.Create("color:", 3001), true)
            
            #line 62 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                     , Tuple.Create(Tuple.Create(" ", 3007), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "green" : "red"
            
            #line default
            #line hidden
, 3008), false)
, Tuple.Create(Tuple.Create("", 3043), Tuple.Create(";", 3043), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3139), Tuple.Create("\"", 3204)
, Tuple.Create(Tuple.Create("", 3147), Tuple.Create("glyphicon", 3147), true)
, Tuple.Create(Tuple.Create(" ", 3156), Tuple.Create("glyphicon-", 3157), true)
            
            #line 65 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3167), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "ok" : "remove"
            
            #line default
            #line hidden
, 3167), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3205), Tuple.Create("\"", 3258)
, Tuple.Create(Tuple.Create("", 3213), Tuple.Create("color:", 3213), true)
            
            #line 65 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                       , Tuple.Create(Tuple.Create(" ", 3219), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "green" : "red"
            
            #line default
            #line hidden
, 3220), false)
, Tuple.Create(Tuple.Create("", 3257), Tuple.Create(";", 3257), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td>");

            
            #line 67 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Permission);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 68 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 71 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3644), Tuple.Create("\"", 3680)
            
            #line 73 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3651), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 3651), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 74 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 77 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 77 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && entity != p.Childs[p.Childs.Count - 1])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4000), Tuple.Create("\"", 4038)
            
            #line 79 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 4007), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 4007), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 80 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 83 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 85 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 87 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
