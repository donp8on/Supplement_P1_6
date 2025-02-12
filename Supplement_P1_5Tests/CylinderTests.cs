using Supplement_P1_5;
using Xunit;

namespace Supplement_P1_5Tests
{
    public class CylinderTests
    {
        [Fact]
        public void Cylinder_ShouldCalcCorrectVolumeAndSurfaceAreaFor()
        {
            var cylinder = new Cylinder(3, 5);
            Assert.Equal(141.372, cylinder.Volume(), 3);
            Assert.Equal(150.796, cylinder.SurfaceArea(), 3);
        }

        [Fact]
        public void Cylinder_ShouldThrowExceptionWhenRadiusIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(-1, 4));
        }
    }
}
