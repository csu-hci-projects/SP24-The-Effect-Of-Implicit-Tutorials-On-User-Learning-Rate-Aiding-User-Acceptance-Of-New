using RuntimeHandle;

public class ScaleButton : TransformButton
{
    protected override void SetType()
    {
       transformer.GetComponent<RuntimeTransformHandle>().type = HandleType.SCALE;
    }
}
