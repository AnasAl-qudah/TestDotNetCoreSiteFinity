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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Facets
{
    
    #line 2 "..\..MVC\Views\Facets\Facets.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..MVC\Views\Facets\Facets.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..MVC\Views\Facets\Facets.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Facets\Facets.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\Facets\Facets.cshtml"
    using Telerik.Sitefinity.Publishing.PublishingPoints;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Facets/Facets.cshtml")]
    public partial class Facets : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.FacetsWidgetViewModel>
    {
        public Facets()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\Facets\Facets.cshtml"
  
    const int defaultFacetsCollapseCount = 10;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"facetContainer\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..MVC\Views\Facets\Facets.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\Facets\Facets.cshtml"
     if (ViewBag.HasAnyFacetElements)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3");

WriteLiteral(" class=\"h6 mb-3 fw-normal\"");

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\Facets\Facets.cshtml"
                                 Write(Model.FilterResultsLabel);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 16 "..\..MVC\Views\Facets\Facets.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"d-flex align-items-center justify-content-between\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\Facets\Facets.cshtml"
                                 Write(Model.AppliedFiltersLabel);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <button");

WriteLiteral(" id=\"sf-facet-clear-all-btn\"");

WriteLiteral(" class=\"btn btn-link px-0 py-0 mb-2\"");

WriteLiteral(" hidden>");

            
            #line 19 "..\..MVC\Views\Facets\Facets.cshtml"
                                                                                      Write(Model.ClearAllLabel);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" id=\"applied-filters\"");

WriteLiteral(" class=\"list-unstyled list-inline\"");

WriteLiteral(" data-sf-applied-filter-html-tag=\"li\"");

WriteLiteral(" data-sf-filter-label-css-class=\"list-inline-item bg-secondary bg-opacity-10 roun" +
"ded-pill ps-2 pe-4 pb-1 me-1 mb-1 mw-100 position-relative overflow-hidden text-" +
"truncate text-nowrap\"");

WriteLiteral(" data-sf-remove-filter-css-class=\"px-2 position-absolute end-0\"");

WriteLiteral(">\r\n        </ul>\r\n");

            
            #line 23 "..\..MVC\Views\Facets\Facets.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"facetContent\"");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..MVC\Views\Facets\Facets.cshtml"
        
            
            #line default
            #line hidden
            
            #line 26 "..\..MVC\Views\Facets\Facets.cshtml"
         foreach (var facet in Model.SearchFacets)
        {
            var value = 0;
            if (facet.FacetElements.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                <h4");

WriteLiteral(" class=\"h6 fw-normal mt-3\"");

WriteLiteral(">");

            
            #line 31 "..\..MVC\Views\Facets\Facets.cshtml"
                                         Write(facet.FacetTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 32 "..\..MVC\Views\Facets\Facets.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <ul");

WriteLiteral(" class=\"list-unstyled mb-0\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1429), Tuple.Create("\"", 1473)
, Tuple.Create(Tuple.Create("", 1434), Tuple.Create("facets-group-list-", 1434), true)
            
            #line 33 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 1452), Tuple.Create<System.Object, System.Int32>(facet.FacetFieldName
            
            #line default
            #line hidden
, 1452), false)
);

WriteLiteral(">\r\n");

            
            #line 34 "..\..MVC\Views\Facets\Facets.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\Facets\Facets.cshtml"
                     foreach (var facetElement in facet.FacetElements)
                    {
                        string facetElementLabel = facetElement.FacetValue;
                        if (facetElement.FacetFieldType == SearchIndexAdditonalFieldType.DateAndTime)
                        {
                            DateTime facetDateValue = DateTime.Parse(facetElementLabel);
                            facetElementLabel = facetDateValue.ToSitefinityUITime().ToString("MMM dd, yyyy");
                        }

                        value++;
                        bool hideElement = (value > defaultFacetsCollapseCount) && Model.IsShowMoreLessButtonActive;

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(" ");

            
            #line 45 "..\..MVC\Views\Facets\Facets.cshtml"
                                           Write(hideElement ? "hidden" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("id", Tuple.Create("\r\n                                   id=\"", 2301), Tuple.Create("\"", 2403)
, Tuple.Create(Tuple.Create("", 2342), Tuple.Create("facet-checkbox-", 2342), true)
            
            #line 47 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 2357), Tuple.Create<System.Object, System.Int32>(facet.FacetFieldName
            
            #line default
            #line hidden
, 2357), false)
, Tuple.Create(Tuple.Create("", 2378), Tuple.Create("-", 2378), true)
            
            #line 47 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 2379), Tuple.Create<System.Object, System.Int32>(facetElement.FacetValue
            
            #line default
            #line hidden
, 2379), false)
);

