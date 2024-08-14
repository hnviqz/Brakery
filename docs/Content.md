### Learn Razor Pages——Your guide to using ASP.NET Core Razor Pages

#### Home
##### A First Look
###### Welcome To Learn Razor Pages

This site is dedicated to helping developers who want to use the ASP.NET Razor Pages web development framework to build web applications.

这个站点专门帮助开发者学习使用ASP.NET Razor Pages Web开发框架去构建Web应用。

###### What is Razor Pages?

Introduced as part of ASP.NET Core, and now included in .net 5，ASP.NET Razor Pages is a server-side, page-focused framework that enables building dynamic, data-driven web sites with clean separation of concerns. Part of the ASP.NET Core web development framework from Microsoft, Razor Pages supports cross platform development and can be deployed to Windows, Unix and Mac operating systems.

The Razor Pages framework is lightweight and very flexible. It provides the developer with full control over rendered HTML. Razor Pages is the recommended framework for cross-platform server-side HTML generation.

Razor Pages makes use of the popular C# programming language for server-side programming, and the easy-to-learn Razor templating syntax for embedding C# in HTML mark-up to generate content for browsers dynamically.

Architecturally, Razor Pages is an implementation of the MVC pattern and encourages separation of concerns.

###### Who should use Razor Pages?

Razor Pages is suitable for all kinds of developers from beginners to enterprise level. It is based on a page-centric development model, offering a familiarity to web developers with experience of other page-centric frameworks such as php, Classic ASP, Java Server Pages，ASP.NET Web Pages and ASP.NET Web Forms. It is also relatively easy for the beginner to learn，and it includes all of the advanced features of ASP.NET Core(such as dependency injection) making it just as suitable for large, scalable, team-based projects.

###### How to get Razor Pages

Razor Pages is included within .NET Core from version 2.0 onwards, which is available as a free download as either an SDK (Software Development Kit) or Runtime. The SDK includes the runtime and command line tools for creating .NET Core applications. The SDK is installed for you when you install Visual studio 2017 update 3 or later. The runtime is used to run .NET Core applications. The Runtime-only installation is intended for use on machines where no development takes place.

###### Why should you use Razor Pages?

if you want a dynamic web site, that is one where the content is regularly being added to, you have a number of options available to you. You can use a Content Management System(CMS), of which there are many to choose from including WordPress, Umbraco, Joomla!, Drupal, Orchard CMS and so on. Or you can hire someone to build a suitable site for you. Or you can build your own if you have an interest in, and and aptitude for programming.

If you choose to build your own, you can choose from a wide range of programming languages and frameworks. If you are a beginner, you will probably want to start with a framework and language that is easy to learn, well supported and robust. If you are considering making a career as a programmer, you probably want to know that the skills you acquire while learning your new framework will enhance your value to potential employers. In both cases, learning C# as a language and ASP.NET Core as a framework will tick those boxes. If you are a seasoned developer, the Razor Pages framework is likely to add to your skillset with the minimum amount of effort.

###### What about the MVC Framework?

You can still choose to use ASP.NET Core MVC to build your ASP.NET Core web applications. If you are porting an existing .NET Framework MVC application(MVC5 or earlier) to .NET Core, it may well be quicker or easier to keep with the MVC framework. However, Razor Pages removes a lot of the unnecessary ceremony that comes with the ASP.NET implementation of MVC and is a simpler, and therefore more maintainable development experience.

The key difference between Razor Pages implementation of the MVC pattern and ASP.NET Core MVC is that Razor Pages uses the Page Controller pattern instead of the Front Controller pattern.

Razor Pages is the default for building server-side web applications in ASP.NET Core. Components within the underlying MVC framework still have their uses such as using controllers for building RESTful APIs.

#### ASP.NET CORE

##### What is ASP.NET Core?

ASP.NET Core is the first cross-platform version of Microsoft's framework for building web-based applications. It sits on top of .NET Core，which is an open source development platform, consisting of a set of framework libraries, a software development kit(sdk) and a runtime.

> 
> :warning:ASP.NET Core is now included within .NET and feature cross-platform desktop application development frameworks as well as cross-platform web development frameworks.

##### Why should you choose ASP.NET Core?

Web development is changing. There is demand for more modular frameworks, where you decide the features to include in your application. Applications should be cloud-ready-designed to run on any platform and to scale up quickly. They should also embrace client-side frameworks and make developing RESTful APIs easy. And the frameworks themselves need to be nimble. They need to iterate quickly to deliver new features in response to new innovations in the web development sphere. And developers want to be able to choose the tools they use to author sites.

Some frameworks already address these concerns, such as Express that runs on Node.js. The old version (.NET Framework) of ASP.NET doesn't. It is wedded to Internet Information Services, a Windows-only web server. New features took ages to come to market because of the way that the framework is tied to the full .NET framework. And it's very dependent on Visual Studio - a monster of and IDE that only runs on Windows.

>
> :warning: Note that the product known as Visual Studio for Mac is not actually a version of IDE that most .NET developers are familiar with. It is a version of Xamarin Studio that supports .NET Core development.

ASP.NET Core is designed to be modular. The HTTP pipeline is composed of separate components that can be plugged in as needed. The benefits that this approach delivers include:

- your application is more lightweight as it only incorporates the components it needs
- you can choose pipeline components from multiple sources
- you can even create your own version of the pipeline components and use those instead
- you can choose which platform to host your application on
- new features are added much more quickly than in previous version of ASP.NET

ASP.NET Core provides a web development framework based on the Model-View-Controller(MVC) pattern. On top of that sits the Razor Pages framework for  developers who are more familiar with or prefer a page-centric development approach to building web applications. In addition, ASP.NET Core includes Blazor, a Single Page Application framework that enables you to use C# as the client-side programming language. ASP.NET Core also includes a framework for developing REST-based web services(Web API) and a Web Sockets-based framework(SignalR) which enables real-time updating of page content initiated by the server.


#### Turoials

##### Razor Pages Bakery Tutorial Introduction

This step-by-step tutorial demonstrates how to create a Razor Pages application from scratch, and how to add common functionality to it including communicating with a database, working with cookies, forms and sending email.

The application you will build is inspired by the ASP.NET Web Pages Bakery template site. The ASP.NET Web Pages framework was a page-based web development from Microsoft, which has effectively been replaced by the Razor Pages framework. The template site itself represents an online ordering system that enables users to place orders for a variety of baked goods. From a technical perspective, the original site demonstrated

- the use of a file-based database for storing product information
- basic data access
- creating and processing forms
- sending email


#### Razor Pages Files
#### Razor Syntax
#### Page Models
#### Tag Helpers
#### View Components
#### Routing and URLs

##### Razor Pages Routing

Routing is the system that matches URLs to Razor pages. Like most page-centric frameworks, the primary routing system in ASP.NET Razor Pages is based on matching URLs to file paths, starting from the root Razor Pages folder, which is named Pages by default.

