using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Teleport : MonoBehaviour
{
    private GameObject ball;
    public GameObject teleportexit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball"){
            ball = other.gameObject;
            other.gameObject.SetActive(false);
            StartCoroutine(WaitForTeleport());
        }
        
       
    }
     IEnumerator WaitForTeleport() {

            yield return new WaitForSeconds(1f);
            ball.transform.position = teleportexit.transform.position;
            ball.SetActive(true);


    }
}
