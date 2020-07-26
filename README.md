# Test Driven Development
## Sample project created during demonstration showcasing interfaces, unit testing, and test-driven development.
### Author: Erik Gassler

During the demonstration, we built this console application that expects to be given a number that is part of a Fibanachi sequence (1, 2, 3, 5, 8, 13, 21, etc), and will return the next number in the sequence.

In cases where a number is not given, or a number is given that is not a valid fibanachi sequence number (4, 6, 7, 9, etc), the app is expected to return a message to alert the user that their input is invalid.

This project demonstrates some various "best-practices".

1. Added a Startup.cs for consistence dependency injection framework usage for .NET projects.
1. Separated application processing into a .NET Standard project - [AppService], and minimized the .NET Core client app - [TestDrivenDevelopmentSample].
    - I initially formed this practice out of necessity to be able to unit test my projects using NCrunch, which often has issues with Client frameworks.
    - Aside from that I still believe this to be a good practice, as separting the Client presentation from the backend processing into separate projects makes it much easier to just swap out one client for another without having to rewrite the backend, since it's completely de-coupled.
1. Because most of the code was written following test-driven development, and we made sure to go back and write tests for the small amount of code we didn't write tests for first, the AppService project has 100% unit testing code coverage.
1. 


The client project is not covered under any such unit tests. With this method of separation, the client app would be better served to be covered by integration tests, rather than any kind of unit testing, which was out of the scope of this demonstration.

But we did do manual integration testing during the demonstration to verify the application worked as expected and gave us the expected results.
 