路由是匹配URLs到Razor Pages的系统。如大部分集中式页面框架一样，ASP.NET Razor Pages中的路由系统是基于URLs到文件路径匹配，起点为root页文件夹，默认命名为Pages。

##### How URLs are matched

When a Razor Pages application starts up, a collection of Attribute Routes(familiar to anyone who has used them in ASP.NET MVC 5 or MVC Core) is constructed, using the file and folder paths rooted in the Pages folder as the basis for each route's template.

当一个Razor Pages应用启动时，一个属性路由集合已经被建构，

The standard Razor Pages site template includes three pages in the root folder:

```
Error.cshtml
Index.cshtml
Privacy.cshtml
```
A collection of four routes are defined with the following route templates:

```
""
"Error"
"Index"
"Privacy"
```

By default, the route templates are generated by taking the virtual path of each content page and then removing the root folder name from the start and the file extension from the end.

缺省情况下，路由模板通过每个content页的虚拟目录移除开始部分的文件夹名称和文件的后缀名来生成。


Index.cshtml is considered the default document in any folder, so it has two routes defined - one for the file name without the extendsion, and one with an empty string representing the file. Therefore, you can access Index.cshtml by browsing to both http://yourdomain.com/ and http://yourdomain.com/index.

If you create a folder named Test and add a file named Index.cshtml to it, a further two routes will be defined with the following templates:

如果你创建一个文件夹，命名为Test，之后添加一个名为Index.cshtml的文件在该文件夹内，下面模板的路由将被定义：

```
"Test"
"Test/Index"
```

Both of these routes will be mapped to the same virtual path: /<root>/Test/Index.cshtml.

However, if you now add a file called Test.cshtml to the root pages folder and attempt to browse to it, an exception will be raised:

>
> AmbiguousActionException:Multiple actions matched. The following actions matched route data and had all constraints satisfied:
>
> Page: /Test/Index
> Page：/Test

As the exception message says, it is an error to have a single URL mapped to multiple actions or routes. The framework has no way of knowing which page to call. You can disambiguate between routes by adding route parameters and/or constraints to the template.

##### Areas

Areas were introduced to Razor Pages in ASP.NET Core 2.1. Routes to resources in areas have the name of the area as the first segment of the URL. In the following example, the area is named Administration.

```
Areas
    Administration
        Pages
            Index.cshtml
            Reports.cshtml
    Production
        Pages
            Index.cshtml
Pages
    Error.cshtml
    Index.cshtml
    Privacy.cshtml
```

The additional routes created for the content in the areas is as follows:

```
"Administration"
"Administration/Index"
"Administration/Reports"
"Production"
"Production/Index"
```

The names of the Areas folder and the Pages folder do not feature as part of the route template.

##### Changing the default Razor Pages root folder

you can use configuration to change the root folder for Razor pages. The following example changes the root folder from the default Pages to Content:

```csharp
builder.Services.AddRazorPages().AddRazorPagesOptions(options=>{
    options.RootDirectory = "/Content";
}   
);
```

or you can use the WithRazorPagesRoot extendsion method:

```csharp
builder.Services.AddRazorPages().WithRazorPagesRoot("/Content")`;
```

Note that you cannot change the root folder for pages located in areas.

##### Route Data

Let's say you have created a blog. You may have a page called Post.cshtml in your root pages folder in which you display the content of specific posts. You provide a series of links on your home page to individual posts, and each one includes a value in the URL to identify the specific post to retrieve from the database. You could supply this value as a query string value (www.myblog.com/post?title-my-latest-post), or you could add it as Route Data - a segment in the URL that plays no part in matching files on disk e.g. /my-latest-post in www.myblog.com/post/my-latest-post. The last segment, or parameter is an arbitrary piece of data passed in the URL. The Route Data approach is preferred for a number of reasons, among which it is more readable - especially if you have a number of parameter values - and it is more search engine - friendly.

##### Route Templates

Route Data parameters are defined in a Route Tempalte as part of the @page directive in the .cshtml file. To cator for the title value in the exmaple above, the declaration at the top of the Post.cshtml file will look like this:

```
@page "{title}"
```

The template created for this route is "Post/{title}". The {title} part of template is a placeholder that represents any value added to the URL after post/. The template definition must appear in double quotes, and the parameter must be enclosed in curly brackets or braces.

In this example, the value is required, so you cannot just browse to /post. You must provide a value in the URL to match the "title" segment, otherwise you will get a status code of 404 - Not Found. However, you can make the parameter optional by adding a ? after it:

```
@page "{title?}"
```

Or you can provide a default value for the parameter:

```
@page "{title=first post}"
```

There is no limit to the number of parameters you can add to a route, although there is a limit to the data types that you can use as route parameters. Only simple types, such as string,datetime,boolean and numeric types are supported. It is common to see blog post urls include the year, month and day of publication as well the title. A route definition that accomplishes this might appear as follows:

```
@page "{year}/{month/{day}/{title}}"
```

> :warning: **Warning**
>
> The following words are reserved for ASP.NET Core routing and should not be used as names for route or handler parameters or query string keys as they are unlikely to be bound correctly:
>
> - action
> - area
> - controller
> - handler
> - page

##### Accessing route parameter values

Route parameter values are stored in a RouteValueDictionary accessible via the RouteData.Values property. You reference values by their string-based key:

```
@RouteData.Values["title"]
```

The potential problem with this approach is that it relies on referencing values by strings, which are prone to typographical errors, resulting in runtime errors. The recommended alternative is to bind the values to properties on a PageModel. To do this, you can add a public property of a suitable data type to the page model class and a parameter to the OnGet() method with the same name and data type as the route parameter:

```csharp
public class PostModel:PageModel
{
    public string? Title{get;set;}
    public void OnGet(string title)
    {
        Title = title;
    }
}
```

You assign the parameter value to the public property, which makes it available on the Model property in the content page:

```razor
@page "{title?}"
@model PostModel
@{
}
<h2>@Model.Title</h2>
```

The key reason for recommending this approach is that you benefit from strong typing and therefore IntelliSense support in IDE's that support it:

![智能提示](assets/1.png)

Alternatively, you can use the [BindProperty] attribute on the PageModel property with SupportsGet set to true:

```csharp
public class PostModel:PageModel
{
    [BindProperty(SupportsGet=true)]
    public string Title {get;set;} 

    public void OnGet()
    {
        //the Title property is automatically  bound
    }
}
```

##### Adding Constraints

Constraints are an additional means of disambiguating between routes. So far, the only constraint placed on a route parameter value is its presence. You can also constraint route parameters values by data type and range. The following exmaple shows how to constrain a parameter value to an integer data type:

```razor
@page "{id:int}"
```

The `id` value is both required, and must be an integer. The next example illustrates an optional parameter, which must be a double if a value is provided:

```razor
@page "{latitude:double?}"
```

The next example shows use of the min constraint, that ensures that the value supplied is an int and that it meets a minimum value of 10000. The minimum value is supplied in parenttheses:

```razor
@page "{id:min(10000)}"

