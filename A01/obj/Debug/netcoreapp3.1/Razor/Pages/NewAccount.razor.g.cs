#pragma checksum "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ea45fc8d747fe4f6d7be00b6b7e9869d1ff131"
// <auto-generated/>
#pragma warning disable 1591
namespace A01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using A01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\School\Spring 2021\CS3750\CS3750\A01\_Imports.razor"
using A01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
using Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newaccount")]
    public partial class NewAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row text-center");
            __builder.AddMarkupContent(2, "<div class=\"col-md-3\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card a01-card");
            __builder.AddMarkupContent(7, "<div class=\"card-header a01-title\"><h3>New Account</h3></div>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                  acctModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                                             CreateAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddMarkupContent(19, "<label class=\"a01-form-label text-left\" for=\"fname\"><strong>First Name</strong></label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "fname");
                __builder2.AddAttribute(22, "class", "a01-input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "First Name");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                                                                                                  acctModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => acctModel.FirstName = __value, acctModel.FirstName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => acctModel.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "<label class=\"a01-form-label text-left\" for=\"lname\"><strong>Last Name</strong></label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "id", "lname");
                __builder2.AddAttribute(33, "class", "a01-input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "placeholder", "Last Name");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                                                                                                 acctModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => acctModel.LastName = __value, acctModel.LastName))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => acctModel.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddMarkupContent(41, "<label class=\"a01-form-label text-left\" for=\"email\"><strong>Email</strong></label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "email");
                __builder2.AddAttribute(44, "class", "a01-input");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "placeholder", "Email");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                                                                                             acctModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => acctModel.Email = __value, acctModel.Email))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => acctModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.AddMarkupContent(51, "<button class=\"btn btn-primary a01-btn\" type=\"submit\">Create Account</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n\r\n                ");
            __builder.AddMarkupContent(53, "<a href=\"/login\">Already have an account?</a>");
#nullable restore
#line 35 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                 if (!string.IsNullOrEmpty(message))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "class", "a01-message");
            __builder.AddContent(56, 
#nullable restore
#line 37 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                                        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    <div class=\"col-md-3\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\School\Spring 2021\CS3750\CS3750\A01\Pages\NewAccount.razor"
       
        private AccountModel acctModel = new AccountModel();
        private string message = string.Empty;

        //protected override async Task OnInitializedAsync()
        //{

        //}

        private async Task<bool> CreateAccount()
        {
            //message = await Auth.Test();
            return false;
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService Auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
    }
}
#pragma warning restore 1591
