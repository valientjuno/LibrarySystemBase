C# Object-Oriented Programming – Inheritance
Overview

This project demonstrates the use of inheritance in C#.
A base class LibraryItem is extended by thrWritingee derived classes:

Book

DVD

Magazine

Each derived class adds its own specific property while sharing common properties from the base class.

Concepts Demonstrated

Base and derived classes

Constructors in inheritance

Calling base constructors using : base()

Access modifiers (private, public)

Code organization into separate class files

Class Structure
Base Class

LibraryItem

Private Fields:

Title

Author

Public Method:

PrintInfo()

Derived Classes

Book

Private Field:

PageCount

Public Method:

PrintBookInfo()

DVD

Private Field:

Duration

Public Method:

PrintDVDInfo()

Magazine

Private Field:

IssueNumber

Public Method:

PrintMagazineInfo()

Example Output

Title: C# Programming, Author: Ashton
PageCount: 450

Title: Learn C#, Author: Ashton
Duration: 120 minutes

Title: Tech Weekly, Author: Austin
Issue Number: 34

How to Run

Open the solution in Visual Studio.

Build the project.

Run the application.

View output in the console window.

.NET Version

Built using .NET 6 / .NET 7.
