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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Lists
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Lists/List.PagesList.cshtml")]
    public partial class List_PagesList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_PagesList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 181), Tuple.Create("\"", 204)
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
, Tuple.Create(Tuple.Create("", 189), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 189), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3 ");

            
            #line 11 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h3>\r\n");

WriteLiteral("        <ul>\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
             foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
            {
                var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(listItem, Guid.Empty, true, Model.UrlKeyPrefix);
                

            
            #line default
            #line hidden
WriteLiteral("                <li ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 921), Tuple.Create("\"", 940)
            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
, Tuple.Create(Tuple.Create("", 928), Tuple.Create<System.Object, System.Int32>(navigateUrl
            
            #line default
            #line hidden
, 928), false)
);

WriteLiteral(" ");

            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
                                      Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
                                                                                               Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
               Write(Html.CommentsCount((string)navigateUrl, listItem.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.PagesList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
