using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishTalker : MonoBehaviour

{
    [SerializeField] private AnimationClip fishJump;
    [SerializeField] private Animator fishAnimator;
    private bool hasGrabbed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayFishJump());
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGrabbed){
            fishAnimator.SetBool("canFlop", true);
        }
    }

    IEnumerator PlayFishJump(){
        yield return new WaitForSeconds(10);
        fishAnimator.SetBool("canJump", true);
    }

    public void setHasGrabbed(){
        hasGrabbed = true;
    }
}
