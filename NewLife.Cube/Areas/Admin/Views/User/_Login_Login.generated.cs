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
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_Login_Login.cshtml")]
    public partial class _Areas_Admin_Views_User__Login_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__Login_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
  
    var set = NewLife.Cube.Setting.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"login-box\"");

WriteLiteral(" class=\"login-box visible widget-box no-border\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"widget-body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"widget-main\"");

WriteLiteral(">\r\n            <h4");

WriteLiteral(" class=\"header blue lighter bigger\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"ace-icon fa fa-coffee green\"");

WriteLiteral("></i>\r\n                精彩总在登录后\r\n            </h4>\r\n\r\n            <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n\r\n");

            
            #line 14 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
             using (Html.BeginForm("Login", "User", new { ReturnUrl = ViewBag.ReturnUrl }))
            {
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
           Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <fieldset>\r\n                    <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" name=\"username\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"用户名\"");

WriteLiteral(" />\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-user\"");

WriteLiteral("></i>");

            
            #line 21 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                                          Write(Html.ValidationMessage("username"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n              " +
"      <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" name=\"password\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"密码\"");

WriteLiteral(" />\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-lock\"");

WriteLiteral("></i>");

            
            #line 28 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                                          Write(Html.ValidationMessage("password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n              " +
"      <div");

WriteLiteral(" class=\"space\"");

WriteLiteral("></div>\r\n\r\n                    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"inline\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" name=\"remember\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n                            <span");

WriteLiteral(" class=\"lbl\"");

WriteLiteral("> 自动登录</span>\r\n                        </label>\r\n\r\n                        <butto" +
"n");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"width-35 pull-right btn btn-sm btn-primary\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-key\"");

WriteLiteral("></i>\r\n                            <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">登录</span>\r\n                        </button>\r\n                    </div>\r\n\r\n    " +
"                <div");

WriteLiteral(" class=\"space-4\"");

WriteLiteral("></div>\r\n                </fieldset>\r\n");

            
            #line 48 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div><!-- /.widget-main -->\r\n");

            
            #line 50 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
         if (set.AllowRegister || set.AllowForgot)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"toolbar clearfix\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                 if (set.AllowForgot)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div>\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#forgot-box\"");

WriteLiteral(" class=\"forgot-password-link\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-left\"");

WriteLiteral("></i>\r\n                            忘记密码？\r\n                        </a>\r\n         " +
"           </div>\r\n");

            
            #line 61 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 62 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                 if (set.AllowRegister)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div>\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#signup-box\"");

WriteLiteral(" class=\"user-signup-link\"");

WriteLiteral(">\r\n                            我要注册\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                        </a>\r\n                    </div>\r\n");

            
            #line 70 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 72 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div><!-- /.widget-body -->\r\n</div><!-- /.login-box -->");

        }
    }
}
#pragma warning restore 1591
