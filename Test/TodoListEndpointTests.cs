using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    //public class TodoListEndpointTests : IClassFixture<WebApplicationFactory<WebAPI.Endpoints>>
    //{
    //    private readonly WebApplicationFactory<WebAPI.Endpoints> _factory;

    //    public TodoListEndpointTests(WebApplicationFactory<WebAPI.Endpoints> factory)
    //    {
    //        _factory = factory;
    //    }

    //    [Fact]
    //    public async Task GetAllTodoLists_Returns_OK()
    //    {
    //        // Arrange: Khởi tạo HttpClient từ factory
    //        var client = _factory.CreateClient();

    //        // Act: Gửi yêu cầu GET đến endpoint
    //        var response = await client.GetAsync("/api/todolists");

    //        // Assert: Kiểm tra kết quả
    //        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    //    }
    //}
}
