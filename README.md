# .Net MVC5

### 1 - Create a Empty project
### 2 - Create a 'Hello World' project
### 3 - Use of 'NonAction' Atribute in MVC
### 4 - Routing {Conventional and Attribute}

<hr>

### Routings

<details>
  <summary>Conventional or Traditional routing</summary>
Go: App_Start/RoutesConfig.cs ><br>

Default <br>

```
public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
```

Custom <br>

```
public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
             routes.MapRoute(
                name: "AnyName",
                url: "Employee",
                defaults: new { controller = "Employee", action = "GetAllEmployee"}
            );
            // OR
            routes.MapRoute(
                name: "AnyName",
                url: "Employee/{Id}",
                defaults: new { controller = "Employee", action = "GetEmployee"}
            ); 
            // OR
             routes.MapRoute(
                name: "AnyName",
                url: "Employee/{Id}/Address",
                defaults: new { controller = "Employee", action = "GetEmployee"}
                constraints: new {id="@\d+"} // constraint use for accepting only int32
            );
        }
 ```    
  </details>
  
  <details>
   <summary>Attribute Routing</summary>
Go: App_Start/RoutesConfig.cs ><br>
  </details>
