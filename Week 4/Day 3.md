# Web Applications - Front End

## Layered Architecture
* Separation provides Abstraction.
* Layered architecture is also called *horizontal partitioning*.
* Layers are logical entities to draw boundaries between functionalities.
* Each layer can be implemented using different components.
* Or else all layers can be implemented inside a single component - *Monolithic*

### Layers in Web Application
* In a broad view, the layers are
  * UI Layer
  * BL
  * DAL
  * Database
* UI Layer
  * Rich UI
  * Reachable UI
  * ? `//Find it`
  * Headless UI (Architecture) `//Look into it`
```
    Rich        Reachable
     UI            UI
      \____    ____/
          |    |
          V    V
            BL
            |
            V
           DAL
```

### Rich UI
* Desktop UI (OS and Architecture dependent)
* Can access resources of OS directly
  * System libraries
  * Shell, etc.
* Is not portable.

### Reachable UI
* All components -- Content, Presentation and Logic -- are reachable over the network.
* OS and architecture independent.
* Reachability is achieved by publishing to the web using *Web Server*.

## Web Server
* Server is a program 
  * Continuously running
  * Accept request
    * Network address
    * Protocol
* A web-server uses HTTP protocol.
* Web server publishes web resourses on the internet.

## Web Resourses

### Content
* Can be *static* or *dynamic*.
* Static is using HTML web pages.
* Dynamic content (or webpages) use user actions to change the content.
  * Event-driven
  * Content + Logic

### Logic
* Logic can be executed in the *Web Client* or on the *Web Server*.
  * Server side logic can be written in different languages - C#, Java, PHP, JS, etc.
    * Server side dynamic pages can be simple HTML.
  * Client side logic is written in JS.
    * Client side dynamic pages need html as well as JS.

### Web Application
* Client centric
  * Content manipulation is done on client side .
* Server centric
  * Content preparation and manipulation done at server side.

> BFF (Backend for frontend) Architecture //Read about it.

### Client Centric WebApp
* A separate web server contains the client side files and logic which is served to the web client.
* Web client genertes the DOM tree and operated the client side logic.
* Front end makes AJAX requests to BFF, it serves the client with the data.
* Web client updates the DOM tree with the received data.

## Critical Rendering Path
The pipeline or steps the content has to pass through from being received by the web client to being presented to the user.

> CRP - <https://developers.google.com/web/fundamentals/performance/critical-rendering-path/>

If we directly update the DOM, the overall updation of the UI is slow.

To solve this, we use **React** which optimises the updation of DOM so that it is faster updation of the UI.

> React Prerequisites
> * JS
> * HTML
> * CSS
> * TypeScript
> * Node.JS

# JavaScript
* Scope
* Variable hoisting
* Prototypes
* IIFE (?)
* Closures
* Constructors
* Binding
* `this`

```
---
Missing part
---
```

* Everything is an object
* Dynamic language
  * Elastic nature

> <https://developer.mozilla.org/en-US/docs/Web/javascript>
  
### JS Functions
When we create a function using 
```
function test() {

}
```
it creates an object in the memory as a key-value pair table.
```
+-----------+---------+     +-----------+--------+       +------+------+
| prototype |   o---------> |           |        |       |      |      |
+-----------+---------+     +-----------+--------+       +------+------+
|           |         |     |           |        |       |      |      |
+-----------+---------+     +-----------+--------+       +------+------+
| __proto__ |         |     | __proto__ |   o----------> |      |      |
+-----------+---------+     +-----------+--------+       +------+------+
          test                  test.prototype           Object.prototype
                                                     (Common for all objects)
```

When function is **invoked**, it applies the function and the execution is *two pass execution*. `//Look it up`

In the first pass, it creates an object `localScope` in the memory with the arguments and local variables. It also adds a special member to the object called `this`. During the first pass, arguments are initialized. All other local variables are initialized as `undefined`.

In the second pass, the execution begins. It takes the required values from the `localScope` and after the operations, the values are also updated in the `localScope` object. The final value is returned from the object and this `localScope` object is garbage collected.