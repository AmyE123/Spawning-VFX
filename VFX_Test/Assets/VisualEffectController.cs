using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VisualEffectController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _spawningParticleFX;
    [SerializeField] private Material[] _holographicShaderMaterials;

    [ColorUsage(true, true)]
    [SerializeField] private Color _particleColour;

    [ColorUsage(true, true)]
    [SerializeField] private Color _shaderOutlineColour;

    // Start is called before the first frame update
    void Start()
    {
        var particle = _spawningParticleFX.main;
        particle.startColor = _particleColour;

        foreach (Material m in _holographicShaderMaterials)
        {
            m.SetColor("_GlowColour", _shaderOutlineColour);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
