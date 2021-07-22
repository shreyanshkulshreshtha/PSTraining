# Unit Testing

### POUT - Plain Old Unit Testing

* Units of code required - SRP principle.
* Purpose of Unit Testing - To check if the code is going to work as expected.
* Helps find bugs in the early stages.
* Unit Test -> Integration Test -> System Test
* *Cyclomatic complexity* - Number of paths a function can take while execution (due to branching etc.).
* Testing has to be done for all the cyclomatic paths possible in the program.
* Complexity of testing increases with increase in Cyclomatic Complexity. 
* Hence separate the code.

* Complexity of Unit Testing depends on
  * Cyclomatic Complexity
  * Dependencies

* Things needed to test the code
  * Infrastructure
    * Testing framework
    * Test runner

* Types of unit testing
  * Value based test - Assert on the *actual value* returned from the function of the *code under test*.
  * State based test - Assert on the state of an object, because the functions don't return anything, they just alter the state.
  * Behavioural test/Interaction testing

* If using Functional paradigm, try separate impure parts from the pure functions.
* Test code is just a function which checks it the values are as expected.
* *Actual Value* - The value we obtain from our code.
* *Expected Value*
* *Code under test*
* Assertion on the actual value