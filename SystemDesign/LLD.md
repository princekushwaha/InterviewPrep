# Low-Level Design (LLD) – Object-Oriented Notes

This document is a **consolidated README-style guide** covering everything we have learned so far in Low-Level Design (LLD), with an **interview-focused and practical approach**.

---

## 1. What is Low-Level Design (LLD)?

Low-Level Design focuses on **how a system is implemented at code level**.

LLD answers questions like:

* What classes will exist?
* What are their responsibilities?
* How do objects interact?
* How do we make the design extensible and maintainable?

LLD is about **classes, objects, methods, interfaces, relationships, and patterns**.

---

## 2. Object-Oriented Thinking

### Core Idea

> Model real-world entities as objects that **own data and behavior together**.

* Class → blueprint
* Object → runtime instance

Key rule:

> Behavior should live with the data it operates on.

---

## 3. Object Relationships

### 3.1 Association

* Meaning: **Uses / interacts with**
* No ownership
* No lifecycle dependency

Example:

* Service → Repository
* Teacher → Student

Rule:

> If an object just *uses* another object → Association

---

### 3.2 Aggregation (Weak HAS-A)

* Parent holds reference
* Child exists independently
* Lifecycle managed externally

Example:

* Team → Player
* Department → Employee

Rule:

> Parent groups objects but does not control lifecycle

---

### 3.3 Composition (Strong HAS-A)

* Parent owns child
* Parent controls lifecycle
* Replacement is allowed

Example:

* Order → OrderItem
* Car → Engine

Important clarification:

> Composition does NOT mean the object cannot be replaced.
> Composition means **lifecycle ownership**, not permanence.

---

### 3.4 Inheritance (IS-A)

* Child extends parent
* Creates a contract
* Must follow LSP

Example:

* SavingsAccount → Account

Rule:

> Use inheritance only when substitution is safe

---

## 4. Composition vs Inheritance

### Prefer Composition When:

* Behavior changes frequently
* Runtime flexibility is required
* You want loose coupling

### Use Inheritance When:

* Strong IS-A relationship exists
* Child fully honors parent behavior
* Behavior is stable

Golden rule:

> Favor composition over inheritance unless the IS-A relationship is strong and stable

---

## 5. Abstraction – “Hiding Change”

Abstraction is **not about hiding code**, it is about **hiding change**.

Meaning:

* Clients depend on stable contracts
* Implementations can change freely

Rule:

> Put things that change behind interfaces

---

## 6. SOLID Principles

SOLID principles exist to **control change, reduce coupling, and improve maintainability**. Below, each principle is explained with **why it exists** and **how to apply it in real LLD**.

---

### 6.1 Single Responsibility Principle (SRP)

**Why SRP exists**

* To ensure changes affect only one class
* To reduce merge conflicts and regression bugs
* To make classes easier to understand and test

**How to use SRP**

* Identify reasons a class might change
* Split responsibilities by actor or concern
* Create small, focused classes

Rule:

> If you can describe a class using multiple "and" statements, SRP is violated.

---

### 6.2 Open/Closed Principle (OCP)

**Why OCP exists**

* To avoid modifying stable, tested code
* To reduce regression risk
* To support feature growth safely

**How to use OCP**

* Identify areas of variation
* Replace conditionals with polymorphism
* Use interfaces and strategies

Rule:

> New behavior should be added by writing new code, not changing old code.

---

### 6.3 Liskov Substitution Principle (LSP)

**Why LSP exists**

* To make inheritance safe
* To ensure polymorphism works correctly
* To prevent hidden runtime bugs

**How to use LSP**

* Define clear contracts in parent classes
* Ensure child classes honor parent behavior
* Avoid throwing new exceptions or removing functionality

Rule:

> Different implementation is fine, different meaning is not.

---

### 6.4 Interface Segregation Principle (ISP)

**Why ISP exists**

* To avoid forcing classes to implement unused methods
* To prevent fragile and bloated interfaces
* To reduce ripple effects of interface changes

