using UnityEngine;
using Microlight.MicroBar;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    //Animator animator;
    [SerializeField] private string sceneNameToLoad;
    const float MAX_HP = 125f;
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
        //health test
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            MageHP += 10;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            MageHP -= 10;
        }

        if (MageHP <= 0)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    //can optimize this (if have time)
    public void TakeDamage(int amount)
    {
        MageHP -= amount;
    }
}