// See https://aka.ms/new-console-template for more information
using Patterns.Facade;
using Patterns.Facade.Services;

Console.WriteLine("Hello, World!");

// the facade pattern is really just a wrapper around some more complicated code (it probably just calls other code to do stuff). This happens
// all the time; I use it to:
// * group stuff together that needs to happen in a certain order
// * present a simplified interface to complicated actions
// * wrap up interaction with an external object/api so it is easier to mock for coded unit testing

// a lot of helper or utility class are facades. I mean, business services are kind of facades, but maybe it differs a bit because they
// often do the work themselves rather than delgating it

// I don't reckon there is much different between this and the adapter pattern; the facade is about giving a simple interface, the adapter pattern
// is more about changing an interface to match an existing

string dummyDocument = @"c:\temp\wow.pdf";
string dummyMetadata = "pretend I'm some JSON or something";


void UsingTheFacade()
{
    // oh wow, so amazing, simple code. Put an inteface on 'DocumentRepositoryFacade' and it becomes easy to
    // mock and use in unit tests, this is just so exciting.
    var docRepo = new DocumentRepositoryFacade();

    docRepo.UploadDocument(dummyDocument, dummyMetadata);
}

void NotUsingTheFacade()
{
    // boo, how we going to test this. This class now needs to know about those dependencies and everyone hates tightly coupled code.
    // I suppose you could slap an interface on them and inject into the constructor (assuming you have control over the classes). If you
    // do this multiple times in code you need to get the sequence right every time.
    DatabaseHelper _databaseHelper = new DatabaseHelper();
    FileSystemHelper _fileSystemHelper = new FileSystemHelper();

    var storagePath = _databaseHelper.GetStoragePath();

    _fileSystemHelper.CopyFile(dummyDocument, storagePath);

    _databaseHelper.AddDocumentMetaData(dummyMetadata);
    _databaseHelper.SetDocumentAvailable(true);
}

