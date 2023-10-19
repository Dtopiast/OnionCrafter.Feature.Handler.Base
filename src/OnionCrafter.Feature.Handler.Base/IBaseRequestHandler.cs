using MediatR;
using OnionCrafter.Wrapper.Request.Base;
using OnionCrafter.Wrapper.Response.Base;

namespace OnionCrafter.Feature.Handler.Base
{
    /// <summary>
    /// Interface representing a base request handler
    /// </summary>
    public interface IBaseRequestHandler
    {
    }

    /// <summary>
    /// Interface representing a base request handler with request and response schema types.
    /// </summary>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>

    public interface IBaseRequestHandler<TRequestSchema, TResponseSchema> :
        IBaseRequestHandler, IRequestHandler<TRequestSchema, TResponseSchema>
        where TRequestSchema : IBaseRequestSchema, IRequest<TResponseSchema>
        where TResponseSchema : IBaseResponseSchema
    {
    }
}