```
The final exmaple shows how to specify multiple constraints using colons:

```razor
@page "{username:alpha:minlength(5):maxlength(8)}"
```
This template specifies that the username values is required (i.e. is not optional), must be composed of a mixture of upper case and lowercase letters (no numbers or others symbols), has a minimum length of 5 characters and a maximum length of 8 characters.

The range of constraints available are extensive, but you can also create your own custom route constraints.

##### Override Routes

From ASP.NET Core 2.1 onward, you can use the template to specify an alternative route for a page that has no relationship with the file name. The override route template should start with / or ~/. For example, you may have a page located deep in the folder structure somewhere e.g. Pages/Projects/Building/SOP/Schools/Intro.cshtml that you want to surface at an much easier to remember URL: schools/sop. You do this by specifying the URL pattern in the template:

```razor
@page "/schools/sop"
```

This replaces the file-path-based URL.

You can use a similar approach to add segments to a route. This is achieved by omitting the / or ~/ from the start of the template. The following template will require the user to add /schools to the default route that is generated for the page:

```razor
@page "schools"
```

##### Register Additional Routes

The final plece in the Razor Pages routing jigsaw is based on the "Friendly URLs" feature found in ASP.NET Web Forms(another page-centric development model) which enables you to bypass the tight relationship between URL and the file path and name of the page that's being requested and create additional routes to those pages.

Additional route mappings to pages can be configured by adding options to the `RazorPageOptions.PageConventions` collection in the `ConfigureServices` method in Startup via the `AddPageRoutes` method. In this example, a physical file named Post exists in /Pages/Archive/. You want to enable users to reach it without prepending Archive to the URL, and you want to specify some route parameters. You do that as follows:

```csharp
builder.Services.AddRazorPages()
        .AddRazorPagesOptions(options=>{
            options.Conventions.AddPageRoute("/Archive/Post", "Post/{year}/{month}/{day}/{title}");
        });
```

The `AddPageRoute` method takes two parameters. The first is the relative path to the Razor page file without the extension and the second is the route template that maps to it.

Unlike Absolute Routes, friendly routes are additive, that is they do not replace existing routes. They act in a similar way to method overloads in programming. It will still be possible to reach the resource above by navigating to `/archive/post`. Consequently it is possible to add a "catchcall" friendly route without affecting routes generated from physical files. The following exmaple illustrates a route that catches any URL that doesn't map to a physical file and gets the Index.cshtml file to process the request:

```csharp
builder.Services.AddRazorPages()
    .AddRazorPagesOptions(options=>
    {
        options.Conventions.AddPageRoute("/index","{*url}");
    });
```

You might  do this, for exmaple, if your Index.cshtml file is responsible for locating and processing Markdown files based on the URL, as is the case with this site.

There is also a method for overloading routes to pages in areas: `AddAreaPageRoute`. This takes the name of the area, the name of the page, and the route template e.g.

```csharp
builder.Services.AddRazorPages()
    .AddRazorPagesOptions(
        options=>
        {
            options.Conventions.AddAreaPageRoute("Administration", "/index", "admin");
        }
    );
```

##### other Routing Options

The routing system provides some additional configuration options via properties of the `RouteOptions` object which can be accessed in the ConfigureServices method. The properties are as follows:

|Property|Type|Description|
|---|---|---|
|AppendTrailingSlash|bool|Appends a trailing slash to URLs generated by the anchor tag helper or UrlHelper. Default is false|
|ConsraintMap|IDictionary<string,Type>|Enables the registration of custom constraints via the Add method|
|LowercaseUrls|bool|URLs are generated all in lower case. The default is false|
|LowercaseQueryStrings|bool|Query strings are generated all in lower case. The default is false. Will only take effect if lowercaseUrls is also true|

Examples:

```csharp
builder.Services.Configure<RouteOptions>(
    options=>{
        options.LowercaseUrls = true;
        options.LowercaseQueryStrings = true;
        options.AppendTrailingSlash = true;
        options.ConstraintMap.Add("Custom",typeof(CustomConstraint));
    }
)；
```

##### Generating Urls

Razor Pages provides two main mechanisms for generating URLs to pages within the application, depending on where they are needed.

##### Anchor Tag Helper

The anchor tag helper is designed to be used to render anchor elements within content pages:

`<a asp-page="/Supplier" asp-route-id="2">Click</a>`

You can read more about the anchor tag helper here.

##### The LinkGenerator

The `LinkGenerator` service is available in Razor Pages 3 onwards. Registered by default with the dependency injection system, you can use the `LinkGenerator` within classes (such as PageModels) to generate URLs based on the route information provided.

There are two Razor Pages specific methods for generating URLs: `GetPathByPage` and `GetUriByPage`. The `GetPathByPage` method generates a relative URL, and the `GetUriByPage` method generates an absolute URL:

```csharp
public class LinkGeneratorDemoModel : PageModel
{
    private LinkGenerator linnkGenerator;
    public LinkGeneratorDemoModel(LinkGenerator linkGenerator)=>this.linkGenerator = linkGenerator;
    public string PathByPage{get;set;}
    public string UriByPage{get;set;}

