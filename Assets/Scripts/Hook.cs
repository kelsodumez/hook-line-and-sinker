using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private List<GameObject> fishies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Fish"){
            other.GetComponent<FixedJoint>().connectedBody = rb;
            other.GetComponent<Rigidbody>().isKinematic = false;
            other.GetComponent<Beat>().SetSpeed(0f);
            other.GetComponent<Beat>().SetTarget(transform.up);
            fishies.Add(other.gameObject);
        }
    }

    public int getFishieAmount(){
        return fishies.Count;
    }

    public void clearFishies(){
        foreach (GameObject fish in fishies){
            Object.Destroy(fish);
        }
        fishies.Clear();
    }
}
