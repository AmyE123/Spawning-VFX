using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VisualEffectController : MonoBehaviour
{
    public enum Degree { ZeroDegrees = 0, NinetyDegrees = 90 };

    [Header("VFX Properties")]
    [SerializeField] [Tooltip("The mesh renderers which we want to have the holographic FX on")] private MeshRenderer[] _meshRenderers;
    [SerializeField] private VfxRotationProperties[] _rotationData;
    public Degree Rotation;

    [Header("Particle Properties")]
    [SerializeField] private ParticleSystem _particleSpawningParticles;
    [SerializeField] private Material _particleMaterial;
    [SerializeField] [ColorUsage(true, true)] private Color _particleColour;


    [Header("Shader Properties")]
    [SerializeField] private List<Material> _shaderMaterialInstances;
    [SerializeField] [ColorUsage(true, true)] private Color _shaderOutlineColour;






    // Start is called before the first frame update
    void Start()
    {
        foreach (MeshRenderer mr in _meshRenderers)
        {
            _shaderMaterialInstances.Add(mr.material);
        }
    }

    void SetVFXRotation()
    {
        int eValue = (int)Rotation;

        _particleMaterial.SetFloat("_Rotation", eValue);

        foreach (Material m in _shaderMaterialInstances)
        {
            m.SetFloat("_Rotation", eValue);

            if (eValue == 0)
            {
                m.SetFloat("_OutlineThickness", _rotationData[0].OutlineThickness);
            }
            else
            {
                m.SetFloat("_OutlineThickness", _rotationData[1].OutlineThickness);
            }
        }

    }

    void SetVFXColour()
    {
        _particleMaterial.SetColor("_GlowColour", _particleColour);

        foreach (Material m in _shaderMaterialInstances)
        {
            m.SetColor("_GlowColour", _shaderOutlineColour);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_shaderMaterialInstances != null)
        {
            SetVFXColour();
            SetVFXRotation();
        }


    }
}