    public void OnGet()
    {
        PathByPage = linkGenerator.GetPathByPage("/Supplier", null, new {id=2});
        UriByPage = linkGenerator.GetUriByPage(this.HttpContext, "/Supplier", null, new{id=2});
    }
}
```

##### Output

Path By Page: /supplier/2
Uri By Page : https://localhost:5001/supplier/2

**Note**: this output assumes that the option to use lower case URLS is set to true.

The `LinkGenerator` service also provides a number of methods for working with URLs related to MVC controllers.

##### Customising Route Conventions in Razor Pages

When a Razor Pages application starts up, the framework exmaples the files located in the Pages folder and generates a set of route templates based on the file path of each file, treating Index.cshtml as the default file for a folder. If  a template has been added to the `@page` directive, that is also traken into consideration and the generated template is modified accordingly.

In this way, it is possible to specify that route data values can or should be part of the URL that matches the file, or to specify that the file is located using a URL that has no relationship at all with its file path. You also have recourse to the `AddPageRoute` method in Razor Pages Options, but all of these approaches to custominsation only affect the routing to one file at a time.

##### PageRouteModel

The route tempalte information for each page is in a PageModel class. One `PageRouteModel` class is created for each navigable Razor Page at application startup. The routing information includes the file name and relative path of the Razor Page, and a collection of `SelectorModel` objects, each on containing details of the attribute route that can be used to reach a page. This information is held in an `AttributeRouteModel` object, which is where the route template is stored.

when the default routing conventions are used, one `SelectorModel` is generated for most pages. The default page (Index.cshtml) has two `SelectorModel` built - one for the "index" template and on for the empty string (""). When you use the AddPageRoute method, an  additional `SelectorModel` is added to the `PageRouteModel` containing details of the template specified in the method call.

The following diagram depicks a simplified view of the `PageRouteModel` instance that is typically built for Index.cshmtl:

![PageRouteModel](assets/2.png)

##### IPageRouteModelConvention

The `IPageRouteModelConvention` interface is designed to allow customisation of the PageRouteModel to override the default conventions. The interface has one member that needs to be implemented - the `Apply()` method. It is in this method that you can access metadata about the current routing set up and modify or add to it as required.

To summaries, there are three steps to customising Razor Pages routing:

1. Create a class that implments IPageRouteModelConvention
2. Implement its Apply method
3. Register the class with Razor Page Options

Here are two examples that show how to do this. This first  example illustrates how to replace the generated route templates with new ones, so that pages are found using a different algorithm, rather than a simple match of file path to URL. The second shows how to add more route templates on top of the generated one so that users can find a page using URLs in their own language.

##### Creating A New Convention

As your Line Of Business(LOB) application grows, you are likely to have many feature - related folders in the application, each containing files named after the action that are responsible for: an Index.cshtml, and an Edit.cshtml, a Details.cshtml and so on. After a while, having multiple Index.cshtml files open in your IDE becomes confusing:

![多个同名文件提示](assets/3.png)

So you decide instead to create files named after the feature and the action: the Index.cshtml file in the Orders folder becomes OrdersIndex.cshtml, Edit.cshtml become OrdersEdit.cshtml and so on. However, you still want the OrdersIndex.cshtml page to act as a default page, and you want users to be able to navigate to /orders/edit, /orders/detail and so on.

the following class shows the first two steps required to implement a new routing convention:

```csharp
public class CustomPageRouteModelConvention:IPageRouteModelConvention
{
    public void Apply(PageRouteModel model)
    {
        foreach(var selector in model.Selectors.ToList())
        {
            var template = selector.AttributeRouteModel.Template;
            if(template.Contains("/"))
            {
                var segments = template.Split(new[]{'/'},StringSplitOptions.None);
                if(segments.Count() == 2)
                {
                    selector.AttributeRouteModel.Template = $"{segments[0]}/{segments[1].Replace(segments[0],string.Empty).Replace("Index",string.Empty)}".TrimEnd('/');
                }
                else
                {
                    throw new ApplicationException("Nested folders are not permitted");
                }
            }
        }
    }
}
```
The class implements the `IPageRouteConventionModel` interface and provides an implementation of the `Apply` method. This is executed for every page found by the Razor Pages framework. The method iterates the collection of `SelectModel` objects that belong to the current `PageRouteModel`, and acquires a reference to the template. If the template includes a forward slash, it belongs to a page in a sub  folder, that is, not the Pages root folder. If  that is the case, the folder name is removed from the template, so for Orders/OrdersEdit.cshtml, the template changes from "orders/ordersedit" to "orders/edit". "Index" is replace with an empty string.

In addition, if there are more than two segments in the template, an Exception is raised. We don't want any sub folders being added to the features folders.

The final step involves registering the new convention with `RazorPagesOptions`:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddRazorPage().AddRazorPagesOptions(options=>{
        options.Conventions.Add(new CustomPageRouteModelConvention());
    });
}
```

##### Catering For Multiple Languages

If you are providing a web site for a global audience, you might want to provide them with couresy of friendly URLs in their language. Or you might want to do this for SEO purposes. Italians would be able to reach the contact page at domain.com/contatto. Germans could reach it at domain.com/kontact etc. You could add calls to the `MapPageRoute` method in `Startup` (see Friendly Routes). But this approach won't scale very well if you have hundreds of pages and cater for an increasing number of languages. The method calls will grow exponentially.

What you can do instead is to use the `IPageRouteConventionModel` interface to add additional patterns based  on a the contents of a database or similar. To illustrate this, here is the definition of a simple service that emulates obtaining the translations of the page names:

```csharp
public interface ILocalizationService
{
    List<LocalRoute> LocalRoutes();
}

public class LocalizationService:ILocalizationService
{
    public List<LocalRoute> LocalRoutes()
    {
        var routes = new List<localRoute>{
            new LocalRoute{
                Page = "/Pages/Contact.cshtml",
                Versions = new List<string>{"kontakt","contacto","contatto","kontakta"}
            }
        };
        return routes;
    }
}

public class LocalRoute
{
    public string Page { get; set;}
    public List<string> Versions {get;set;}   
}
```

And here is how that service is consumed within a `PageRouteModelConvention` class:

```csharp
public class LocalizedPageRouteModelConvention: IPageRouteModelConvention
{
    private ILocalizationService _localizationService;

    public LocalizedPageRouteModelConvention(ILocalizationService localizationService)
    {
        _localizationService = localizationService;
    }

    public void Apply(PageRouteModel model)
    {
        var route = _localizationService.LocalRoutes().FirstOrDefault(p => p.Page == model.RelativePath);
        if (route != null)
        {
            foreach (var option in route.Versions)
            {
                model.Selectors.Add(new SelectorModel()
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Template = option
                    }
                });
            }
        }
    }
}
```

This convention also needs to be registered in `Startup`, along with the service:

public void CoinfigureServices(IServiceCollection services)
{
    ...
    services.AddRazorPages().AddRazorPagesOptions(options=>{
      options.Conventions.Add(new LocalizedPageRouteModelConvention());  
    });
    services.AddTransient<ILocalizationService,LocalizationService>();
}

Now an individual page can be reached by any number of registered languages:

![本地化](assets/4.png)

#### Application Startup

##### Configuring a Razor Pages application

> :warning: This section applies to configuring Razor Pages applications from .NET 6 onwards. If you are interested in app configuration in earlier versions of .NET, please refer to the section on Startup.

Configuring a Razor Pages application involves managing three aspects of the application:

- Services
- Routing
- Request Pipeline

The code within the Program.cs file is responsible for configuring, or bootstrapping an ASP.NET Core web application and starting it. In .NET 5 and earlier, this code was split across two separate files. Much of the application configuration was delegated to a separate class named Startup.cs. With the release of .NET 6, the developers behind ASP.NET have tried to reduce the amount of complexity that used to exist in basic application configuration. Rather than have code across two files, they have consolidated it into one file, taken advantage of some new C# features to further reduce the boilerplate, and then introduced what they refer to as a minimal hosting API to reduce to a minimum the code required to bootstrap and run a Razor Pages application.

The result is thirteen actual lines of code in a single file. It was nearer eighty in previous versions of Razor Pages, spread across the two files.