**How to use ISP**

* Split large interfaces into role-based ones
* Group methods by client usage
* Prefer many small interfaces

Rule:

> Clients should depend only on what they use.

---

### 6.5 Dependency Inversion Principle (DIP)

**Why DIP exists**

* To decouple business logic from implementation details
* To improve testability
* To support easy replacement of components

**How to use DIP**

* Depend on interfaces, not concrete classes
* Inject dependencies via constructors
* Avoid creating dependencies inside high-level classes

Important note:

> Even if a dependency is an interface, creating it internally still violates DIP.

---

### 6.2 Open/Closed Principle (OCP)

> Open for extension, closed for modification

Bad:

* if-else or switch on types

Good:

* Interfaces + polymorphism
* Strategy pattern

Rule:

> Add new behavior without changing existing code

---

### 6.3 Liskov Substitution Principle (LSP)

> Child must be safely replaceable for parent

Key idea:

* Overriding is allowed
* Breaking parent expectations is NOT

LSP violation example:

* Parent allows withdraw
* Child throws exception

Rule:

> Different implementation is fine, different meaning is not

---

### 6.4 Interface Segregation Principle (ISP)

> Clients should not depend on methods they do not use

Bad:

* Fat interfaces
* Methods throwing UnsupportedOperationException

Good:

* Small, role-based interfaces

ISP prevents LSP violations.

---

### 6.5 Dependency Inversion Principle (DIP)

> High-level modules should depend on abstractions, not implementations

Bad:

* new EmailSender() inside service

Good:

* Constructor injection
* Depend on interfaces

Important note:

> Even if a dependency is an interface, creating it internally still violates DIP.

---

## 7. Bad Design → Good Design (Key Skill)

### Typical Problems in Bad Design

* God classes
* if-else on types
* Mixed responsibilities
* Tight coupling

### Refactoring Approach

1. Identify responsibilities (SRP)
2. Extract varying behavior (OCP)
3. Introduce abstractions
4. Inject dependencies (DIP)
5. Use polymorphism instead of conditionals

---

## 8. Strategy via Composition (Senior-Level Insight)

Instead of:

* Putting all rules in subclasses

Prefer:

* Delegating rules to policy/strategy objects

Example:

* User has BookingPolicy
* BookingPolicy defines validation and discount

Rule:

> Use inheritance for identity, composition for changing behavior

---

## 9. Orchestrator Pattern

Service classes like:

* CheckoutService
* TicketService

Should:

* Coordinate flow
* Not contain business rules

Rule:

> Orchestrators coordinate, they do not decide

---

## 10. Key Interview Mental Models

* Lifecycle ownership ≠ object replacement
* Substitution is about caller expectations
* Not every member variable is aggregation
* Not every abstraction needs a Service class
* Strategy > if-else
* Composition > inheritance when behavior varies

---

## 11. Where We Are Now

You now have:

* Strong LLD foundations
* Clear understanding of SOLID
* Ability to refactor procedural code into OO design

Next topics to cover:

* UML Class Diagrams
* Design Patterns (Strategy, Factory, Observer)
* Full LLD problems (Parking Lot, BookMyShow)

---

## 12. High-Impact Comparison Tables (Interview Essentials)

### 12.1 Association vs Aggregation vs Composition vs Inheritance

| Aspect               | Association          | Aggregation   | Composition             | Inheritance              |
| -------------------- | -------------------- | ------------- | ----------------------- | ------------------------ |
| Relationship Type    | Uses                 | HAS-A (weak)  | HAS-A (strong)          | IS-A                     |
| Ownership            | No                   | Partial       | Full                    | N/A                      |
| Lifecycle Dependency | None                 | Independent   | Dependent               | Shared                   |
| Object Creation      | External             | External      | Parent creates/controls | Parent class             |
| Replacement Allowed  | Yes                  | Yes           | Yes                     | N/A                      |
| Coupling             | Very Low             | Low           | High                    | Very High                |
| Typical Use Case     | Service → Repository | Team → Player | Order → OrderItem       | SavingsAccount → Account |
| Interview Risk       | Very Low             | Medium        | Low                     | High (LSP risk)          |

