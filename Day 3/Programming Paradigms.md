# Programming Paradigms

## Encapsulation in C#

### Learnings
* Encapsulation
  * Class - ReferenceType
  * Struct - ValueType
  * Enum - ValueType
  * Interface
  * Tupule
  * Record

> ValueType -> ReferenceType -- Boxing
> 
> ReferenceType -> ValueType -- Unboxing

* Class can contain
  * Fields
  * Methods
  * Constructor
  * Nested Types (Classes, Enums, Interface)
  * Properties
  * Indexers
  * Events

* Class Diagram
  * + : Public
  * - : Private
  * # : Protected

| ClassName |
| --------- |
| Fields    |
| --------- |
| Methods   |

## Beyond Encapsulation - Inheritence

## Learninga
```
                              +---+  +---+
+----------+                  |   |  |   |
| Big ball |       SRP        +---+  +---+
|  of Mud  |  ------------>
|  (God)   |   Distribute     +---+  +---+
+----------+                  |   |  |   |
                              +---+  +---+
```

* Relationship - Reusability
  * **Complete code reuse** - *is a*/*assumes* relationship
    * Class Inheritence
  * **Object Reuse** - *uses*/*has a* relationship
    * Composition
    * Association
    * Aggregation

* Inheritence is a static/compile-time relationship
  * Only one way
  * Ripple Effect - Parent is changed, child gets affected.
  * Public interface should be the same for the parent and child classes.
  * Unwanted members from the parent class make the child class *fat*.
  * Eg. `List` and `Stack` classes - `Stack` *can* be implemented by inheriting from the `List` object, but since the interface of both the classes is different, and also methods like `add()`, `insertAt()`, `remove()` are not used in the `Stack` class, so it makes the `Stack` *fat*.
* Object resue - create an object of the "desired parent" class in the new class.
  * Use when interface of the new class and the "desired parent" class is different.
  * Use delegation - call the methods on the object created to get the information.
  * Eg. `Stack` can be implemented by having a `List` object inside to store the actual data but have a different interface.

* Composition
  * *has a*
  * Lifetime //Needs explanation
* Aggregation
  * *holds*
  * Different lifetime //Needs explanation
* Association
  * *belongs to*

* Abstract class - Class with a protected constructor
  * Parent class with a non-concrete (incomplete) common code for the derived classes.
  * Cannot be instantiated.
  * Can contain abstract methods (Without the implementation) - Needs `override` keyword in the derived class implementation.
