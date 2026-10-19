using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Diagnostics;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 8f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;

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
}






