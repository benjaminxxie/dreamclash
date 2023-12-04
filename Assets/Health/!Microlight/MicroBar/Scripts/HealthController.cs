using UnityEngine;
using Microlight.MicroBar;

public class HealthController : MonoBehaviour
{
    const float MAX_HP = 100f;
    float _mageHP;
    float MageHP {
        get => _mageHP;
        set {
            _mageHP = value;
            _mageHPBar.UpdateHealthBar(_mageHP);
        }
    }

    [SerializeField] MicroBar _mageHPBar;
    
    // Start is called before the first frame update
    void Start()
    {
        _mageHPBar.Initialize(MAX_HP);

        MageHP = MAX_HP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            MageHP += 10;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            MageHP -= 10;
        }
    }
}