Program.cs provides the entry point to a .NET console application. By convention, it houses a static Main method that contains logic for executing the application. The Program.cs file in Razor Pages from .NET 6 onward is no different, except that there is no Main method visible. The project template utilizes some newer C# language features introduced in C# 10, one of which is top-level statements. This feature enables the omission of the class declaration and Main method in Program.cs. The compiler will generate the class and Main method and call any executable code you add to the file within the Main method.

The first line of code in Program.cs creates a WebApplicationBuilder:

```csharp
var builder = WebApplicationBuilder.CreateBuilder(args);
```

Remember that this code will be executed within the compiler-generated Main method, so the args passed into the CreateBuilder method are the standard args passed into the Main method of any C# console application by whatever process invokes tha application and are optional.

The WebApplicationBuilder is new in .NET 6 and forms part of the mininal hosting API together with another new type - the WebApplication. The WebApplicationBuilder has several properties, each on enabling configuration of various aspects of the application:

- Environment = provides information about the web hosting environment the application is running in.
- Services - represents the application's service container
- Configuration - enabling logging configuration via the ILoggingBuilder
- Host - supports configuration of application host specific services including third party DI containers
- WebHost - enables web server configuration

The application host is responsible for bootstrapping the application, starting it up and shutting it down. The term bootstrapping refers to the initial configuration of the application itself. This configuration includes:

- Setting the content root path, which is the absolute path to the directory that contains the application content files
- Loading configuration information from any values passed in to the args parameter, appsettings files and environment variables
- Configuring logging providers

All .NET applications are configured in this way, whether they are web applications, services or console applications. On top of that, a web server is configured for web applciations. The web server is configured through the WebHost property which represents and implementation of the IWebHostBuilder type. The default web server is a lightweight and extremely fast web server named Kestrel. The Kestrel server is incorporated within the application. The IWebHostBuilder also configures host filtering and integration with Internet Information Services (IIS)，the Windows web server.

The IWebHostBuilder object exposes several extension methods that enable further configuration of the application. For example, you can configure an alternative to the wwwroot folder as the web root path, if you really had a good reason to. Here, the content folder is configured as a replacement for wwwroot.

```csharp
builder.WebHost.UseWebRoot("content");
```

The Services property provides the entry point to the dependency injection container, which is a centrallized  place for application services. The default template includes the following line of code, which makes the essential services that the Razor Pages infrastructure relies upon available to the application:

```csharp
builder.Services.AddRazorPages();
```

Those services include the Razor view engine, model binding, request verification, tag helpers, memory cache and ViewData.

Sometimes these services will be parts of the framework that you choose to enable (like the Razor Pages example), and sometimes they represent services that you install as separate packages. Often, they will be services that you write yourself that hold the application logic, like getting and saving data.

The build method returns the configured application as an instance of the WebApplication type.

```csharp
var app = builder.Build();
```

The WebApplication type represents a merger of three other types:

- IApplicationBuilder - through which you configure the application's request, or middleware pipeline.
- IEndpointRouteBuilder - enables you to configure how incoming requests are mapped to specific pages
- IHost - provides the means to start and stop the application

The WebApplication enables you to register middleware components to build and configure the application's request pipeline. Here is the default request pipeline:

```csharp
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
```

Each middleware is added to the pipeline via an extension method on the IApplicationBuilder type which is implemented by WebApplication. An IWebHostEnvironment is accessible via the Environment property, which holds information about the current environment. This property is used to determine whether the application is currently running in Devlopment mode, and if so, the UseExceptionHandler method is called that adds middleware for catching errors and displaying details of them in the browser. Otherwise, the error page in the Pages folder is used to display a bland message that conceals any in sensitive information about the specifics of the error to the user, such as database connectyion strings containing user credentials, or information about file paths on the server. Middleware that adds an HTTP Strict Transport Security header is also registered(app.UseHsts()), but only if the application is not running in Development mode. This header tells the browser to only use HTTPS when accessing the website.

The UseHttpsRedirection method adds middleware that ensures that any HTTP requests are redirected to HTTPS. Following this, the static middleware is registered. By default, an ASP.NET Core application doesn't support serving static files such as images, stylesheets, and script files. you have to opt in to this feature, and you do so by adding the static files middleware. This middleware configures the wwwroot folder to allow static files to be requested directly and serves them to the client.

Routing middleware is responsible for selecting which endpoint should be executed, based on information included in the request. Then authorization middleware is registered, which is responsible for determining if the current user is authorized to access the resource that is being requested.

Finally, the MapRazorPages method adds middleware to the pipeline that initially configures Razor Pages as endpoints. This middleware is also responsible thereafter for executing the request.

#### Configuration

##### Configuration in Razor Pages

ASP.NET Core includes an API for managing configuration settings needed by the application which includes a number of providers for retrieving data in a variety of different formats.

Configuration is set up as part of the WebHost.CreateDefaultBuilder method called in Program.cs, the entry point to the application. Various key/value stores are added to configuration by default:

- appsettings.json (and another version named after the current environment e.g. appsettings.Development.json)
- User Secrets (if the environment is Development)
- Environment variables
- Command line arguments

You can add other stores such as XML files, .ini files and so on if required. Configuration is added to the Dependency Injection system and is accessible throughout the application via an IConfiguration object.

###### AppSettings.json

The vast majority of applications are likely to only ever use an appsettings.json file for their configuration needs. Each configuration setting is stored in its own section. The default appsettings.json file includes a section that configures logging for the application:

```json
{
    "Logging":{
        "IncludeScopes": false,
        "Loglevel": {
            "Default": "Warning"
        }
    }
}
```

The next exmaple configures logging and a connection string to a SQLite database:

```json
{
    "ConnectionStrings":{
        "DefaultConnection":"Data Source=app.db"
    },
    "Logging":{
        "IncludeScopes":false,
        "Loglevel":{
            "Default":"Warning"
        }
    }
}
```

###### Working with Custom Settings

Custom settings provide the easiest way to extend the application configuration. The use of JSON as a storage format enables you to store complex information easily.

You can provide any name you like to custom sections of the appsettings.json file. In the example below, some values are stored in a section which has been creatively named AppSettings:

```json
"AppSettings":{
    "First":"value 1",
    "Second":"value 2",
    "Car":{
        "NumberOfDoors":5,
        "RegistrationDate":"2017-01-01T00:00:00.000Z",
        "Color":"Black"
    }
}
```

###### Accessing Configuration Settings Programmatically

The IConfiguration object enables you to access configuration settings in a variety of ways once it has been injected into your PageModel's constructor. You need to add a using directive for Microsoft.Extensions.Configuration to the PageModel class file.The first example illustrates how to reference a value using a string-based approach. The section is specified and subsequent properties are referenced by separating them with colons(:)

```csharp
private readonly IConfiguration _configuration;

public IndexModel(IConfiguration configuration)
{
    _configuration = configuration;
}

public void OnGet()
{
    ViewData["config"] = _configuration["AppSettings:First"];
}
```

