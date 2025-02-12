using Supplement_P1_5;

namespace Supplement_P1_5Tests
{
    public class CubeTests
    {
        [Fact]
        public void ShouldCalcCorrectVolumeAndSurfaceArea()
        {
            var cube = new Cube(3);
            Assert.Equal(27, cube.Volume());
            Assert.Equal(54, cube.SurfaceArea());
        }

        [Fact]
        public void ShouldThrowExceptionWhenSideLengthIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => new Cube(-1));
        }
    }
}