using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy
{
    public class DoLastDocumentExtraction
    {
        ILastDocument _documentExtractor;

        internal DoLastDocumentExtraction(ILastDocument documentExtractor)
        {
            // pass in the service, then our code below is all the same, but performs different actions at runtime
            // depending on how this class is composed
            _documentExtractor = documentExtractor;
        }

        internal void DoExtraction()
        {
            // ... a whole lot of complicated code

            // when the process has something that varies, we extract that out into another class. It can then be injected depending on 
            // our needs. E.g. if this solution is using sharepoint then the ILastDocument extractor would be the one that knows how to
            // get the code form sharepoint. If the solution was using the file system to store files then the ILastDocument extractor
            // would be the file system one.

            _documentExtractor.GetLastDocument();

            // ... a whole lot of complicated code
        }

    }
}