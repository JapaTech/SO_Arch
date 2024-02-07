using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private FloatVariable HP;
    [SerializeField] private FloatReference MaxHP;

    void Start()
    {
        ResetHP();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10f);
        }    
    }

    private void ResetHP()
    {
        HP.SetValue(MaxHP);
    }

    private void TakeDamage(float damage)
    {
        if(HP.Value > 0)
        {
            HP.ChangeValue(-damage);
        }
        else
        {
            HP.SetValue(0);
        }
    }
}
