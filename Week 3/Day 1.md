### Assignment
* Credit card validator (using TDD)
* Checks on credit card number
  * *Luhn Algorithm* for checksum
  * Major Industry Identifier (MII)
  * Issuer Identification Number
  * Personal Account Number
* For our purpose, we'll go with only Master and Visa cards

* Input 
  - Card number
* Output 
  - Is valid?
  - MII
  - Issuing Authority
  - Personal Account Number

References
* [https://www.zeolearn.com/magazine/logic-of-credit-card-number](https://www.zeolearn.com/magazine/logic-of-credit-card-number)
* [https://www.validcreditcardnumber.com/](https://www.validcreditcardnumber.com/)
* [https://www.getcreditcardnumbers.com/](https://www.getcreditcardnumbers.com/)
* [https://www.dcode.fr/luhn-algorithm](https://www.dcode.fr/luhn-algorithm)

### WebAPI using ASP .NET Core
> Client centric vs Server centric websites
> 
> Content creation done at client side vs at server side.

* Service Oriented Architechture (SOA) - to make our program logic *reachable* (usable by any platform, any architechture).
* Communication is neutralised by setting some standards for all.
* Provides platform independent *RPC* (Remote procedural call), known as *Messaging Architechture* in SOA.
* Two verticals
  * SOAP based.
  * REST based (Primary focus).
* *Publish* a *business logic* to be reacable by everyone.

* Important components of SOA -
  * Message
  * Transport (To transfer the messages)
  * Representation of Payload (arguments and results).

### REST Style
* Transport protocol - HTTP
* Communication protocol (Message structure) - HTTP
  * Arguments - Either using query string, URL segment or http-body.
  * Operation identity (Which method to be called) - URL + http verb
  * Exceptions - HTTP status codes

### ASP .NET WebCore
```
            +-----------+    +--+ +--+ +--+      +-------+
  HTTP      |   Web     | -> |  | |  | |  | ---> |  API  |
----------> |  Server   |    |  | |  | |  |      | Logic |
  Request   | (Program) | <- |  | |  | |  | <--- |       |
            +-----------+    +--+ +--+ +--+      +-------+
                              Middlewares     
            \____________________________________________/
                                   |
                                   V
                               Application
```

* HostBuilder
* Expression Bodied Methods in C#
* MVC architechture - Model-View-Controller
```
                Data
                 Λ|
                 |V
Request--->  Controller
             /   |    \  Inject
            /    |     \  Data
          View  View  View
```
* Routing middleware - Uses pattern matching to select the route.
* Routing middleware contains routing table which has
  * Route
    * Name
    * Template (Pattern)

### Defining Routes
* Two types of routing
  * Conventional Route (MVC)
  * Attributed Routing (Web API)