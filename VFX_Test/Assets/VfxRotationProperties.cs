using UnityEngine;

/// <summary>
/// Due to the rotation not looking correct at every angle, this data will allow me to manually
/// put in the right values for set angles that the player can choose from
/// </summary>
[CreateAssetMenu(fileName = "VFXRotationData", menuName = "ScriptableObjects/VFXRotationData")]
public class VfxRotationProperties : ScriptableObject
{
    public float OutlineThickness;

    [Range(0, 90)]
    public int RotationDegrees;
}
