using Mapster;

namespace MapsterToolTest
{
    [Mapper]
    public interface IFailMapper
    {
        MapsterToolTest.Features.Test.TestDto MapToDto(MapsterToolTest.Domain.Test test);
    }
}

namespace MapsterToolTest.Features.Test    
{
    public class TestDto
    {
        public int B { get; set; }
    }
}

namespace MapsterToolTest.Domain    
{
    public class Test
    {
        public int B { get; set; }
    }
}