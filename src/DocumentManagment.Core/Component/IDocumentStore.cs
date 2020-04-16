﻿using DocumentManagement.Core.Domain;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DocumentManagement.Core.Component
{
    /// <summary>
    /// Document store
    /// </summary>
    public interface IDocumentStore
    {
        /// <summary>
        /// Upload document to document store.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="stream">Document stream.</param>
        /// <returns>Operation result<./returns>
        Task<OperationResult> UploadAsync(string name, Stream stream);

        /// <summary>
        /// Delete document from document store.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <returns>Operation result<./returns>
        Task<OperationResult> DeleteAsync(string name);

        /// <summary>
        /// Get all async.
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyCollection<DocumentEntity>> GetAllAsync();

        /// <summary>
        /// Reorder async.
        /// </summary>
        /// <param name="filed">Order by field.</param>
        /// <returns>Operation result.</returns>
        Task<IReadOnlyCollection<DocumentEntity>> ReorderAsync(params DocumentEntity[] entities);
    }
}