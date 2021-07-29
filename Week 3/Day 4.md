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

### Tasks
* Custom Middleware - 
  * `CardNumber.sapient` is given, respond back with the respective file contents.
  * The file contains the card number, name, limit in its own format.
  * Response format should be "cardnumber | name | limit"
* Exception Handling -
  * Handle exceptions and also provide the information what went wrong.