This approach, as with all APIs that rely on strings is error-prone. You are a typing mistake away from a NullReferenceException at runtime.

###### Connection Strings

The Configuration class includes a convenience method for retrieving connection strings: GetConnectionString. You pass it the name of the connection that you want to retrieve:

```csharp
var connString = Configuration.GetConnectionStrings("DefaultConnection");
```

###### Strongly Typed AppSettings

A more robust approach can be achieved by using the Configuration system's built-in capability to bind settings to a C# object. The following code is a C# representation of the object represented in the JSON above:

```csharp
public class AppSettings
{
    public string First {get;set;}
    public string Second { get;set;}
    public Car Car {get;set;}
}

public class Car
{
    public int NumberOfDoors {get;set;}
    public DateTime  RegistrationDate { get;set;}
    public string Color {get;set;}
}
```

And this is how you can use the IConfiguration.GetSection method to bind the content of appsettings.json to and instance of AppSettings:

```csharp
private readonly IConfiguration _configuration;
public IndexModel(IConfiguration configuration)
{
    _configuration = configuration;
}

public void OnGet()
{
    var Settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
    ViewData["RegistrationDate"] = settings.Car.RegistrationDate;
}
```

###### Using The Options Pattern

The Options pattern works in a similar way to the previous approach in that it enables working with strongly typed configuration values and relies on the Configuration system's built-in capability to bind settings to C# objects. The Options pattern is intended to be used to group related configuration values together in individual classes.

The following example shows a simple appsettings.json file：

```csharp
{
    "Logging":{
        "LogLevel":{
            "Default":"Warning"
        }
    },
    "AllowedHosts":"*",
    "Title":"My Great Site",
    "Author":{
        "FirstName":"Mike",
        "LastName":"Brind"
    },
    "EmailFrom":"comments@mygreatesite.com",
    "EmaildisplayName":"Site Comments",
    "EmailSmtp":"localhost"
}
```

One set of related configuration settings are the Title and the Author. These are represented in the MetaOptions class (along with the definition of the Author class):

```csharp
public class MetaOptions
{
    public string Title{get;set;}
    public Author Author{get;set;}
}

public class Author
{
    public string FirstName{get;set;}
    public string LastName{get;set;}
}
```

The second group of related configuration values concern email settings for the site and are represented by the EmailOptions class:

```csharp
public class EmailOptions
{
    public string EmailFrom {get;set;}
    public string EmailDisplayName {get;set;}
    public string EmailSmtp{get;set;}
}
```
The following lines of code are all that is needed to bind values from appsettings.json to both of the configuration classes and to make them available as a service:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.Configure<MetaOptions>(Configuration);
    services.Configure<EmailOptions>(Configuration);
}
```

Now the configuration can be injected into PageModel constructors using the IOptions<TOptions> interface.You will need to add a using directive for Microsoft.Extensions.Options at the top of the PageModel class file:

```csharp
using Microsoft.Extensions.Options;

public class IndexModel:PageModel
{
    private readonly MetaOptions _options;

    public IndexModel(IOptions<MetaOptions> options)
    {
        _options = options.Value;
    }

    public string Title {get;set;}
    public Author Author {get;set;}

    public void OnGet()
    {
        Title = _options.Title;
        Author = _options.Author;
    }
}
```

Note that the value property of IOptions<TOptions> is accessed in the constructor to get at the actual configuration values.

Alternatively, if for example you wanted to use the configuration values in a layout file, you can use the @inject directive:

```csharp
@inject Microsoft.Extensions.Options.IOptions<MetaOptions> metaOptions
@{
    var options = metaOptions.Value;
}

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
      <meta name="author" content="@options.Author.FirstName @options.Author.LastName"/>
    <title>@options.Title</title>
```

The resulting HTML renders as follows:

```html
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <meta name="author" content="Mike Brind"/>
        <title>My Great Site</title>
```
###### Global Error Handing And Logging In Razor Pages

Exceptions in .NET represent an error condition in an executing program. Error conditions can come about as a result of a large number of causes, each represented by its own exeception type. Most execptions arise from logical errors in code, such as an attempt to work with an object that has not been instantiated(NullReferenceException), or to divide by zero(DivideByZeroException). Other types of exceptions result from technical issues, which may or may not be temporary. Other types of exceptions result from technical issues, which may or may not be temporary. Examples of such issues might include a database or mail server being unavailable, or insufficient file system permissions.

The recommendation is that you should try to minimise the impact of exceptions(otherwise known as handling them) by coding defensively rather than allowing them to crash your application.Options include wrapping code that might raise exceptions in try-catch blocks, and validating user input instead of assuming that it conforms to expectations.Despite your best efforts, however, chances are that even in a moderarately complex application, there will be something that you overlooked that will go wrong.

###### Default Exception Handling

The standard project template for a Razor Page site includes code that configures global exception handling middleware which is responsible for capturing any unhandled exception and dealing with it:

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if(env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
    }
}
```

This strategy offers three benefits:

1. It provides one  central place to configure exception handling.
2. It reduces the amount of try-catch blocks that you need to sprinkle throughout the application.
3. It enables you to handle exceptions in a different way, depending on the environment.

When you are running the site in development, the application is configured to use the Developer Exception Page, which is designed  to output as much detail about the exception as possible to make it easier to diagnose the root cause:

![异常](assets/5.png)

The middleware captures unhandled exceptions within the processing pipeline and ensures that the correct HTTP status code is returned along with the HTML output above.

This information is very usefull during the development phase of a web site, but it should not be displayed once the site has gone live. Apart from the fact that it is pretty unfriendly from a user's point of view, the details revealed here might prove helpful to someone whose intentions are not honourable.

So the default site is configured to use ExceptionHandlerMiddleware in all other environments. This is registered in Startup by the UseExceptionHandler method, which takes the relative path to a page that should be executed in the event that an unhandled exception occurs while the application is running:

![自定义异常](assets/6.png)

This page (Error.cshtml) forms part of the standard template and is fully customisable.

###### Logging Error Details

Now that the applicaiton reacts appropriately when an exception occurs, you need to be able to review the details of any exception so that you can implement strategies to prevent it happening in future, or to handle it more gracefully where possible. So you need to be able to log as much information about the exception as possible.

Logging is included as part of the ASP.NET Core framework with a number of built-in logging providers. The simplest way to collect and store logs is in a file, but, none of the built-in providers enable this (at the moment). Therefore you will need to rely on a third party logging componment. There are several good, free and open source ones that work with .NET Core，With NLog probably being one of the best known.

###### Installing and Configuring NLog

NLog is available as a Nuget package and can be installed via the Package Manager Console in Visual Studio using the following commands:

```shell
install-package NLog
install-package NLog.Web.AspNetCore
```

Alternatively, if you are using Visual Studio Code, you can use the `dotnet` CLI to install the required packages:

