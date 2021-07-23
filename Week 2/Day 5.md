> **MOQ framework**
> Automates writing mock objects
> (For next week)

### Asynchronous Programming
* Multithreading - Caller and callee functions on different threads.

* Problems to solve
  * How to get the return value from async-op
  * How to know if the async-op has completed
  * How to cancel the async-op
  * Catch async-op exceptions in the caller thread

* Two types of *Chaining*
  * Pipelining Async tasks (Chaining)
  * Parent-Children relationship amoung the tasks
    * Cancelling parent must cancel children
    * Parent will complete when all tasks are completed.

### Threading in C#
* `System.Threading.Thread thrObj = new System.Threading.Thread(Function taking no argument and returning void)`
* `System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Function taking one object argument))`
* **TPL** - *Task Parallel Library*
  * Wrapper around `ThreadPool`
  * `System.Threading.Task`
  * Function can be of types
    * No arg, void return
    * object argument, void return
    * No argument, typed return (using generics)
    * object argument, typed return (using generics)

### `async` and `await`
