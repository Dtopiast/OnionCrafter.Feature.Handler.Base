using OnionCrafter.Action.Request.Base;
using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Base;
using OnionCrafter.Feature.Handler.Base;
using OnionCrafter.Wrapper.Request.Base.Command;
using OnionCrafter.Wrapper.Response.Base;

namespace OnionCrafter.Feature.Handler.Base.Command
{
    /// <summary>
    /// Represents a base class for command request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public abstract class BaseRequestCommandHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        BaseRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>,
        IRequestCommandHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : ICommandRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDto, IResponseData
        where TRequestDTO : class, IBaseDto, IRequestData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestCommandHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO}"/> class.
        /// </summary>
        protected BaseRequestCommandHandler() : base()
        {
        }
    }
}