using Application;

namespace WebAPI.Endpoints.TodoListEndpoints
{
    public static class TodoListEndpntWithLambda
    {
        public static IEndpointRouteBuilder MapTodoListEndpointsWithLambda(this IEndpointRouteBuilder builder)
        {
            var groupBuilder = builder.MapGroup("api/reviews");

            groupBuilder.MapGet("/", async (ITodoListService todoListService)
                => TypedResults.Ok(await todoListService.GetAllTodoListsAsync()))
            .Produces(StatusCodes.Status500InternalServerError)
            .WithTags("Get")
            .WithOpenApi(op =>
            {
                op.Summary = "Get all todo List";
                return op;
            });

            return builder;
        }
    }
}

