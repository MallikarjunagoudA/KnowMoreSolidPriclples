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
>>**🌟single responsibility principle(SRP)**(add sutract mul div calculate example)
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟

❤️ Every Module or class should have responsibility over a single part or the functionality provided by the software and that responsibility should be entirely encapsulated by the class.

❤️ each class and module should focus on a single task at a time

❤️ everything in the class should be related to that single purpose 

❤️ there can be many members in the class as long as they related to the single responsibility

❤️ with SRP, classes become smaller and clearner

❤️ code is less gragile. 


🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Liskov substitution Principle(LSP)** (exception for a ocp extension example of bonus for temp permenenet and contract)
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟


❤️ If the program module is using a base class, then the reference to the base class can be replaced with a derived class without affecting the functionality of the program module.

❤️ we can also state that derived types must be substitutable for their base types.

❤️ S is subtype of T, then objects of type T may replaecd with objexts of type S.

❤️ derived types must be completly substityable for teir base types.

❤️ liskov substitution principle is a particular definition of a subtypeing relation called (strong) behaviral subtyping.

>>implementation guidlines

=> no new exceptions can be thrown by the subtype.
=>clients should not know which specifix subtype they are calling
=> new derived classes just extend without replacing the fuctionality of old classes.






🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟open closed principle(OCP)**(example of bonus for temp permenenet and contract)
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟


❤️ "The software entities should be open for extension, but closed for modification."
  
❤️ The design and writing of the code should be done in a way that new functionality should be added with minimum changes in the existing code.

❤️ Any new functionality should be implemented by addeding new classes, attribures and methods, instead of changing the current ones or existing ones. 

>>implementation guidelines
=>the simplest way to apply OCP is to impllement the new functionality on new derived classes.
=> allow clients to adcess the original class with abstract interface.


why? if not followed then what might will happen?
if not followed
=> End up testing the entire functionality.
=> QA team need to test the entire flow.
=> costly process for the organization.
=> Maintainance overheads increas on the classes.
=> Breaks the SRP.





🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Interface segregation Principle(ISP)**(printer example)
🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟




❤️"**Many client-specific interfaces are better than one general-purpose interface**"

❤️ we should not enforce clients to implement interfaces that they don't use. instead of crating one big interface we van break down it to smaller interfaces

❤️ No client should be forced to depend on methods it does not use.

❤️ one fat interface need to be split to many smaller and relevant interfaces so that clients can know about the interfaces that are relevant to them.






🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟🌟
**🌟Dependency Inversion Priciple(DIP)**(tightly and loosly coupling)
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
