using UnityEngine;

public class Player_Run : MonoBehaviour
{
    public InputActionAsset TestplayerActionAsset
    public Animator testAnimator;
    
    // Update is called once per frame
    void Update()
    {
        if (testPlayerAction.FindAction("Move").IsPressed())
            
            testAnimator.SetBool(name:"Run", true);
        else
            testAnimatorSetBool(name:"Run", false);
        }
        
    }
}
