# Design Patterns

## Observer Pattern

* `Subject` has a *state*.
* `Observer` *subscribes* to the subject.
* `Observer`s are notified whenever there is a mutation in the subject state.
* This is *event-driven programming*.
* Subscribing and Unsubscribing are called *Event Hooks*.

## Composition Pattern

* Also called **MultiCast** or **Multiplex**
* Can substitute one object with a composite of many objects without changeing the behaviour inside the caller/controller.