using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Input = UnityEngine.Windows.Input;

public class Headlight : MonoBehaviour
{
    [SerializeField] private GameObject light;
    [SerializeField] private Image energyBar;
    [SerializeField] private float maxEnergy = 250f;
    [SerializeField] private float energyDrain = 1f;
    private float _energy = 0f;

    private void Awake()
    {
        light.SetActive(false);
        _energy = maxEnergy;
    }

    private void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame && _energy >= 0f)
        {
            light.SetActive(!light.activeSelf);
        }

        if (light.activeSelf)
        {
            _energy -= Time.deltaTime * energyDrain;
        }

        energyBar.fillAmount = _energy / maxEnergy;
    }
}
