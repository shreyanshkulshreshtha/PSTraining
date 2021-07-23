> **MOQ framework**
> Automates writing mock objects
> (For next week)

### Asynchronous Programming
* Multithreading - Caller and callee functions on different threads.

### Threading in C#
* `System.Threading.Thread thrObj = new System.Threading.Thread(Function taking no argument and returning void)`
* `System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Function taking one object argument))`

* Problems to solve
  * How to get the return value from async-op
  * How to know if the async-op has completed
  * How to cancel the async-op
  * Catch async-op exceptions in the caller thread
  * 