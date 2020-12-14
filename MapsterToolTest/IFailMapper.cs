using System.Collections.Generic;
using System.Linq;
using Mapster;
using MapsterToolTest.Features.Test;

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
        public int A { get; set; }
        public string FirstB { get; set; }
    }
}

namespace MapsterToolTest.Domain    
{
    public class Test
    {
        public int A { get; set; }
        public ICollection<InnerTest> B { get; set; } = new List<InnerTest>();
    }

    public class InnerTest
    {
        public string B { get; set; }
    }
    
    public class TestRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Test, TestDto>()
                .Map(dto => dto.FirstB, test => test.B.First().B);
        }
    }
}

