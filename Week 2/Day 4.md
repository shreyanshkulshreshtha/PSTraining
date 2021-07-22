# Test Driven Development - TDD

### POUT Workflow
* Write source code, then write the tests for it.

### Problem with "Debug Later Programming"
* Bug fixing takes little time, bug finding takes much more time.
* As time between the mistake made (bug injection) and bug discovery increases, time spent to find the bug increases dramatically.
* Development and Testing should be done parallely.

### Test Driven Development
* Programming practice
* Unit tests are written before the domain code.
* Steps for TDD
  * Write test that fails to compile (Due to lack of any code).
  * Write a bare bones stub to make the test compile.
  * Run the test to fail. (If it doesn't then the test is not very good).
  * Implement the code.
  * Run the tests to pass.
  * Refactor further if fails.

### Rules of TDD
* No production code to be written until atleast once the test fails.
* Write only tests sufficient to fail.
* Write only code sufficient to pass.

### Benefits of TDD
* Quality code ensured from the start. (No dead code etc)
* Generally TDD automatically enables one to write code using principles.
* Encourages creation of simpler, more focused libraries.
* High degree of fidelity between business requirement and code.

> Mock and Stub

### When NOT to use TDD
* When requirements are volatile and fuzzy.
* When some parts of project are simple, samll or less complex.