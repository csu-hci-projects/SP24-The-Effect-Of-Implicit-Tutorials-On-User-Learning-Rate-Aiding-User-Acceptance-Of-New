using RuntimeHandle;

public class RotateButton : TransformButton
{
    protected override void SetType()
    {
       transformer.GetComponent<RuntimeTransformHandle>().type = HandleType.ROTATION;
    }
}