```shell
dotnet add package NLog
dotnet add Package NLog.Web.AspNetCore
```
Once installed, you need to configure options for NLog. You can do this in two ways: you can provide configuration in an xml-based file, or you can use the configuration API to set the configuration programmatically.

###### Using A Config File

First, create a file named nlog.config in the root folder of your application. Then add the following to it:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      autoReload="true">
  <extensions>
    <add assembly="NLog.Web.AspNetCore"/>
  </extensions>
  <targets>
    <target xsi:type="File" name="myLogFile" fileName="c:\logs\mylog-${shortdate}.log"
            layout="${longdate}|${event-properties:item=EventId_Id}|${uppercase:${level}}|${logger}|${message} ${exception:format=tostring}" />
  </targets>
  <rules>
    <logger name="*" minlevel="Warn" writeTo="myLogFile" />
  </rules>
</nlog>
```

NLog works with targets and rules. A target is the destination for logging output. NLog supports a huge number of targets, but the one that we are using is File. The file name and the layout of the log are specified using templates composed from layout renderers.

Rule affect loggers. The simple one added above specifies that all loggers in the application should write to the target named myLogFile, but only if the log level is WARN or above. Log levels are (in ascending order of severity):

- TRACE
- DEBUG
- INFO
- WARN
- ERROR
- FATAL

Finally, the logging configuration is registered in the Main method, and logging is configured as part of the CreateWebHostBuilder method call:

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace  ErrorHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)=>{
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureLogging(logging=>{
                logging.ClearProviders();
                logging.SetMinimumlevel(Microsoft.Extensions.Logging.LogLevel.Trace);
            })
            .UseNLog();   
        }
    }
}
```

If you prefer to use the configuration API, the equivalent configuration is created using the following code within  the Main method:

```csharp
public static void Main(string[] args)
{
    var config = new LoggingConfiguration();

    //targets

    var fileTarget = new FileTarget("fileTarget")
    {
        FileName = @"c:\logs\mylog-${shortdate}.log",
        Layout = "${longdate}|${event-properties:item=EventId_Id}|${uppercase:${level}}|${logger}|${message} ${exception:format=tostring}"
    };

    config.AddTarget(fileTarget);

    //rules
    config.AddRuleForOneLevel(NLog.LogLevel.Warn, fileTarget);
    config.AddRuleForOneLevel(NLog.LogLevel.Error, fileTarget);
    config.AddRuleForOneLevel(NLog.LogLevel.Fatal, fileTarget);
    LogManager.Configuration = config;
    CreateWebHostBuilder(args).Build().Run();
}
```

Now when you encounter an exception, details will be written to the specified log file. The file name template includes the ${shortdate} renderer, which ensures that a new log file will be created each day.

![NLog](assets/7.png)

##### Configuring a custom error page

When a visitor tries to request a page on your site that doesn't exist, or an unhandled exception occurs while executing server-side code the web server returns an HTTP status code to the browser indicating that an error occurred. As a site developer, you have two choices when this happens: you can either let the browser show its default notification page;


![error page](assets/8.png)

or you can take control and choose to display your own message.

##### Status Code Pages Middleware

The ASP.NET team have included middleware for managing HTTP errors in the 400 and 500 ranges. It is called StatusCodePagesMiddleware, and is found in the Microsoft.AspNetCore.Diagnostics package.

There are a number of extension methods for registering StatusCodePagesMiddleware as part of the pipeline in the Configure method of the Startup class. The most basic usage is as follows;

```csharp
app.UseStatusCodePages();
```

When an error occurs within the specified range, this usage results in a plain text response with a default message;

![404](assets/9.png)

![raw](assets/10.png)


Overloads of the UseStatusCodePages method are available to provide some more control over how your application responds to errors, including one that enables you to set the content type and body of the response;

```csharp
app.UseStatusCodePages("text/html","<h1>Error! Status code {0}</h1>");
```

![404](assets/11.png)

However, there are a couple of other extension methods that simplify things a lot more. These are UseStatusCodePagesWithRedirects and UseStatusCodePagesWithReExecute. Both of these make use of a page that you create to generate the response, so you have full control over its content. The following example is a simple Razor page designed to let the visitor know that the page they requested does not exist:

```csharp
@page
@{
    ViewData["Title"] = "No such page";
}

<h1> 404 Not found</h1>
<p> No such page exists at this location.</p>
```

This code is in a file named 404.cshtml and is placed in a folder within the Pages folder named Errors.

The UseStatusCodePagesWithRedirects method takes a string representing the location of the custom error page, which can also include a placeholder {0} which will be filled by the status code:

```csharp
app.UseStatusCodePagesWithRedirects("/errors/{0}");
```
When an error occurs, the user is redirected to the specified location, in this case - once the placeholder is populated by the middleware- /errors/404.

The UseStatusCodePagesWithReExecute method re-executes the request pipeline using an alternate path (page), and also takes a string with a placeholder:

```csharp
app.UseStatusCodePagesWithReExecute("/errors/{0}");
```

##### To Redirect or Re-execute?

From a user's point of view, it makes little difference which method you use. Both will result in the page that you specify being displayed. The only visible difference will be the URL displayed in the browser. The WithRedirects method results in a different URL appearing in the browser address bar than the one that was requested.

This is the Network output in Chrome for a request to a nonexistent page;

![redirect](assets/12.png)

The initial request to /nonexistent-page resulted in a 302 status code and a location header with the value /errors/404, causing the browser to issue a new request. This request was successful, signified by the 200 status code. Now the browser features the address of the error page instead of the one that was initially requested:

![NotFound](assets/13.png)

With the WithReExecute option, the original HTTP status code is preserved as is the URL in the browser address bar.

![NotFound](assets/14.png)

but the response comes from the alternative location that  you specify:

![nonexistent-page](assets/15.png)

The WithReExecute option wins based on the fact that the visitor can check the browser address bar to see if there are any obvious mistakes in the URL that they provided or followed.

##### SEO Considerations

The WithReExecute option really wins if Search Engine Optimisation is immportant to you. The best way to let a search engine know that the incorrent URL it is trying to index does not exist is to respond with a 404 Not Found status code. If you provide a 302 Found followed by a index, potentially serving it up within a search result.

##### Configuring your Razor Pages site to run under HTTPS

Running a site under HTTPS used to be something that only big online merchants worried about. Google are leading a push to have all web sites operate in a secure manner and now include HTTPS encryption as a ranking signal.

Once you have configured your web server to serve your site over HTTPS successfully, you need to ensure that your visitors can only access the site securely. ASP.NET Core provides a couple of ways to achieve this.

##### The RequireHttpsAttribute

The RequireHttps attribute is an authorization filter whose role is to confirm that requests are received over HTTPS. If the request was not make over HTTPS, the client will be redirected to the HTTPS version of the request URI if the GET method was used. Non-HTTPS requests made using any other verb(e.g. POST) will receive a 403 Forbidden result.

