#pragma checksum "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f8aaed343e8d8534df2ce7fb482e6989e615efd"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/sebastian/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
using WebApplication.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
using WebApplication.Data.Persona;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/excelreader")]
    public partial class ExcelReaderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head b-z97r91exr3><link rel=\"stylesheet\" href=\"ExcelReaderComponent.razor.css\" b-z97r91exr3></head>\n\n");
            __builder.OpenElement(1, "body");
            __builder.AddAttribute(2, "b-z97r91exr3");
            __builder.AddMarkupContent(3, "<h3 b-z97r91exr3>ExcelReaderComponent</h3>\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "file");
            __builder.AddAttribute(6, "id", "FileManager");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                                          source

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => source = __value, source));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(9, "b-z97r91exr3");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                                          ProcessExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "b-z97r91exr3");
            __builder.AddContent(15, "Importar");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n\n");
            __builder.OpenComponent<MatBlazor.MatTabGroup>(17);
            __builder.AddAttribute(18, "ActiveIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                                 tabIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ActiveIndexChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tabIndex = __value, tabIndex))));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 20 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
     foreach (DataTable tabla in tablas)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatTab>(21);
                __builder2.AddAttribute(22, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                       tabla.TableName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WebApplication.Pages.ExcelReaderComponent.TypeInference.CreateMatTable_0(__builder3, 24, 25, 
#nullable restore
#line 23 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                              personasLista

#line default
#line hidden
#nullable disable
                    , 26, "mat-elevation-z5", 27, (__builder4) => {
                        __builder4.AddMarkupContent(28, "<th b-z97r91exr3>Nombre</th>\n                    ");
                        __builder4.AddMarkupContent(29, "<th b-z97r91exr3>Apellido</th>\n                    ");
                        __builder4.AddMarkupContent(30, "<th b-z97r91exr3>Aficion</th>");
                    }
                    , 31, (context) => (__builder4) => {
                        __builder4.OpenElement(32, "td");
                        __builder4.AddAttribute(33, "b-z97r91exr3");
                        __builder4.AddContent(34, 
#nullable restore
#line 30 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                         context.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(35, "\n                    ");
                        __builder4.OpenElement(36, "td");
                        __builder4.AddAttribute(37, "b-z97r91exr3");
                        __builder4.AddContent(38, 
#nullable restore
#line 31 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                         context.Apellido

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\n                    ");
                        __builder4.OpenElement(40, "td");
                        __builder4.AddAttribute(41, "b-z97r91exr3");
                        __builder4.AddContent(42, 
#nullable restore
#line 32 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
                         context.Aficion

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 37 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
 

    public int tabIndex = 0;
    string source;
    DataTable table;
    List<Persona> personasLista = new List<Persona>();
    List<DataTable> tablas = new List<DataTable>();

    protected void ProcessExcel()
    {
        string path = @"/home/sebastian/Descargas/HojaPruebas.xlsx";
        DataSet dataSet = _excelReaderService.Read(path);
        foreach (DataTable table in dataSet.Tables)
        {
            tablas.Add(table);
            foreach (DataRow row in table.Rows)
            {
                personasLista.Add(new Persona()
                {
                    Apellido = (string) row["Apellido"],
                    Nombre = (string) row["Nombre"],
                    Aficion = (string) row["Aficion"]
                });
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExcelReaderService _excelReaderService { get; set; }
    }
}
namespace __Blazor.WebApplication.Pages.ExcelReaderComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
