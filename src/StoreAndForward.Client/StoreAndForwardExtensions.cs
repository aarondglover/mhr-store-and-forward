// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DigitalHealth.StoreAndForward.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StoreAndForward.
    /// </summary>
    public static partial class StoreAndForwardExtensions
    {
            /// <summary>
            /// Get all documents.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDate'>
            /// Filter start date
            /// </param>
            /// <param name='endDate'>
            /// Filter end date
            /// </param>
            /// <param name='documentStatus'>
            /// Comma separated list of document status
            /// </param>
            /// <param name='offset'>
            /// Page offset
            /// </param>
            /// <param name='limit'>
            /// Page limit
            /// </param>
            public static DocumentListModel GetDocuments(this IStoreAndForward operations, System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string documentStatus = default(string), int? offset = default(int?), int? limit = default(int?))
            {
                return operations.GetDocumentsAsync(startDate, endDate, documentStatus, offset, limit).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all documents.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDate'>
            /// Filter start date
            /// </param>
            /// <param name='endDate'>
            /// Filter end date
            /// </param>
            /// <param name='documentStatus'>
            /// Comma separated list of document status
            /// </param>
            /// <param name='offset'>
            /// Page offset
            /// </param>
            /// <param name='limit'>
            /// Page limit
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DocumentListModel> GetDocumentsAsync(this IStoreAndForward operations, System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string documentStatus = default(string), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDocumentsWithHttpMessagesAsync(startDate, endDate, documentStatus, offset, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enqueue a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='document'>
            /// Document to enqueue
            /// </param>
            public static DocumentModel AddDocument(this IStoreAndForward operations, DocumentModel document)
            {
                return operations.AddDocumentAsync(document).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enqueue a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='document'>
            /// Document to enqueue
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DocumentModel> AddDocumentAsync(this IStoreAndForward operations, DocumentModel document, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddDocumentWithHttpMessagesAsync(document, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            public static DocumentModel GetDocument(this IStoreAndForward operations, int id)
            {
                return operations.GetDocumentAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DocumentModel> GetDocumentAsync(this IStoreAndForward operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDocumentWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            public static void DeleteDocument(this IStoreAndForward operations, int id)
            {
                operations.DeleteDocumentAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteDocumentAsync(this IStoreAndForward operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteDocumentWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all document events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            public static EventListModel GetDocumentEvents(this IStoreAndForward operations, int id)
            {
                return operations.GetDocumentEventsAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all document events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Document ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventListModel> GetDocumentEventsAsync(this IStoreAndForward operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDocumentEventsWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDate'>
            /// Filter start date
            /// </param>
            /// <param name='endDate'>
            /// Filter end date
            /// </param>
            /// <param name='eventType'>
            /// Event type
            /// </param>
            /// <param name='offset'>
            /// Page offset
            /// </param>
            /// <param name='limit'>
            /// Page limit
            /// </param>
            public static TimelineModel GetEvents(this IStoreAndForward operations, System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string eventType = default(string), int? offset = default(int?), int? limit = default(int?))
            {
                return operations.GetEventsAsync(startDate, endDate, eventType, offset, limit).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startDate'>
            /// Filter start date
            /// </param>
            /// <param name='endDate'>
            /// Filter end date
            /// </param>
            /// <param name='eventType'>
            /// Event type
            /// </param>
            /// <param name='offset'>
            /// Page offset
            /// </param>
            /// <param name='limit'>
            /// Page limit
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TimelineModel> GetEventsAsync(this IStoreAndForward operations, System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string eventType = default(string), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEventsWithHttpMessagesAsync(startDate, endDate, eventType, offset, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
