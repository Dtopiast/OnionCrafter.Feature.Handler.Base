using OnionCrafter.Action.Request.Base;
using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Base;
using OnionCrafter.Wrapper.Request.Base;
using OnionCrafter.Wrapper.Request.Base.Query;
using OnionCrafter.Wrapper.Response.Base;

namespace OnionCrafter.Feature.Handler.Base.Query
{
    /// <summary>
    /// Represents a base class for query request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public abstract class BaseRequestQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        BaseRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>,
        IRequestQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IQueryRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDto, IResponseData
        where TRequestDTO : class, IBaseDto, IRequestData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestQueryHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO}"/> class.
        /// </summary>
        protected BaseRequestQueryHandler() : base()
        {
        }
    }
}