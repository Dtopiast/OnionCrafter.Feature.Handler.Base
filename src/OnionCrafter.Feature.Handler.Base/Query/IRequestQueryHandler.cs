using OnionCrafter.Action.Request.Base;
using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Base;
using OnionCrafter.Wrapper.Request.Base.Query;
using OnionCrafter.Wrapper.Response.Base;

namespace OnionCrafter.Feature.Handler.Base.Query
{
    /// <summary>
    /// Represents a base interface for query request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public interface IRequestQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        IRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TRequestSchema : IQueryRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TRequestDTO : class, IBaseDto, IRequestData
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TReturnDTO : class, IBaseDto, IResponseData
    {
    }
}