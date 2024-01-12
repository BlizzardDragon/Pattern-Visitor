public interface ITriggerVisitor
{
    void Visit(BlueTrigger blue);
    void Visit(RedTrigger red);
    void Visit(GreenTrigger green);
}
