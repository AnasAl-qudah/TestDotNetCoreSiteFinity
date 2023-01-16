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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Image
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
    
    #line 2 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Image/Image.cshtml")]
    public partial class Image : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Image.ImageViewModel>
    {

#line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
public System.Web.WebPages.HelperResult ImageTag()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
 
    if (Model.Responsive == true)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <picture");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 260), Tuple.Create("\"", 283)

#line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 268), Tuple.Create<System.Object, System.Int32>(Model.CssClass

#line default
#line hidden
, 268), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
            

#line default
#line hidden

#line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
              
                var thumbnails = Html.GetImageThumbnailsSortedByWidthDesc(Model);
                var img = Model.Item.DataItem as Telerik.Sitefinity.Libraries.Model.Image;

                if (thumbnails.Count > 0)
                {
                    foreach (var thumbnail in thumbnails)
                    {
                        var blobThumb = thumbnail as Telerik.Sitefinity.BlobStorage.IBlobContent;

                        if (blobThumb != null && (thumbnail.Width != img.Width && thumbnail.Height != img.Height))
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <source");

WriteAttributeTo(__razor_helper_writer, "media", Tuple.Create(" media=\"", 903), Tuple.Create("\"", 944)
, Tuple.Create(Tuple.Create("", 911), Tuple.Create("(max-width:", 911), true)

#line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create(" ", 922), Tuple.Create<System.Object, System.Int32>(thumbnail.Width

#line default
#line hidden
, 923), false)
, Tuple.Create(Tuple.Create("", 941), Tuple.Create("px)", 941), true)
);

WriteAttributeTo(__razor_helper_writer, "srcset", Tuple.Create(" srcset=\"", 945), Tuple.Create("\"", 968)

#line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
       , Tuple.Create(Tuple.Create("", 954), Tuple.Create<System.Object, System.Int32>(blobThumb.Url

#line default
#line hidden
, 954), false)
);

WriteAttributeTo(__razor_helper_writer, "type", Tuple.Create(" type=\"", 969), Tuple.Create("\"", 995)

#line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                             , Tuple.Create(Tuple.Create("", 976), Tuple.Create<System.Object, System.Int32>(thumbnail.MimeType

#line default
#line hidden
, 976), false)
);

WriteAttributeTo(__razor_helper_writer, "width", Tuple.Create(" width=\"", 996), Tuple.Create("\"", 1020)

#line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 1004), Tuple.Create<System.Object, System.Int32>(thumbnail.Width

#line default
#line hidden
, 1004), false)
);

WriteAttributeTo(__razor_helper_writer, "height", Tuple.Create(" height=\"", 1021), Tuple.Create("\"", 1047)

#line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                                                                                  , Tuple.Create(Tuple.Create("", 1030), Tuple.Create<System.Object, System.Int32>(thumbnail.Height

#line default
#line hidden
, 1030), false)
);

WriteLiteralTo(__razor_helper_writer, "/>\r\n");


#line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                        }
                    }
                }
            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n            <img");

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 1154), Tuple.Create("\"", 1182)

#line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 1160), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl

#line default
#line hidden
, 1160), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"mw-100 h-auto\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 1205), Tuple.Create("\"", 1225)

#line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.Title

#line default
#line hidden
, 1213), false)
);

WriteAttributeTo(__razor_helper_writer, "alt", Tuple.Create(" alt=\"", 1226), Tuple.Create("\"", 1273)

#line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
              , Tuple.Create(Tuple.Create("", 1232), Tuple.Create<System.Object, System.Int32>(Html.HtmlSanitize(Model.AlternativeText)

#line default
#line hidden
, 1232), false)
);

WriteLiteralTo(__razor_helper_writer, "/>\r\n        </picture>\r\n");


#line 30 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
    }
    else
    {



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <img");

WriteLiteralTo(__razor_helper_writer, " loading=\"lazy\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1351), Tuple.Create("\"", 1388)
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create("mw-100", 1359), true)
, Tuple.Create(Tuple.Create(" ", 1365), Tuple.Create("h-auto", 1366), true)

#line 34 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create(" ", 1372), Tuple.Create<System.Object, System.Int32>(Model.CssClass

#line default
#line hidden
, 1373), false)
);

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 1389), Tuple.Create("\"", 1417)

#line 34 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 1395), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl

#line default
#line hidden
, 1395), false)
);

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 1418), Tuple.Create("\"", 1438)

#line 34 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                      , Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Model.Title

#line default
#line hidden
, 1426), false)
);

WriteAttributeTo(__razor_helper_writer, "alt", Tuple.Create(" alt=\"", 1439), Tuple.Create("\"", 1486)

#line 34 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
                                         , Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Html.HtmlSanitize(Model.AlternativeText)

#line default
#line hidden
, 1445), false)
);

WriteLiteralTo(__razor_helper_writer, "\r\n         ");


#line 35 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetWidthAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "         ");


#line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetHeightAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 37 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
    }


#line default
#line hidden
});

#line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
}
#line default
#line hidden

        public Image()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
 if (string.IsNullOrEmpty(Model.LinkedContentUrl))
{
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
Write(ImageTag());

            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
               
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1775), Tuple.Create("\"", 1805)
            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(Model.LinkedContentUrl
            
            #line default
            #line hidden
, 1782), false)
);

WriteLiteral(" title=\"Open image in original size\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 47 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
   Write(ImageTag());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </a>\r\n");

            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Image\Image.cshtml"
}
            
            #line default
            #line hidden
WriteLiteral(" ");

        }
    }
}
#pragma warning restore 1591
