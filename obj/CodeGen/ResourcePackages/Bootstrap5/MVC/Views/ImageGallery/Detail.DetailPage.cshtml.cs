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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/ImageGallery/Detail.DetailPage.cshtml")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery.ImageDetailsViewModel>
    {

#line 69 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection(string arrow)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 70 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
 
    bool isRtl = ((Html.RenderDirAttribute().ToString() == "dir=\"rtl\"")?true:false);
     
    if (arrow == "next" && !isRtl || arrow == "prev" && isRtl)
    {
        

#line default
#line hidden

#line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-right"));


#line default
#line hidden

#line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 79 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-left"));


#line default
#line hidden

#line 79 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 81 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
}
#line default
#line hidden

        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 273), Tuple.Create("\"", 296)
            
            #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 281), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 281), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <figure");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 417), Tuple.Create("\"", 466)
            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 435), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageCaption")
            
            #line default
            #line hidden
, 435), false)
);

WriteLiteral(">\r\n        <figcaption");

WriteLiteral(" class=\"h2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 500), Tuple.Create("\"", 536)
            
            #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageCaption")
            
            #line default
            #line hidden
, 505), false)
);

WriteLiteral(" ");

            
            #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                               Write(Html.InlineEditingFieldAttributes("Title", "ShortText" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                                         Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>\r\n        <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                     Write(Html.Resource("ImageTakenOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <p");

WriteAttribute("id", Tuple.Create(" id=\"", 1034), Tuple.Create("\"", 1074)
            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1039), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageDescription")
            
            #line default
            #line hidden
, 1039), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                               Write(Html.InlineEditingFieldAttributes("Description", "LongText" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                              Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <div");

WriteLiteral(" class=\"d-flex justify-content-center bg-light\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" loading=\"lazy\"");

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 1317), Tuple.Create("\"", 1371)
            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageDescription")
            
            #line default
            #line hidden
, 1336), false)
);

WriteAttribute("src", Tuple.Create(" src=\"", 1372), Tuple.Create("\"", 1403)
            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                  , Tuple.Create(Tuple.Create("", 1378), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 1378), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1404), Tuple.Create("\'", 1508)
            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                  , Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(Model.Item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1410), false)
);

WriteLiteral("\r\n                 ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetWidthAttributeIfExists(Model.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                 ");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetHeightAttributeIfExists(Model.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n        </div>\r\n    </figure>\r\n\r\n");

            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("    <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1745), Tuple.Create("\"", 1794)
            
            #line 30 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(Html.Resource(" PreviousNextImage")
            
            #line default
            #line hidden
, 1758), false)
);

WriteLiteral(" class=\"d-flex justify-content-between mb-3\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
          
        var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
        var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.PreviousItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2136), Tuple.Create("\"", 2185)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2149), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToPreviousImage")
            
            #line default
            #line hidden
, 2149), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2186), Tuple.Create("\"", 2335)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2193), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 2193), false)
);

WriteLiteral(">\r\n            <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2428), Tuple.Create("\"", 2527)
, Tuple.Create(Tuple.Create("", 2441), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 2441), false)
            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             , Tuple.Create(Tuple.Create("", 2501), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("prev")
            
            #line default
            #line hidden
, 2501), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n            </svg>\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("PreviousImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.PreviousItem != null || @Model.NextItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <span>");

            
            #line 48 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         Write(string.Format(@Html.Resource("IndexOfTotal"), @ViewBag.ItemIndex, @Model.TotalItemsCount));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.NextItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" class=\"\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2922), Tuple.Create("\"", 2967)
            
            #line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2935), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToNextImage")
            
            #line default
            #line hidden
, 2935), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2968), Tuple.Create("\"", 3109)
            
            #line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 2975), false)
);

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("NextImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 3243), Tuple.Create("\"", 3342)
, Tuple.Create(Tuple.Create("", 3256), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 3256), false)
            
            #line 56 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             , Tuple.Create(Tuple.Create("", 3316), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("next")
            
            #line default
            #line hidden
, 3316), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n            </svg>\r\n        </a>\r\n");

            
            #line 59 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </nav>\r\n");

            
            #line 61 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"

    
            
            #line default
            #line hidden
            
            #line 62 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.ActionLink(Html.Resource("BackToAllImages"), "Index"));

            
            #line default
            #line hidden
            
            #line 62 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                               
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 65 "..\..\ResourcePackages\Bootstrap5\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
