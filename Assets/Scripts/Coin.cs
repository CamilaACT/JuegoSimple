using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed = 90f;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        //validar que cuando se choca sea el jugador 
        if (other.gameObject.name != "Player")
        {
            return;

        }
        
        GameManager.inst.IncrementScore();
        
        
        

        Destroy(gameObject);
    }
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}