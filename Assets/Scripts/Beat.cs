using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    [SerializeField]private float speed = 2.0f;
    public float beatDelayAfter;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * target * speed;
    }

    public void SetSpeed(float amount){
        speed = amount;
    }

    public void SetTarget(Vector3 newTarget){
        target = newTarget;
    }
}
