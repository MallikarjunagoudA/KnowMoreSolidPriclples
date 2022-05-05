# KnowMoreSolidPriclples


**Solution to develop a successful application depends on**

>> **Architecture** => choosing an architecture is the first step in designing application based on the req.
>> **Design Priniples** => Appkication development process need to follow tht desigh principles
>>**Design patterns** => We need to choose correct design patterns to build the software.


❤️**SOLID principles**❤️

❤️SOLID principles are the design pronciples that enable us manage most of the software design problems

❤️The term SOLID is an acronym for five design principles intended to make software designs more understandable, flexible and maintainable.


**🌟 WHY SOLID PEINCIPLES**

>>If we don't follow the solid principles we 

=> end up with tight or strong coupling of the code with many other modules/applications.
=> Tight coupling causes time to implement any new requirment, features or any bug fixes and some times it creates unkonwn issues.
=> End up with a code which is not testable.
=> End up with duplication of code.
=> End up creating new bugs by fixing another bug.
=> End up with many unknown issues in the application development cycle.


**🌟 SOLID PRINCIPLES HELPS US TO**

=> Achieve reduction in complexity of code.
=> Increase readability,extensibility and maintenannce.
=> Reduce error and implement Reusability.
=> Achieve better testability.
=> Reduce tight coupling.

**🌟SOLID Acronym**

>>❤️S❤️ single responsibility principle(SRP) - maintainability
>>❤️O❤️ open closed principle(OSP) - extenability
>>❤️L❤️ Liskov substitution Principle(LSP) - reuability
>>❤️I❤️ Interface segregation Principle(ISP) - flexibility
>>❤️D❤️ Dependency Inversion Priciple(DIP) - loose coupling

🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
>>**🌟single responsibility principle(SRP)**
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟

❤️ Every Module or class should have responsibility over a single part or the functionality provided by the software and that responsibility should be entirely encapsulated by the class.

❤️ each class and module should focus on a single task at a time

❤️ everything in the class should be related to that single purpose 

❤️ there can be many members in the class as long as they related to the single responsibility

❤️ with SRP, classes become smaller and clearner

❤️ code is less gragile. 


🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Liskov substitution Principle(LSP)**
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟


❤️If the program module is using a base class, then the reference to the base class can be replaced with a derived class without affecting the functionality of the program module.

❤️we can also state that derived types must be substitutable for their base types.


🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟open closed principle(OSP)**
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟


❤️ "The software entities should be open for extension, but closed for modification."
  
❤️ The design and writing of the code should be done in a way that new functionality should be added with minimum changes in the existing code.



🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Interface segregation Principle(ISP)**
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟




❤️"**Many client-specific interfaces are better than one general-purpose interface**"

❤️ we should not enforce clients to implement interfaces that they don't use. instead of crating one big interface we van break down it to smaller interfaces

❤️ No client should be forced to depend on methods it does not use.

❤️ one fat interface need to be split to many smaller and relevant interfaces so thta clients can know about the interfaces that are relevant to them.






🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Dependency Inversion Priciple(DIP)**
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟


❤️ Abstractions should not depend on the details whereas the details should depend on abstractions.

❤️ High-level modules should not depend on low level modules.


🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟

❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️

❤️
❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️
