#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/NavigationField/Read.ProgressBar.cshtml")]
    public partial class Read_ProgressBar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_ProgressBar()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
  
    var totalPages = Model.Pages.Count();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 318), Tuple.Create("\"", 346)
            
            #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 326), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 326), false)
, Tuple.Create(Tuple.Create(" ", 341), Tuple.Create("my-3", 342), true)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(" data-sf-active-css-class=\"active\"");

WriteLiteral(" data-sf-past-css-class=\"d-none\"");

WriteLiteral(" data-sf-future-css-class=\"d-none\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"step-of-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 549), Tuple.Create("\"", 582)
            
            #line 11 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 557), Tuple.Create<System.Object, System.Int32>(Html.Resource(" StepOf")
            
            #line default
            #line hidden
, 557), false)
);

WriteLiteral(" />\r\n    <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"progress-bar\"");

WriteLiteral(" data-sf-role=\"progress-bar\"");

WriteLiteral("></div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"d-flex justify-content-between\"");

WriteLiteral(">\r\n        <b");

WriteLiteral(" class=\"sf-Progress-percent\"");

WriteLiteral(" data-sf-role=\"progress-percent\"");

WriteLiteral("> </b>\r\n        <ol");

WriteLiteral(" data-sf-role=\"sr-progressbar\"");

WriteLiteral(" class=\"list-unstyled text-muted\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuemin=\"1\"");

WriteAttribute("aria-valuemax", Tuple.Create(" aria-valuemax=\"", 952), Tuple.Create("\"", 979)
            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 968), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 968), false)
);

WriteLiteral(" aria-valuenow=\"1\"");

WriteAttribute("aria-valuetext", Tuple.Create(" aria-valuetext=\"", 998), Tuple.Create("\"", 1036)
, Tuple.Create(Tuple.Create("", 1015), Tuple.Create("Step", 1015), true)
, Tuple.Create(Tuple.Create(" ", 1019), Tuple.Create("1", 1020), true)
, Tuple.Create(Tuple.Create(" ", 1021), Tuple.Create("of", 1022), true)
            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                                                                                    , Tuple.Create(Tuple.Create(" ", 1024), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 1025), false)
);

WriteLiteral(">\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
             foreach (var page in Model.Pages)
            {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-navigation-index=\"");

            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-sf-page-title=\"");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Title);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                  Write(Html.HtmlSanitize(page.Title));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </li>\r\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ol>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap5\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591