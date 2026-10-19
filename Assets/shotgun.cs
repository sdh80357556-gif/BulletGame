using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Diagnostics;

public class Shotgun : MonoBehaviour
{
   private Rigidbody rb;
   private float speed = 8f;
    private float spawnTime;
    private void Start()
    {

        spawnTime = Time.time;
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward*speed;

    }
      
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playercuntrou playerController = other.GetComponent<playercuntrou>();
            playerController.OnDie();
       
        }
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        float survived = Time.time - spawnTime;

        
    }
}
   
      
       
           
    

