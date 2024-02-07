using UnityEngine;

[CreateAssetMenu(menuName = "Variaveis/Float", fileName = "Float_SO")]
public class FloatVariable : ScriptableObject
{
    public float Value;  

    public void SetValue(float value)
    {
        Value = value;
    }

    public void SetValue(FloatVariable value)
    {
        Value = value.Value;
    }

    public void ChangeValue(float value)
    {
        Value += value;
    }

    public void ChangeValue(FloatVariable value)
    {
        Value += value.Value;
    }
}
