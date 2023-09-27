using UnityEngine;

public class RotationData
{
    public Quaternion Rotation { get; set; }

    public RotationData()
    {
        Rotation = Quaternion.identity;
    }
}
