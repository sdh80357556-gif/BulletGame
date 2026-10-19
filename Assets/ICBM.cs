using UnityEngine;

public class ICBM : MonoBehaviour
{
    public float followingSpeed = 50f;
    private Transform target;
    private Rigidbody rb;
    private float speed = 5f;
    private float spawnTime;


    private void Start()
    {
        spawnTime = Time.time;

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
    void Update()
    {
        float survived = Time.time - spawnTime;


        if (survived > 3f)
        {
            Destroy(gameObject);
        }

        GameObject findGo = GameObject.FindWithTag("Player");
        if (findGo != null)
        {
            target = findGo.transform;
        }

        Debug.Log(target.position);

        Vector3 position = transform.position;
        Vector3 direction = target.position - position;
        direction.Normalize();
        Quaternion rotation = Quaternion.LookRotation(direction);
        Debug.Log($"현재 적용된 회전값: {transform.rotation}");
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * followingSpeed);
        rb.linearVelocity = transform.forward * speed;
    }

}