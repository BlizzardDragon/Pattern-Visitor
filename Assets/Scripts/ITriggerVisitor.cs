public interface ITriggerVisitor
{
    void Visit(Cube cube);
    void Visit(Sphere sphere);
    void Visit(Cylinder cylinder);
}
