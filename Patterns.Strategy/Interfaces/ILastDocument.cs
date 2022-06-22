using Patterns.Strategy.Models;

namespace Patterns.Strategy.Interfaces
{
    internal interface ILastDocument
    {
        DocumentDetails GetLastDocument();
    }
}