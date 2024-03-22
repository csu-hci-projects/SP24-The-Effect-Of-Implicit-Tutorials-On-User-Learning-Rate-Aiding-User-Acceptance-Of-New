using RuntimeHandle;

public class PositionButton : TransformButton
{
    public HandleAxes axes = HandleAxes.XYZ;
    protected override void SetType()
    {
        transformer.GetComponent<RuntimeTransformHandle>().axes = this.axes;
        transformer.GetComponent<RuntimeTransformHandle>().type = HandleType.POSITION;
    }
}
