# CGI test

Code a movie database site

Technologies used: ASP NET MVC, AngularJS 1.x (soovitavalt 1.5), Foundation 6 CSS Framework
Make it an SPA (Single Page Application). Data is be fetched from server API in JSON format and
Design the application incrementally. Start by creting read-only responsive views of movie list and

details and data API for read-only access.
bound to Angular templates.
Views are styled using Foundation6 - responsive CSS framework.

# SETTING UP PROJECT `in Visual Studio 2017`:

Download the project:
```
https://github.com/4rt/cgitest
```

Go to directory `cgitest`:
```
cd cgitest
```

Launch solution and run the project
```
MoviesApp.sln
```

Set API url (localhost where your solution runs) in `app.js` (cgitest/Movies/wwwroot/app/app.js)
```
{
    apiUrl: YourUrl
}
```

From `cgitest` directory move forward to `wwwroot`:

```
cd Movies/wwwroot
```

run in the command line:
```
npm install
```

run in the command line:
```
npm start
```

Open in browser  http://localhost:8000/

# SETTING UP PROJECT `in Visual Studio 2015`:

1.Download the .NET Core SDK
```
https://go.microsoft.com/fwlink/?linkid=843448
```

Download the project:
```
https://github.com/4rt/cgitest
```

Go to directory `cgitest`:
```
cd cgitest
```

run in the command line:
```
dotnet restore
```

run in the command line:
```
dotnet run
```

Set API url (localhost where your solution runs) in `app.js` (cgitest/Movies/wwwroot/app/app.js)
```
{
    apiUrl: YourUrl
}
```

From `cgitest` directory move forward to `wwwroot`:

```
cd Movies/wwwroot
```

run in the command line:
```
npm install
```

run in the command line:
```
npm start
```

Open in browser  http://localhost:8000/
