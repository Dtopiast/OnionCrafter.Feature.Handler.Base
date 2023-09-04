using OnionCrafter.Action.Request.Base;
using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Base;
using OnionCrafter.Wrapper.Request.Base;
using OnionCrafter.Wrapper.Request.Base.Query;
using OnionCrafter.Wrapper.Response.Base;
namespace OnionCrafter.Feature.Handler.Base
{
    /// <summary>
    /// Provides a base implementation for request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public abstract class BaseRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        IBaseRequestHandler,
        IRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDto, IResponseData
        where TRequestDTO : class, IBaseDto, IRequestData
    {
      

        /// <summary>
        /// The result message.
        /// </summary>
        protected string _resultMessage;

        /// <summary>
        /// The response schema instance.
        /// </summary>
        protected TResponseSchema _responseSchema;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO}"/> class.
        /// </summary>
        protected BaseRequestHandler()
        {
            _resultMessage = string.Empty;
            _responseSchema = Activator.CreateInstance<TResponseSchema>();
        }

        /// <summary>
        /// Handles the request and returns the response schema.
        /// </summary>
        /// <param name="request">The request schema.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response schema.</returns>
        public virtual async Task<TResponseSchema> Handle(TRequestSchema request, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                _responseSchema.SetFeatureCall(request.GetRequestFeature());
                _responseSchema.SetMessage(_resultMessage);
            }, cancellationToken);
            return _responseSchema;
        }
    }
}