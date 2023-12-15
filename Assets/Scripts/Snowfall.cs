using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowfall : MonoBehaviour
{
    public float startValueY = 20;
    public float endValueY = 20;


    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.2f, 0.2f, 0.2f);

        if(transform.position.y < endValueY){
            
            Vector3 startPos = Vector3.zero;
            startPos.y = startValueY + Random.Range(0,30);
            startPos.x = Random.Range(-10, 10);
            transform.position = startPos;
            rb.velocity = Vector3.zero;
            

        }
    }
}
