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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Event
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
    
    #line 3 "..\..MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Event/List.EventsList.cshtml")]
    public partial class List_EventsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_EventsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 265), Tuple.Create("\"", 288)
            
            #line 8 "..\..MVC\Views\Event\List.EventsList.cshtml"
, Tuple.Create(Tuple.Create("", 273), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 273), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..MVC\Views\Event\List.EventsList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..MVC\Views\Event\List.EventsList.cshtml"
         foreach (var item in Model.Items)
        {
            var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(" ");

            
            #line 14 "..\..MVC\Views\Event\List.EventsList.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"col-auto position-relative\"");

WriteLiteral(">\r\n                        <a ");

            
            #line 17 "..\..MVC\Views\Event\List.EventsList.cshtml"
                      Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 17 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                     Write(navigateUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 17 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                                   Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <span");

WriteAttribute("title", Tuple.Create(" title=\"", 904), Tuple.Create("\"", 937)
            
            #line 18 "..\..MVC\Views\Event\List.EventsList.cshtml"
, Tuple.Create(Tuple.Create("", 912), Tuple.Create<System.Object, System.Int32>(item.Fields.Parent.Title
            
            #line default
            #line hidden
, 912), false)
);

WriteLiteral(" class=\"col-auto position-absolute top-50 start-100 translate-middle p-2 border b" +
"order-light rounded-circle\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1046), Tuple.Create("\"", 1099)
, Tuple.Create(Tuple.Create("", 1054), Tuple.Create("background-color:", 1054), true)
            
            #line 18 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                                                    , Tuple.Create(Tuple.Create(" ", 1071), Tuple.Create<System.Object, System.Int32>(item.EventCalendarColour()
            
            #line default
            #line hidden
, 1072), false)
);

WriteLiteral("></span>\r\n                    </h3>\r\n                </div>\r\n                <div" +
">\r\n                    <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n                        <time>");

            
            #line 24 "..\..MVC\Views\Event\List.EventsList.cshtml"
                         Write(item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time>");

            
            #line 24 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                        if (!string.IsNullOrEmpty(item.Fields.City)){
            
            #line default
            #line hidden
WriteLiteral("<span>, ");

            
            #line 24 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                                        Write(item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 24 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                                                                     }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 25 "..\..MVC\Views\Event\List.EventsList.cshtml"
                   Write(Html.CommentsCount((string)navigateUrl, item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"mt-3 mb-2\"");

WriteLiteral(" ");

            
            #line 28 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                  Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\Event\List.EventsList.cshtml"
                                                                                            Write(Html.HtmlSanitize((string)item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </li>\r\n");

            
            #line 30 "..\..MVC\Views\Event\List.EventsList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 33 "..\..MVC\Views\Event\List.EventsList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\Event\List.EventsList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 35 "..\..MVC\Views\Event\List.EventsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
        {
            currentPage = Model.CurrentPage,
            totalPagesCount = Model.TotalPagesCount.Value,
            redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
        }));

            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\Event\List.EventsList.cshtml"
          
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
