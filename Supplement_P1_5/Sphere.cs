namespace Supplement_P1_5
{
    /// <summary>
    /// This is a 3D sphere shape.
    /// The class provides functionality to calculate the sphere's volume and surface area.
    /// It includes validation to ensure the radius is greater than zero.
    /// </summary>
    public class Sphere : Shape3D
    {
        private double radius;
        public Sphere(double radius)
        {
            this.radius = radius;
            Validate();
        }
        private void Validate()
        {
            if (radius <= 0)
            {
                throw new System.ArgumentException("Radius must be greater than 0.");
            }
        }
        public override double Volume()
        {
            return 4.0 / 3.0 * System.Math.PI * Math.Pow(radius, 3);
        }
        public override double SurfaceArea()
        {
            return 4 * System.Math.PI * radius * radius;
        }
        public override string Dump()
        {
            return $"Sphere: Surface Area = {SurfaceArea():F2}, Volume:{Volume():F2}";
        }
    }
}
