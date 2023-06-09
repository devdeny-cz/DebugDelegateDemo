﻿#define RunThread
#define RunPersons
using DebugExample;


// example input arguments
#if DEBUG
Console.WriteLine(args.Length > 0 ? args[0] : "Nemám argument");
#endif

// example threads
#if RunThread
new Threads().RunThreads();
#endif

// example debug arguments
#if RunPersons
List<Person> persons = new List<Person>()
{
    new Person() { FirstName = "Daniel", BirthDate = DateTime.Now, LastName = "Michna" },
    new Person() { FirstName = "Daniel", BirthDate = DateTime.Now, LastName = "Michna" },
    new Person() { FirstName = "Gabriel", BirthDate = new DateTime(1989,3,3), LastName = "Kovács"
    ,Addresses = new List<Addresses>(){new Addresses("Ulice 1"), new Addresses("Ulice 2")}},
};
#endif

// example CallStack and exceptions
new CallStackDeep().Deep1();


int x = 0;
for (int i = 0; i < 10000; i++)
{
    x += i;
}

Console.ReadLine();

//if define a debug
//Thready a jejich debugging
//DebugDisplay
// breakpoint - import/export
// breakpoint condition/action