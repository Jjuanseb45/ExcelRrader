// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/home/sebastian/RiderProjects/WebApplication/WebApplication/Pages/ExcelReaderComponent.razor"
 
    string source;
    DataTable table;
    List<Persona> personasLista = new List<Persona>();

    protected void ProcessExcel()
    {
        string path = @"/home/sebastian/Descargas/HojaPruebas.xlsx";
        var DataSet = _excelReaderService.Read(path);
        foreach (DataTable table in DataSet.Tables)
        {
            foreach (DataRow row in table.Rows)
            {
                personasLista.Add(new Persona()
                {
                    Apellido = (string) row ["Apellido"],
                    Nombre = (string) row ["Nombre"],
                    Aficion = (string) row ["Aficion"]
                });
            }
        }

/*
        foreach (DataColumn persona in a)
        {
            personasLista.Add(new Persona()
            {
                Nombre = persona.Prefix,
            });
        }


    //TODO: Preguntar si necesitamos crear un objeto por cada una de las tablas

    /*
DataRow row = table.Rows[0];
string cell = row[0].ToString();

Persona persona = new Persona()
{
Apellido = row[0].ToString(),
Aficion = row[1].ToString(),
Nombre = row[2].ToString()
};
*/
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExcelReaderService _excelReaderService { get; set; }
    }
}
#pragma warning restore 1591