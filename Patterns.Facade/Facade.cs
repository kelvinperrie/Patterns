using Patterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    // this is based on the way WebPAS stores documents, it puts the files on a share somewhere and puts
    // file metadata into the database.

    internal class DocumentRepositoryFacade
    {
        private readonly DatabaseHelper _databaseHelper = new DatabaseHelper();
        private readonly FileSystemHelper _fileSystemHelper = new FileSystemHelper();

        // this method is just a wrapper around some other method calls; we want those calls to happen
        // in a certain order. We hide the complexity from whoever needs to upload a document because
        // really, who wants to know
        public void UploadDocument(string filepath, string metadata)
        {

            var storagePath = _databaseHelper.GetStoragePath();

            _fileSystemHelper.CopyFile(filepath, storagePath);

            _databaseHelper.AddDocumentMetaData(metadata);
            _databaseHelper.SetDocumentAvailable(true);

        }
    }
}
