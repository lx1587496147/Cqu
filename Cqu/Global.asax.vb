Imports System.Web.Optimization
Imports System.Web.Mvc
Imports System.Web.Routing
Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' 应用程序启动时激发
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        AreaRegistration.RegisterAllAreas()
        RouteConfig2.RegisterRoutes(RouteTable.Routes)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        BundleConfig2.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class