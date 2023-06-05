using InheritanceAndInterface.Model.Enums;

namespace InheritanceAndInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
