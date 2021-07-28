### Feature Engineering
* Bird view of the problem.
* Given a [document of requirement](https://github.com/venu-shastri/sapient-dotnet-core-knowledge-repo/blob/main/FeatureMesh_Functional_requirement.docx), we need to read it, get an understanding of the requirements and think about the architecture to be used.
* Another [document](https://github.com/venu-shastri/sapient-dotnet-core-knowledge-repo/blob/main/AsiaPac%20Business%20domain%20problem.docx) given, read this as well and try to figure out the architecture required.
* Things to explore
  * C4 model
  * 4+1 view model
* Create a subtask on "Architecture Incubation"

### Build CSV ActionResult
Create a custom ActionResult to provide csv response from a class.

---

### DB Interaction
* Database - Storage or Persistance Layer
* Transition in Data verticals
  * Persist : File -> DB
  * Process : Logic -> Data Science
  * Present : Desktop App -> Web/Mobile

### NoSQL
(Pronounced as *Not only CQL*)
* RDBMS only stored *structured* data.
* NoSQL provides
  * Volume (Data at rest).
  * Velocity (Data in motion).
  * Variety (Data in many forms - structured, unstructured, text, multimedia)
  * Veracity (Data in doubt - data inconsistency, ambiguity)
  * Horizontal and Vertical scaling

Types of NoSQL
* Key Value Store
* Tabular
* Document
* Graph

CAP Theorem - 3 basic requirements for designing applications for a distributed architecture.
* Consistency
* Availability
* Partition Tolerance
Practically, it is impossible to fulfil all 3 requirements, we have to choose only 2.

Using distributed systems, we lose the ACID properties.

### ORM - Object-Relational Mapping
* *Serialize* object into database table/document
* *Materialize* table into object
* ORM is a framework which aids serializes and materializes.
* *Entity Framework* in .NET for ORM. 