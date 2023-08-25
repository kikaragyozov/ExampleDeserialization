using Microsoft.AspNetCore.Mvc;

namespace ExampleDeserialization
{
    [ApiController]
    [Route("test")]
    public class ExampleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Test(ExampleObject @object)
        {
            return Ok(@object.SomeProperty);
        }
    }

    public class ExampleObject
    {
        public string? SomeProperty { get; set; }
    }
}
