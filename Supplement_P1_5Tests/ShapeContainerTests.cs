using Supplement_P1_5;

namespace Supplement_P1_5Tests
{
    public class ShapeContainerTests
    {
        [Fact]
        public void ShouldCreate_AddsShapeToContainer()
        {
            ShapeContainer container = new ShapeContainer();
            Cube cube = new Cube(3);
            container.Create(cube);
            Assert.Equal(cube, container.Get(0));
        }

        [Fact]
        public void ShouldGet_ReturnsCorrectShape()
        {
            ShapeContainer container = new ShapeContainer();
            Sphere sphere = new Sphere(4);
            container.Create(sphere);
            Assert.Equal(sphere, container.Get(0));
        }

        [Fact]
        public void ShouldDelete_RemovesShapeFromContainer()
        {
            ShapeContainer container = new ShapeContainer();
            Cube cube = new Cube(2);
            container.Create(cube);
            bool result = container.Delete(0);
            Assert.True(result);
            Assert.Null(container.Get(0));
        }
    }
}
