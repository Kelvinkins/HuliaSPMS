#pragma checksum "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9cc8f9a9aafe515d16e2e2c764412b736ccea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyLightWeb.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SkyLightWeb.Pages.Pages_Index), null)]
namespace SkyLightWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/_ViewImports.cshtml"
using SkyLightWeb;

#line default
#line hidden
#line 3 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/_ViewImports.cshtml"
using SkyLightWeb.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9cc8f9a9aafe515d16e2e2c764412b736ccea2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d79aa224890f9b79ee6618ffe4ce74a53fc9c5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 745, true);
            WriteLiteral(@"

    <!-- Content Header (Page header) -->
    <div class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1 class=""m-0 text-dark"">Dashboard</h1>
          </div><!-- /.col -->
         <!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <!-- Main content -->
    <section class=""content"">
      <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
              <div class=""inner"">
                <h3>");
            EndContext();
            BeginContext(817, 20, false);
#line 30 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
               Write(Model.EquipmentCount);

#line default
#line hidden
            EndContext();
            BeginContext(837, 524, true);
            WriteLiteral(@"</h3>

                <p>Equipments</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-bag""></i>
              </div>
              <a href=""/Equipments"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
              <div class=""inner"">
                <h3>");
            EndContext();
            BeginContext(1362, 16, false);
#line 45 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
               Write(Model.AssetCount);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 523, true);
            WriteLiteral(@"</h3>

                <p>Assets</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
              <a href=""/Assets"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
              <div class=""inner"">
                <h3>");
            EndContext();
            BeginContext(1902, 20, false);
#line 60 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
               Write(Model.CustodianCount);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 530, true);
            WriteLiteral(@"</h3>

                <p>Custodians</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-person-add""></i>
              </div>
              <a href=""/Custodians"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
              <div class=""inner"">
                <h3>");
            EndContext();
            BeginContext(2453, 22, false);
#line 75 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
               Write(Model.TransactionCount);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 763, true);
            WriteLiteral(@"</h3>

                <p>Transactions</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-pie-graph""></i>
              </div>
              <a href=""/Transactions"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
                <div class=""table100 ver1 m-b-110"">
                    <div class=""table100-head"">
                        <table>
                            <thead>
                                <tr class=""row100 head"">
                                    <th  class=""cell100 column1"">
                                        ");
            EndContext();
            BeginContext(3239, 54, false);
#line 95 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Asset[0].AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(3293, 152, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th  class=\"cell100 column2\">\r\n                                        ");
            EndContext();
            BeginContext(3446, 56, false);
#line 98 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Asset[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(3502, 152, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th  class=\"cell100 column3\">\r\n                                        ");
            EndContext();
            BeginContext(3655, 56, false);
#line 101 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Asset[0].GpsProtocol));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 154, true);
            WriteLiteral("\r\n\r\n                                    </th>\r\n                                    <th  class=\"cell100 column4\">\r\n                                        ");
            EndContext();
            BeginContext(3866, 57, false);
#line 105 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Asset[0].Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(3923, 421, true);
            WriteLiteral(@"

                                    </th>
                                   
                                </tr>
                               
                            </thead>
                        </table>
                    </div>

                    <div class=""table100-body js-pscroll"">
                        <table>
                            <tbody>

                             
");
            EndContext();
#line 120 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                 foreach (var item in Model.Asset)
                                {

#line default
#line hidden
            BeginContext(4447, 164, true);
            WriteLiteral("                                <tr class=\"row100 body\">\r\n                                    <td class=\"cell100 column1\">\r\n                                        ");
            EndContext();
            BeginContext(4612, 44, false);
#line 124 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(4656, 151, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"cell100 column2\">\r\n                                        ");
            EndContext();
            BeginContext(4808, 46, false);
#line 127 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4854, 151, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"cell100 column3\">\r\n                                        ");
            EndContext();
            BeginContext(5006, 46, false);
#line 130 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.GpsProtocol));

#line default
#line hidden
            EndContext();
            BeginContext(5052, 151, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"cell100 column4\">\r\n                                        ");
            EndContext();
            BeginContext(5204, 47, false);
#line 133 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(5251, 121, true);
            WriteLiteral("\r\n                                    </td>\r\n                                   \r\n                                </tr>\r\n");
            EndContext();
#line 137 "/home/tenkay/Documents/DotNetProjects/HuliaSPMS/Pages/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5407, 271, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

        <!-- /.row (main row) -->
      </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->

  <!-- /.content-wrapper -->");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
