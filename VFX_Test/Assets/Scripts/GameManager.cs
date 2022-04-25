using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int DEFAULT_PARTICLE_RATE = 500;

    [Header("Camera Settings")]
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private bool _shouldRotateCamera;
    [SerializeField] [Range(0.05f, 0.15f)] private float _cameraRotateSpeed;

    [Header("UI Settings")]
    [SerializeField] private Slider _camSpeedSlider;
    [SerializeField] private Toggle _camRotateToggle;
    [SerializeField] private Dropdown _vfxDegDropdown;
    [SerializeField] private Slider _vfxParticleRateSlider;
    [SerializeField] private GameObject[] _uiObjects;

    [Header("Customisation Data")]
    [SerializeField] [ColorUsage(true, true)] private Color[] _shaderColours;
    [SerializeField] [ColorUsage(true, true)] private Color[] _particleColours;
    [SerializeField] private GameObject[] _displayObjects;

    [Header("VFX Data")]
    [SerializeField] private VisualEffectController[] _vfxControllers;

    void Update()
    {
        if (_shouldRotateCamera)
        {
            _cameraTransform.Rotate(0, _cameraRotateSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject go in _uiObjects)
            {
                go.SetActive(!go.activeInHierarchy);
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (GameObject go in _displayObjects)
            {
                go.SetActive(!go.activeInHierarchy);
            }
        }
    }

    public void ToggleCameraRotate()
    {
        _shouldRotateCamera = !_shouldRotateCamera;
    }

    public void SetCameraSpeed()
    {
        _cameraRotateSpeed = _camSpeedSlider.value;
    }

    public void ResetToDefaultCamera()
    {
        _cameraRotateSpeed = _camSpeedSlider.minValue;       
        _camRotateToggle.isOn = false;
        _shouldRotateCamera = false;
        _cameraTransform.rotation = Quaternion.Euler(Vector3.zero);
    }

    public void SetVfxDeg()
    {
        if (_vfxDegDropdown.value == 1)
        {
            foreach (VisualEffectController vfx in _vfxControllers)
            {
                vfx.Rotation = VisualEffectController.Degree.NinetyDegrees;
            }
        }
        else
        {
            foreach (VisualEffectController vfx in _vfxControllers)
            {
                vfx.Rotation = VisualEffectController.Degree.ZeroDegrees;
            }
        }
    }

    public void SetVfxColour()
    {
        var rand = Random.Range(0, _shaderColours.Length);
        foreach (VisualEffectController vfx in _vfxControllers)
        {
            vfx.ParticleColour = _particleColours[rand];
            vfx.ShaderColour = _shaderColours[rand];
        }
    }

    public void SetVfxParticleRate()
    {
        foreach (VisualEffectController vfx in _vfxControllers)
        {           
            vfx._particleRate = Mathf.RoundToInt(_vfxParticleRateSlider.value);
        }
    }

    public void ResetToDefaultCustomisation()
    {
        foreach (VisualEffectController vfx in _vfxControllers)
        {
            vfx.ParticleColour = _particleColours[0];
            vfx.ShaderColour = _shaderColours[0];
            vfx.Rotation = VisualEffectController.Degree.ZeroDegrees;
            vfx._particleRate = DEFAULT_PARTICLE_RATE;
        }
    }
}
