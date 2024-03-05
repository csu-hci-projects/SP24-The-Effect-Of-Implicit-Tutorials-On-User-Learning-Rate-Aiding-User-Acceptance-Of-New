using RuntimeHandle;

public class PositionButton : TransformButton
{
    protected override void SetType()
    {
       transformer.GetComponent<RuntimeTransformHandle>().type = HandleType.POSITION;
    }
}
