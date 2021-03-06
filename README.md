Refactoring Session for 7digital Tech Academy 
=============================================

This is a lesson and sample code I created to teach our tech accademy participants the basics of refactoring.

I have included lots of questions - if you are using this to teach people then ask these questions to encourage the group to really think about what they are doing and facilitate a discussion. If you are teaching yourself, use these questions as an exercise in understanding what you are doing in greater detail.


Q. What do you think refactoring is? 

(Definition: it is changing the code, without changing it’s external behaviour to make it “better”. This could be making it easier to read, make more sense, remove duplication or bigger things like restructuring large parts of it)

Q.Ask why we might do this? 
Q.What is the end goal?

We don’t want to make code that would end up on Daily wtf. So here are some examples of bad code:

http://thedailywtf.com/Articles/The-Best-Shopping-System-EVER.aspx
http://thedailywtf.com/Articles/The-Constant-Bomb.aspx
http://thedailywtf.com/Articles/Too-Much-of-a-Bad-Thing.aspx

...and some good ones (fyi much harder to find!)
http://www.hanselman.com/blog/CategoryView.aspx?category=Source+Code&page=2 - itunes example

https://github.com/7digital/webstore/blob/master/app/user/country.js 

Refactoring is a skill that must be learned along with programming and TDD. It is important because no one gets it right first time (except maybe Emma Watson).

Q.How do you refactor?

We are going to start with about “code smells”.

Code smells are things to look for in code that are indicators of a larger problem or something that could become a larger problem in the future. 

The important thing to bear in mind is that this encompasses the human side of development as well as the technical quality of the code. Computers will always be able to read code (providing it is valid syntax) but humans require a lot more than technically correct syntax to understand code properly.

Q.Why is it important to understand the code properly?

3 simple code smells
====================

Comments - FYI, 7digital do not do comments. They cannot show up in a test as being outdated/irrelevant. It is important they explain why and not what the code is doing.

Uncommunicative Name - Naming things is one of the hardest parts of software development. Methods and variables should be succinct, descriptive and simple. Don’t be tempted to be funny either. 

Dead Code - Delete code that is not being used. We have VCS these days. It is better to loose code than keep dead code floating around as it can get tricky to know if it is being used. 

Q.How would you refactor these things?

Example 1
=========

Example 1 is a simple class that is in dire need of some refactoring. Can you sniff out the problems and rework them into something a little nicer?


4 more code smells
==================


Long Parameter List - Harder to read and looks messy. Also adds complications when dealing with the parameters in code, especially if they are very similar.

Duplicated code - Dont. Repeat. Yourself. 

Inconsistent Names - Be consistent - pick a convention and stick to it throughout. eg. Open() and CloseConnection().   x

Primitive Obsession/Data Clumps - Don’t use a bunch of primitive types - consider put them in a class. If you see bits of data commonly used, consider putting them in a class together.

Q.How would you refactor these things?


Example 2 - part one
====================

Refactor the code by sniffing out these 4 smells. You can also consider refacotring tests but DO NOT change the core behaviour of the code.


3 more code smells
==================

Long method - keep it simple. shorter methods are easier to read and easier to fix. They can also contain repetition.

Inappropriate Intimacy - Classes that know too much about each other are inappropriately intimate. Classes should be focused on one thing and separated from each other.  This can mean classes depend on each other too much. 

Feature Envy - A class that has methods that make extensive use of another class methods and data. 

Example2 - part two 
===================

Can you tackle that awfully complicated long method and can you sort out the close relationship between the two classes? 

Summary Questions
=================

Q. Which refactoring that you made did you find the hardest? Why?
Q. Which refactoring that you made do you feel made the code more readable?
Q. Which refactoring that you made do you feel made the code less complicated?
Q. If you could only refactor one code smell in Example 1 and 2 - which one do you think would most important in making the code easier to work with for a future developer. 



















