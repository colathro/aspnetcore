// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderChildComponent(__builder); 

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    void RenderChildComponent(RenderTreeBuilder __builder)
    {

#line default
#line hidden
#nullable disable
        __builder.AddContent(0, "        ");
        __builder.OpenComponent<Test.MyComponent>(1);
        __builder.CloseComponent();
        __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591