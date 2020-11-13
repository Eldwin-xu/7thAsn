using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    int isJumpingHash;
    int isRunJumpingHash;

    // Start is called before the first frame update
    void Start()
    {
        isRunningHash = Animator.StringToHash("IsRunning");
        isJumpingHash = Animator.StringToHash("IsJumping");
        isRunJumpingHash = Animator.StringToHash("IsRunJumping");
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool IsRunJumping = animator.GetBool(isRunJumpingHash);
        bool IsRunning = animator.GetBool(isRunningHash);
        bool wPressed = Input.GetKey("w");
        bool IsJumping = animator.GetBool(isJumpingHash);
        bool spacePressed = Input.GetKeyDown("space");
        if (!IsRunning && wPressed){
            animator.SetBool(isRunningHash, true);
        }
        if (IsRunning && !wPressed)
        {
            animator.SetBool(isRunningHash, false);
        }
        if (!IsJumping && spacePressed)
        {
            Debug.Log("space");
            animator.SetBool(isJumpingHash, true);
        }
        if (IsJumping && !spacePressed)
        {
            animator.SetBool(isJumpingHash, false);
        }
        if (IsRunning && spacePressed)
        {
            animator.SetBool(isRunJumpingHash, true);
        }
        if (!IsRunning && !spacePressed)
        {
            animator.SetBool(isRunJumpingHash, false);
        }
        if (wPressed && !spacePressed)
        {
            animator.SetBool(isRunJumpingHash, false);
            animator.SetBool(isRunningHash, true);
        }
        if (!wPressed && !spacePressed)
        {
            animator.SetBool(isRunningHash, false);
            animator.SetBool(isJumpingHash, false);
            animator.SetBool(isRunJumpingHash, false);
        }
    }
}
