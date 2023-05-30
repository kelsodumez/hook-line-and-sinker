using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crank : MonoBehaviour
{
    public GameObject nodeMaster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("collision");
        if(other.gameObject.tag == "Node"){
            Debug.Log("HIT");
            nodeMaster.GetComponent<NodeMaster>().NodeEntered(other.gameObject);
        }    
    }
}
