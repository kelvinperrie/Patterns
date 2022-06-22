using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Services
{
    internal class SharePointService : ILastDocument
    {
        public DocumentDetails GetLastDocument()
        {
            // in theory this could contact a sharepoint instance and get the last document
            // using code specific to sharepoint
            return new DocumentDetails
            {
                FileName = "Sharepoint file",
                TimeAdded = DateTime.Now
            };
        }
    }
}
