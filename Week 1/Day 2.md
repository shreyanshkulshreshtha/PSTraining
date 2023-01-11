# Programming Paradigms

## Object

### Activity

*Q. List Object Oriented Concepts*
* Encapsulation
* Abstraction
* Polymorphism
* Inheritance

*Q. Is there any specific Ordering of these concepts?*

There is no specific order. These features in theory are independent of each other, i.e. having one does not affect the availablility of others, although in implementation they might be tied to one other.

---

### Learnings
* Concepts of Object Oriented Paradigm.
  * Object
  * Inheritence
  * Abstraction
  * Polymorphism
  * Encapsulation
  * Independent of each other

* Object 
  * Occupies **Space**
  * **Identity**
  * Have a **State**
  * Performs some actions or **Behaviours**
  * Appears as **Interface**
  * **Observable**
  * Forms **Relationships** with others to reuse functionality of others. Should not do everything on its own.

* Object Design - **Encapsulation** 
  - Define roles and assign responsibilities. Avoid "God object" -- an object which does everything.

 | Concept       | Principle | Modelling           | Implementation      |
 | ------------- | --------- | ------------------- | ------------------- |
 | Encapsulation | SRP       | Class Diagram (UML) | Language Constructs |

### Activity
*Q. Design objects to be used in a program which converts a given CSV file into an XML file. The CSV file contains bank transaction records. The formats of CSV and XML files are given below*
```
# CSV File
source, recipient, amount, date, time, currency
```
```xml
# XML File
<transaction>
  <source> ## </source>
  <recipient> ## </recipient>
  <amount> ## </amount>
  <date> ## </date>
  <time> ## </time>
  <currency> ## </currency>
</transaction>
```

Objetcs required -
  - To store the data
    - source, recipient, amount, date, time, currency, transaction.
  - To read the CSV file separated by lines into text.
  - To separate values on comma, count if there are 6 values and create data objects. (Separate responsibilities)
  - To handle errors.
  - To write one transaction into text.
  - To write text in the XML file and also count number of records. (Separate count and write)
  - To print on the console.
