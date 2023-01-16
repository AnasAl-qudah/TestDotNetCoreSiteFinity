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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.DropdownListField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/DropdownListField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.DropdownListField.DropdownListFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
  
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 485), Tuple.Create("\"", 513)
            
            #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 493), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 493), false)
, Tuple.Create(Tuple.Create(" ", 508), Tuple.Create("my-3", 509), true)
);

WriteLiteral(" data-sf-role=\"dropdown-list-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 620), Tuple.Create("\'", 676)
, Tuple.Create(Tuple.Create("", 628), Tuple.Create("{", 628), true)
, Tuple.Create(Tuple.Create(" ", 629), Tuple.Create("\"required\":", 630), true)
, Tuple.Create(Tuple.Create(" ", 641), Tuple.Create("\"", 642), true)
            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 643), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 643), false)
, Tuple.Create(Tuple.Create("", 674), Tuple.Create("\"}", 674), true)
);

WriteLiteral(" />\r\n    <label");

WriteLiteral(" class=\"form-label\"");

WriteAttribute("for", Tuple.Create(" for=\'", 711), Tuple.Create("\'", 743)
            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 717), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
   Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </label>\r\n    <select");

WriteAttribute("id", Tuple.Create(" id=\'", 804), Tuple.Create("\'", 835)
            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 809), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 809), false)
);

WriteLiteral("\r\n            data-sf-role=\"dropdown-list-field-select\"");

WriteAttribute("name", Tuple.Create("\r\n            name=\"", 891), Tuple.Create("\"", 937)
            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 911), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 911), false)
);

WriteLiteral("\r\n            ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
       Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n            class=\"form-select\"\r\n            aria-required=\"");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                      Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
              if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                        Write(Html.UniqueId("DropdownInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                       Write(Html.UniqueId("DropdownErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                             } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                                                          Write(Html.UniqueId("DropdownErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                                                                                                                } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                            (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var optionAttributes = isSelected ? "selected" : string.Empty;
            var optionValue = Model.IsRequired && choice == Model.Choices.FirstOrDefault() ? string.Empty : choice;


            
            #line default
            #line hidden
WriteLiteral("            <option ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
               Write(optionAttributes);

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                        Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                      Write(choice);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 34 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </select>\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2004), Tuple.Create("\'", 2047)
            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("DropdownErrorMessage")
            
            #line default
            #line hidden
, 2009), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"invalid-feedback\"");

WriteLiteral("></div>\r\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"form-text\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2207), Tuple.Create("\'", 2242)
            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2212), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("DropdownInfo")
            
            #line default
            #line hidden
, 2212), false)
);

WriteLiteral(">");

            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                            Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n</div>\r\n\r\n");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
