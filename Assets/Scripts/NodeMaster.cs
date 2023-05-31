using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMaster : MonoBehaviour
{
    [SerializeField] private GameObject following;
    [SerializeField] private List<GameObject> nodes;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update(){
        
    }

    // Late Update is called once per frame, after update
    void LateUpdate()
    {
        Vector3 followingPosition = following.transform.position;
        followingPosition.x = -1.4f;
        transform.position = Vector3.MoveTowards(transform.position, followingPosition, 1);

    }

    public void NodeEntered(GameObject node){
        if (nodes.Contains(node)){
            int nodeIndex = nodes.IndexOf(node)+1;
            if ((nodeIndex) > 3 ){
                nodeIndex = 0;
            }
            nodes[nodeIndex].SetActive(true);
            node.SetActive(false);
        }

    }
}