---

### 12.2 Inheritance vs Composition (Most Asked Comparison)

| Aspect               | Inheritance   | Composition          |
| -------------------- | ------------- | -------------------- |
| Core Idea            | IS-A          | HAS-A                |
| Coupling             | Tight         | Loose                |
| Flexibility          | Low           | High                 |
| Runtime Change       | Not possible  | Possible             |
| LSP Risk             | High          | None                 |
| Testing              | Harder        | Easier               |
| Refactoring Cost     | High          | Low                  |
| Interview Preference | Use carefully | Preferred by default |

---

### 12.3 SOLID Principles – Why vs What They Fix

| Principle | Main Problem It Solves     | Key Design Benefit         |
| --------- | -------------------------- | -------------------------- |
| SRP       | Too many reasons to change | Isolated changes           |
| OCP       | Repeated code modification | Safe extensibility         |
| LSP       | Broken inheritance         | Safe polymorphism          |
| ISP       | Fat interfaces             | Clean contracts            |
| DIP       | Tight coupling             | Testable & flexible design |

---

**These tables are high-yield revision material and frequently asked in LLD interviews.**

---

## 13. How to Achieve These Concepts Programmatically (Implementation Guide)

This section explains **how these design choices are actually implemented in code**, which is critical for LLD interviews.

---

### 13.1 How to Achieve Association

**Programmatic approach:**

* Pass objects as method parameters
* Hold references without creating or destroying them

Key indicators in code:

* No `new` keyword inside the class
* No lifecycle control

Use when:

* Objects only collaborate
* Dependency Injection is used

---

### 13.2 How to Achieve Aggregation

**Programmatic approach:**

* Parent holds references to child objects
* Child objects are injected from outside

Key indicators in code:

* Constructor injection of child
* Parent does not create child

Use when:

* Parent groups domain objects
* Child lifecycle is managed elsewhere

---

### 13.3 How to Achieve Composition

**Programmatic approach:**

* Parent creates and manages child
* Child lifecycle is tied to parent

Key indicators in code:

* Parent uses `new` to create child
* Child not shared externally

Important clarification:

> Replacing a composed object is allowed; lifecycle ownership remains with parent.

---

### 13.4 How to Achieve Inheritance Safely

**Programmatic approach:**

* Use `extends` / `implements`
* Define clear contracts in parent
* Override behavior without breaking expectations

Key rules:

* Do not throw new unexpected exceptions
* Do not remove parent behavior

Use only when:

* Strong IS-A relationship exists
* LSP is guaranteed

---

### 13.5 How to Achieve Abstraction

**Programmatic approach:**

* Use interfaces or abstract classes
* Depend on abstractions, not implementations

Key indicators in code:

* Variables typed as interfaces
* Multiple interchangeable implementations

Use when:

* Behavior is expected to change

---

### 13.6 How to Achieve SOLID Principles in Code

| Principle | Achieved Programmatically By          |
| --------- | ------------------------------------- |
| SRP       | Splitting classes by responsibility   |
| OCP       | Interfaces + polymorphism             |
| LSP       | Respecting parent contracts           |
| ISP       | Creating small, role-based interfaces |
| DIP       | Constructor injection + abstractions  |

---

### 13.7 Strategy Pattern (Most Used in Our Designs)

**Programmatic idea:**

* Extract varying behavior into interfaces
* Inject behavior at runtime

Use when:

* Business rules vary by type
* Conditional logic grows

This pattern was used in:

* Payment handling
* Booking policies
* Discount rules

---

### 13.8 Orchestrator Pattern (Service Design)

**Programmatic approach:**

* Orchestrator depends on abstractions
* Coordinates flow, does not contain rules

Key indicators:

* Calls multiple services
* No `if-else` business logic

---
