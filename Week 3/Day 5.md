### MongoDB
* Using `MongoDB-Compass` GUI.
```
+------------+------------+
|   MySQL    |  MongoDB   |
+------------+------------+
| Database   | Database   |
| Table      | Document   |
...
```

* `BJSON` - Binary JSON; Used by MongoDB to store data.


### Assignment
API Refactoring For Maintainability And Testability
* Given a [source code](https://github.com/venu-shastri/sapient-dotnet-core-knowledge-repo/tree/main/CalulcatorApiLib/NoSqlConnectivityDemo), refactor it to make it more maintainable and testable.
* Basically remove all the hard coded components (connection string etc) and make use of dependency injection so that one can use the same code to write either to SQLite or MongoDB depending on the dependency injected.
