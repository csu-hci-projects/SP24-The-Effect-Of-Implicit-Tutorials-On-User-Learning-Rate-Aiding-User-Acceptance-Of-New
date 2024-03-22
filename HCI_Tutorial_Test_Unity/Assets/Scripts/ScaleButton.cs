using RuntimeHandle;

public class ScaleButton : TransformButton
{
    public HandleAxes axes = HandleAxes.XYZ;
    protected override void SetType()
    {
        transformer.GetComponent<RuntimeTransformHandle>().axes = this.axes;
        transformer.GetComponent<RuntimeTransformHandle>().type = HandleType.SCALE;
    }
}
