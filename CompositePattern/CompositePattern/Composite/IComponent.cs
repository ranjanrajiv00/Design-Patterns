namespace CompositePattern.Composite
{
    public interface IComponent
    {
        string Name { get; set; }

        void Add(IComponent component);

        void Remove(IComponent component);

        void Display(int depth);
    }
}