WriteLiteral("\r\n                                   class=\"form-check-input c-pointer\"");

WriteLiteral("\r\n                                   data-facet-key=\"");

            
            #line 49 "..\..MVC\Views\Facets\Facets.cshtml"
                                              Write(facet.FacetFieldName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                                   data-facet-value=\"");

            
            #line 50 "..\..MVC\Views\Facets\Facets.cshtml"
                                                Write(facetElement.FacetValue);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 2669), Tuple.Create("\"", 2736)
, Tuple.Create(Tuple.Create("", 2675), Tuple.Create("facet-checkbox-", 2675), true)
            
            #line 51 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 2690), Tuple.Create<System.Object, System.Int32>(facet.FacetFieldName
            
            #line default
            #line hidden
, 2690), false)
, Tuple.Create(Tuple.Create("", 2711), Tuple.Create("-", 2711), true)
            
            #line 51 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 2712), Tuple.Create<System.Object, System.Int32>(facetElement.FacetValue
            
            #line default
            #line hidden
, 2712), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2737), Tuple.Create("\"", 2772)
, Tuple.Create(Tuple.Create("", 2742), Tuple.Create("facet-", 2742), true)
            
            #line 51 "..\..MVC\Views\Facets\Facets.cshtml"
                                 , Tuple.Create(Tuple.Create("", 2748), Tuple.Create<System.Object, System.Int32>(facetElement.FacetValue
            
            #line default
            #line hidden
, 2748), false)
);

WriteLiteral(" class=\"form-check-label c-pointer\"");

WriteLiteral(">");

            
            #line 51 "..\..MVC\Views\Facets\Facets.cshtml"
                                                                                                                                                                         Write(facetElementLabel);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

            
            #line 52 "..\..MVC\Views\Facets\Facets.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 52 "..\..MVC\Views\Facets\Facets.cshtml"
                             if (Model.DisplayItemCount)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"small text-muted\"");

WriteLiteral(">(");

            
            #line 54 "..\..MVC\Views\Facets\Facets.cshtml"
                                                           Write(facetElement.FacetCount);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 55 "..\..MVC\Views\Facets\Facets.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </li>\r\n");

            
            #line 57 "..\..MVC\Views\Facets\Facets.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n");

            
            #line 59 "..\..MVC\Views\Facets\Facets.cshtml"
                if (facet.FacetElements.Count > defaultFacetsCollapseCount && Model.IsShowMoreLessButtonActive)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-link p-0\"");

WriteAttribute("show-more", Tuple.Create(" show-more=\"", 3330), Tuple.Create("\"", 3362)
            
            #line 61 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 3342), Tuple.Create<System.Object, System.Int32>(Model.ShowMoreLabel
            
            #line default
            #line hidden
, 3342), false)
);

WriteAttribute("show-less", Tuple.Create(" show-less=\"", 3363), Tuple.Create("\"", 3395)
            
            #line 61 "..\..MVC\Views\Facets\Facets.cshtml"
                               , Tuple.Create(Tuple.Create("", 3375), Tuple.Create<System.Object, System.Int32>(Model.ShowLessLabel
            
            #line default
            #line hidden
, 3375), false)
);

WriteLiteral(" data-facet-type=\"");

            
            #line 61 "..\..MVC\Views\Facets\Facets.cshtml"
                                                                                                                                                 Write(facet.FacetFieldName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3436), Tuple.Create("\"", 3477)
, Tuple.Create(Tuple.Create("", 3441), Tuple.Create("show-more-less-", 3441), true)
            
            #line 61 "..\..MVC\Views\Facets\Facets.cshtml"
                                                                                                                , Tuple.Create(Tuple.Create("", 3456), Tuple.Create<System.Object, System.Int32>(facet.FacetFieldName
            
            #line default
            #line hidden
, 3456), false)
);

WriteLiteral(">");

            
            #line 61 "..\..MVC\Views\Facets\Facets.cshtml"
                                                                                                                                                                                                                  Write(Model.ShowMoreLabel);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 62 "..\..MVC\Views\Facets\Facets.cshtml"
                }
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"sf-currentPageUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3622), Tuple.Create("\"", 3671)
            
            #line 69 "..\..MVC\Views\Facets\Facets.cshtml"
, Tuple.Create(Tuple.Create("", 3630), Tuple.Create<System.Object, System.Int32>(ViewBag.CurrentPageUrl ?? string.Empty
            
            #line default
            #line hidden
, 3630), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 71 "..\..MVC\Views\Facets\Facets.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Facets/query-string-utils.js"), "bottom", throwException: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 72 "..\..MVC\Views\Facets\Facets.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Facets/facets-widget.js"), "bottom", throwException: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
