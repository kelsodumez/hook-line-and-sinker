using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Crank : MonoBehaviour
{
    public GameObject nodeMaster;
    public XRBaseController rightHand;
    public Quaternion originalRotationValue;
    public GameObject Spawner;
    public GameObject rope;
    public GameObject hook;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rope.GetComponent<RopeControllerSimple>().getMaxLength() <= 0f){
            int scoreToAdd = hook.GetComponent<Hook>().getFishieAmount();
            hook.GetComponent<Hook>().clearFishies();
            gameManager.GetComponent<GameManager>().increaseScore(scoreToAdd);
            scoreToAdd = 0;

            rope.GetComponent<RopeControllerSimple>().SetMaxLength(1f);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Node"){
        if (Spawner.GetComponent<BeatSpawner>().IsInTime()){
            
            nodeMaster.GetComponent<NodeMaster>().NodeEntered(other.gameObject);
            rightHand.SendHapticImpulse(0.2f,0.1f);

            float currentMax = rope.GetComponent<RopeControllerSimple>().getMaxLength();
            rope.GetComponent<RopeControllerSimple>().SetMaxLength(currentMax - 0.25f);

            } else {
                rightHand.SendHapticImpulse(1f, 0.25f);
            }
        }    
    }

    public void ResetRotation(){
        transform.rotation = originalRotationValue;
    }
}
