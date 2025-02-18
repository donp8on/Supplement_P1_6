using Supplement_P1_5;

namespace Supplement_P1_5
{
    /// <summary>
    /// This class is a container for storing and managing 3D shapes for creating,
    /// getting, and deleting shapes.
    /// </summary>
    public class ShapeContainer
    {
        private List<Shape3D> shapes = new List<Shape3D>();

        public void Create(Shape3D shape) => shapes.Add(shape);


        public Shape3D Get(int index) => (index >= 0 && index < shapes.Count) ? shapes[index] : null;

    
        public bool Delete(int index)
        {
            if (index >= 0 && index < shapes.Count)
            {
                shapes.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}