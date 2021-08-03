### Assignment
* Generate API documentation using Swagger.
* Generate client code for the API using Nswag (or Nswag Studio).
* Use this client code to write a console app for calculating EMI.

### API Documentation
* *OpenAPI* - A specification standard for api metadata.
* *Swagger* - A tool based on OpenAPI specs for multiple platforms.

### Tools
* SwashBuckle
* NSwag
* NSwagStudio

### Middlewares
> Info [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-5.0)

In `Configure` function in the `Startup.cs` file, 
* `app.Run()` is the *terminal middleware*.
* We can add custom middleware using `app.Use()`.
* `app.UseStaticFiles()` serves files from `wwwroot` directory if they exists in the directory.
* `app.Map()` to branch the middleware pipeline when the path in the request is same as the argument.

### Exception Handling in APIs
* `UseExceptionHandler()` can internally redirect to a given path when any exception occurs.
* We can also return `Problem()` which is an `ActionResult`.
*`IActionFilter` interface can be implmented to make a filter.
* `OnActionExecuting()` and `OnActionExecuted()` methods available.
* To add these filters, use `services.AddControllers(options => options.Filters.Ass (new Filters.FILTERNAME))` in the `Configure()` method.

### Assignment
* Custom Middleware - 
  * Credit card information for different people are stored in separate files named "CardNumber.sapient".
  * The file contents are in the following format - `CardNumber,Name,Limit`
  * When a user gives cardnumber.sapient in the URL, the corresponding file's content should be displayed in the given format - `cardnumber | name | limit`
* Exception Handling -
  * Write code to handle exceptions in the ASP.NET API created for fetching .sapient card numbers in the previous task.
  * We can use either custom middleware or filters to achieve this