using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthFillbar : MonoBehaviour
{
    public FloatReference Health;
    public FloatReference MaxHp;

    [SerializeField] private Image imageFill;

    void Update()
    {
        imageFill.fillAmount = Mathf.Clamp01(Health.Value / MaxHp.Value);
    }
}
