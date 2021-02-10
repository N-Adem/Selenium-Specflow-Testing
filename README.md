Project goal
------------
To develop testing frameworks with the use of the Page Object Model(POM) framework.
To explore and develop tests using a Test Driven Development(TDD) and 
Behaviour Driven Devlopment(BDD). Supported by the use of the tools Selenium and Specflow.

Table Of Contents
------------------
1. Project definition of done
2. Framework
3. Class Diagram
4. Testing
5. Sprint Review
6. Sprint Retrospective

Project definition of done
--------------------------
- All tests pass
- Clear documentation
- Clear diagrams
- Project delivered within expected timeframe

Framework
---------
The TDD framework was developed using the POM where by applying the webdrivers Chrome and Firefox
and building a system which utilises Selenium and driver functionality, to access elements of the web
application *https://www.johnlewis.com/* providing the framework with the correct information inorder to 
simulate a users functionality.
The BDD framework was developed converting Gherkin syntax formed from the requirements gathering process, which 
with the help of specflow generated a functional template where each step of the usecase could be tested. 
The structure of the usecase feature is a followed Given, and, when, then. 

Class Diagram
-------------
![alt text](http://SpartaDevelopment/FixerIOwalkthrough/Imgs)

Testing
-------
Testing was primarily focused on simulating the users journey which was consolidated by unit tests
and comparing resutls to expected results. If the expected results didn't match the action results 
the system will consider the test a fail. Since each test was formed using the processes mentioned above 
by the tests passing we can safely conclude that the functionality works as intended. 

Sprint Review
-------------
Sprint Retrospective
--------------------
