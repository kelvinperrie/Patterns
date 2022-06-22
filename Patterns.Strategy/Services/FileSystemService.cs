using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Services
{
    internal class FileSystemService : ILastDocument
    {
        public DocumentDetails GetLastDocument()
        {
            // in theory this could look on the file system and get the most recent file there
            return new DocumentDetails
            {
                FileName = "File system file",
                TimeAdded = DateTime.Now,
            };
        }
    }
}
