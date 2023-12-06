using UnityEngine;
using Microlight.MicroBar;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    //Animator animator;
    [SerializeField] private string sceneNameToLoad;
    const float MAX_HP = 100f;
    float _mageHP;
    float MageHP {
        get => _mageHP;
        set {
            _mageHP = value;
            _mageHPBar.UpdateHealthBar(_mageHP);
        }
    }

    float _slimeHP;
    float SlimeHP {
        get => _slimeHP;
        set {
            _slimeHP = value;
            _slimeHPBar.UpdateHealthBar(_slimeHP);
        }
    }

    float _turtleHP;
    float TurtleHP {
        get => _turtleHP;
        set {
            _turtleHP = value;
            _turtleHPBar.UpdateHealthBar(_turtleHP);
        }
    }

    [SerializeField] MicroBar _mageHPBar;
    [SerializeField] MicroBar _slimeHPBar;
    [SerializeField] MicroBar _turtleHPBar;
    
    // Start is called before the first frame update
    void Start()
    {
        _mageHPBar.Initialize(MAX_HP);
        MageHP = MAX_HP;

        _slimeHPBar.Initialize(MAX_HP);
        SlimeHP = MAX_HP;

        _turtleHPBar.Initialize(MAX_HP);
        TurtleHP = MAX_HP;

        //animator = GetComponent<Animator>();
        //isDeadHash = Animator.StringToHash("isDead");
        //isAttackingHash = Animator.StringToHash("isAttacking");
    }

    // Update is called once per frame
    void Update()
    {
        //health test
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            MageHP += 10;
            SlimeHP += 10;
            TurtleHP += 10;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            MageHP -= 10;
            SlimeHP -= 10;
            TurtleHP -= 10;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            MageHP -= 20;
        }

        //death and attack animations
        //    bool isDead = animator.GetBool(isDeadHash);
        //    bool isAttacking = animator.GetBool(isAttackingHash);

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

    public void SlimeDamage(int amount)
    {
        SlimeHP -= amount;
    }

    public void TurtleDamage(int amount)
    {
        TurtleHP -= amount;
    }
}