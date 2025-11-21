using UnityEngine;


public class PlayerAnim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator PlayerAnimator;
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>(); // Ger access till Animatorn du skapat
        PlayerAnimator.SetBool("Run", false);
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            PlayerAnimator.SetBool("Run", true);
        }
        if(Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            PlayerAnimator.SetBool("Run", false);
        }
    }
}
