namespace MapsterToolTest
{
    public partial class FailMapper : MapsterToolTest.IFailMapper
    {
        public MapsterToolTest.Features.Test.TestDto MapToDto(MapsterToolTest.Domain.Test p1)
        {
            return p1 == null ? null : new MapsterToolTest.Features.Test.TestDto()
            {
                A = p1.A,
                FirstB = p1.B.First<MapsterToolTest.Domain.InnerTest>().B
            };
        }
    }
}