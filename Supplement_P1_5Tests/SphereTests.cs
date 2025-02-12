using Supplement_P1_5;
using Xunit;

namespace Supplement_P1_5Tests
{
    public class SphereTests
    {
        [Fact]
        public void Sphere_ShouldCalcCorrectVolumeAndSurfaceAreaFor()
        {
            var sphere = new Sphere(3);
            Assert.Equal(113.097, sphere.Volume(), 3);
            Assert.Equal(113.097, sphere.SurfaceArea(), 3);
        }

        [Fact]
        public void Sphere_ShouldThrowExceptionWhenRadiusIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => new Sphere(-1));
        }
    }
}
