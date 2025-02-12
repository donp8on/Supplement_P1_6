using Supplement_P1_5;

namespace Supplement_P1_5
{
    public class Cube : Shape3D
    {
        private double sideLength;
        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
            Validate();
        }

        private void Validate()
        {
            if (sideLength <= 0)
            {
                throw new System.ArgumentException("Side length must be greater than 0.");
            }
        }

        public override double Volume()
        {
            return sideLength * sideLength * sideLength;
        }
        public override double SurfaceArea()
        {
            return 6 * sideLength * sideLength;
        }
        public override string Dump()
        {
            return $"Cube: Surafce Area = {SurfaceArea():F2}, Volume:{Volume():F2}";
        }
    }
}

