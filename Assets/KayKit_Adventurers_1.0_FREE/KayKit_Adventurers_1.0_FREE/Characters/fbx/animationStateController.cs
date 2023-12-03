using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool WASDPressed = (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"));
        bool shiftPressed = Input.GetKey("left shift");

        //sets isRunning to true if not walking and WASD is pressed
        if (!isWalking && WASDPressed){
            animator.SetBool(isWalkingHash, true);
        }
        //sets isRunning to false if walking and WASD is not pressed
        if (isWalking && !WASDPressed){
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (shiftPressed && WASDPressed)){
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && !(shiftPressed && WASDPressed)){
            animator.SetBool(isRunningHash, false);
        }
    }
}