The attribute can be applied to a PageModel class:

```csharp
[RequestHttps]
public class IndexＭodel:PageModel
{
    //.....
}
```

However, this approach is not recommended unless all traffic is redirected to single Razor Page(as happens to be the case with this site). It is too easy to forget to apply the attribute to new pages added to the site in the future. A slightly less risky approach would be to apply the attribute to a class that implements PageModel, and then have all other PageModel classes inherit from that:

```csharp
[RequireHttps]
public class BasePageModel: PageMOdel
{
    //...
}

public class IndexModel : PageModel
{
    //...
}
```

You can then write a unit test to ensure that all the PageModel classes in the application inherit from  BasePageModel. But it is still possible to add Razor Pages that don't have an associated PageModel.The recommended approach to using the RequireHttps attribute is to apply it as global filter in the ConfigureServices method:

```csharp
services.Configure<MvcOptions>(options=>{
    options.Filters.Add(new RequireHttpsAttribute());
});
```

This configuration results in the browser (or other user agent) being issued with a 302 (Found) status code, which indicates that the item has been moved temporarily to a different URL to the one originally used in the request. If the move from the HTTP version to the HTTPS version is permanent (which is most often the case), you should set the Permanent property of the RequireHttpsAttribute to true:

```csharp
services.Configure<MvcOptions>(options=>{
    options.Filters.Add(new RequireHttpsAttribute(Permanent=true));
});
```

Now the application will return a 301 Permanently Moved result, which should ensure that search engines update their indexes to point to the HTTPS version of the resource.

##### URL Rewriting

An alternative to the RequireHttpsAttribute is to use URL Rewriting. This is made available to the application as part the standard configuration. You activate Rewriting within the Configure method:

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if(env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        var options = new RewriteOptions().AddRedirectToHttps();
        app.UseRewriter(options);
    }

    app.UseStaticFiles();
    app.UseMvc();
}
```

This example shows Rewriting being added to the pipeline conditionally - only when the environment is not Development. This allows you to develop the application using standard HTTP, and makes use of the Rewrite options more flexble than the RequireHttps filter.

Just as with the RequireHttps filter, the Rewrite approach also provides an option to issue 301 Moved Permanently status codes instead of 302:

```csharp
var options = new RewriteOptions().AddRedirectToHttpsPermanent();
app.UseRewriter(options);
```

You can chain this with other extension methods. The AddRedirectToWwwPermanent() method is another that is provided by the framework:

```csharp
var options = new RewriteOptions().AddRedirectToHttpsPermanent().AddRedirectToWwwPermanent();
app.UseRewriter(options);
```

Now the application will redirect non-www traffic to wwww, and ensure that it is served under HTTPS.



#### Middleware

##### Middleware in Razor Pages 

###### The Request Pipeline

When requests are make to a web application, they need to be processed in some way. A number of considerations need to be taken into account. Where should the request be directed or routed to? Should details of the request be logged? Should the application simply return the content of a file? Should it compress the response? What should happen if an exception is encountered while the request is being processed? Is the person making the request actually allowed to access the resource they have requested? How should cookies or other request-related data be handled?

Each of these processing actions are performed by separate components.The term used to describe these components is Middleware.Together, they form the request pipeline.

###### Middleware in ASP.NET Core

In previous versions of ASP.NET, the components that affect the request pipeline (HttpModules and HttpHandlers) were all bundled into one library, System.Web.dll, along with everything else you might or might not need to make your web application run.

In ASP.NET Core, you can choose which middleware to register in Program.cs or the Configure method of the Startup class for older versions of ASP.NET Core.The standard template includes the following code:

```csharp
var app = builder.Build();
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
```

Various components are registered including error handling middleware, middleware for processing requests for static files (images, style sheets, script file, PDFs etc), authentication management middleware (if you enable authentication when creating your project), and the MVC framework. Each component is registered using an extension method on the IApplicationBuilder type.

The order in which the components are registered determines the order in which they are executed. Error handling middleware is registered first so that it is available to all code further along the pipeline where exceptions may be raised.

Middleware can either terminate the pipeline execution and return a response or it can pass control on to the next component. The Static File middleware terminates execution of the pipeline and sends the content of the requested static file in the response. Routing, Authentication and EndPoint Middleware are not invoked when static files are requested. Other components pass execution on to the next registered component.

###### Creating Middleware

Middleware is implemented as a RequestDelegate, a delegate that takes an HttpContext as a parameter and returns a Task:

```csharp
public delegate Task RequestDelegate(HttpContext context);
```

Here are two examples of middleware. The first is defined as an inline lambda and simply returns a response. It is passed as a parameter to the IApplicationBuilder.Run() method in Program.cs (the Startup's Configure method in earlier versions):

```csharp
app.Run(async (context)=>{
    await context.Response.WriteAsync("All done");
});
```

This example terminates the pipeline. No other middleware components are executed. The Run method is used specifically for registering middleware that behaves like this.

The next example terminates the response only when a particular query string value is present. Otherwise is passes control on to the next middleware in the pipeline, represented by the next parameter

```csharp
app.Use(async (context, next)=>
{
    if(context.Request.Query.ContainsKey("stop"))
    {
        await context.Response.WriteAsync("All done");
    }
    await next();
});
```

Middleware that passes control on to the next middleware is registered with the IApplicationBuilder Use method.

Middleware Classes

The recommended pattern for creating middleware is to create a separate class for it, and then to create an extension method on the IApplicationBuilder type to register it. There are two ways to author middleware classes. You can use the convention-based approach or you can implement IMiddleware.

######  Convention-based Middleware

The following code shows a middleware class built on conventions. The is the appraoch you are most likely to see because it was the only way to write middleware classes before ASP.NET Core 2.0, and most of the framework middleware is written like this.

ElapsedTimeMiddleware.cs

```csharp
public class ElapsedTimeMiddleware
{
    public ElapsedTimeMiddleware(RequestDelegate next)=>_next = next;
    public async Task Invoke(HttpContext context, ILogger<ElapsedTimeMiddleware> logger)
    {
        var sw = new Stopwatch();
        sw.Start();
        await _next(context);
        var isHtml = context.Response.ContentType?.ToLower().Contains("text/html");
        if(context.Response.StatusCode == 200 && isHtml.GetValueOrDefault())
        {
            logger.LogInforamtion($"{context.Request.Path} executed in {sw.ElapsedMilliseconds}ms");
        }
    }
}
```

This middleware measures the time taken to process a request and then logs that information.

The class takes




#### Dependency Injection
#### Working With Forms
#### Validation
#### Model Binding
#### State Management
#### Cache
#### Managing Security With ASP.NET Identity
#### Using Ajax
#### Working with json
#### Scaffolding
#### Publishing To IIS
#### Advanced