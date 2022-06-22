// See https://aka.ms/new-console-template for more information
using Patterns.Singleton;

Console.WriteLine("Hello, World!");

// singletons are for when you only ever want a single instance of an object that is shared over the whole application. I don't
// think I've ever created my own singleton, acutally maybe I have kind of done it via dependency injection configuration.
// I'm gonna take some guesses at when you might want to do this: logging, some sort of pooling (i.e. to database), maybe a record
// counter or something, a wrapper around an object that you can't access at the same time from two places (i.e. something
// that isn't thread safe) ... and I can't think of anything else

// singleton vs static
// You could use DI to create singletons - they can implement interfaces, static classes can't. Singletons have a constructor which
// could be useful - but could only be used the first time you called it so how much value is that (maybe some, depending on situation)? 
// You could have a normal class and then just tell your DI container to only ever create one instance of it, hey presto, it's a singleton.
// services.AddSingleton<ILogger, MyBadLogger>();

// 1. using a class to always return the same object to us
// the Instance property on the Singleton class is kind of a factory method

var single1 = Singleton.Instance;
single1.someValue = 5;

var single2 = Singleton.Instance;
single2.someValue = 2;

// both single1 and single2 are the same object

Console.WriteLine($"single1.someValue is {single1.someValue}");     // outputs 2
Console.WriteLine($"single2.someValue is {single2.someValue}");     // outputs 2


// 2. using a static class, no excitement here

StaticSingle.someValue = 4;

StaticSingle.someValue = 3;


// 3. here's a little experiment, how could a singleton with a constructor param work ...

// a param is passed in and set when the singleton is created
var single3 = SingletonConParam.Instance("green");

// at this point we already have a singleton, so what happens with the param this time
// can depend on the implementation; could either just throw away the param the second time, or like in this case
// perform some action internally on the singleton
var single4 = SingletonConParam.Instance("yellow");

Console.WriteLine($"single3 reckons the best colour is {single3.WhatsTheBestColour()}");    // outputs yellow
Console.WriteLine($"single4 reckons the best colour is {single4.WhatsTheBestColour()}");    // outputs yellow
// it seems kind of pointless, but there are prob some situations where it would be useful

