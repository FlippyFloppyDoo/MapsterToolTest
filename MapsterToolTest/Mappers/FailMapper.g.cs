using MapsterToolTest;
using MapsterToolTest.Domain;
using MapsterToolTest.Features.Test;

namespace MapsterToolTest
{
    public partial class FailMapper : IFailMapper
    {
        public TestDto MapToDto(Test p1)
        {
            return p1 == null ? null : new TestDto() {B = p1.B};
        }
    }
}