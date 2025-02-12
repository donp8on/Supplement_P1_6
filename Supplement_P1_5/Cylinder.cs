namespace Supplement_P1_5
{
    /// <summary>
    /// This is a 3D Cyclinder shape.
    /// The class provides functionality to calculate the cyclinder's volume and surface area.
    /// It includes validation to ensure the height and also radius is greater than zero.
    /// </summary>
    public class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            Validate();
        }

        private void Validate()
        {
            if (radius <= 0 || height <= 0)
            {
                throw new System.ArgumentException("Radius and height must be greater than 0.");
            }
        }

        public override double Volume()
        {
            return System.Math.PI * radius * radius * height;
        }

        public override double SurfaceArea()
        {
            return 2 * System.Math.PI * radius * (radius + height);
        }

        public override string Dump()
        {
            return $"Cylinder: Surface Area = {SurfaceArea():F2}, Volume:{Volume():F2}";
        }
    }
}
