namespace Supplement_P1_5
{
    /// <summary>
    /// Shape3D is an abstract class that has three abstract methods: Volume, SurfaceArea, and Dump.
    /// </summary>
    public abstract class Shape3D
    {
        /// <summary>
        /// Calculates the volume of the 3D shape.
        /// </summary>
        /// <returns>Returns the volume of the shape as a double.</returns>
        public abstract double Volume();

        /// <summary>
        /// Calculates the surface area of the 3D shape.
        /// </summary>
        /// <returns>Returns the surface area of the shape as a double.</returns>
        public abstract double SurfaceArea();

        /// <summary>
        /// A formatted string containing details of a shape.
        /// </summary>
        /// <returns>Returns a string identifying the shape name, surface area, and volume.</returns>
        public abstract string Dump();
    }
}
