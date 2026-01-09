using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationShift : MonoBehaviour
{
    public InputActionAsset PlayerImputAction;
    public Animator PlayerAnimator;
   

    // Update is called once per frame
    void Update()
    {
        if (PlayerImputAction.FindAction("Move").IsPressed())
        {
            PlayerAnimator.SetBool("Move", true);
        }
        else
        {
            PlayerAnimator.SetBool("Move", false);
        }
    }
}
