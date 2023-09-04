using MediatR;
using OnionCrafter.Action.Request.Base;
using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Base;
using OnionCrafter.Wrapper.Request.Base;
using OnionCrafter.Wrapper.Response.Base;

namespace OnionCrafter.Feature.Handler.Base
{
    /// <summary>
    /// Represents a base interface for request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public interface IRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        IBaseRequestHandler<TRequestSchema, TResponseSchema>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TRequestDTO : class, IBaseDto, IRequestData
        where TReturnDTO : class, IBaseDto, IResponseData
        where TRequestSchema : IBaseRequestSchema, IRequest<TResponseSchema>
        where TResponseSchema : IBaseResponseSchema
    {
    }
}