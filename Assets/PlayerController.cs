using UnityEngine;

public class playercuntrou : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Rigidbody rb;
    private Gamemeneger gamemeneger;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        GameObject findGo = GameObject.FindWithTag("GameController");
        gamemeneger = findGo.GetComponent<Gamemeneger>();
    }
    private void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        if (direction.magnitude > 1f)
        {
            direction.Normalize();
        }
        rb.linearVelocity = direction * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

    public void OnDie()
    {
        gameObject.SetActive(false);
        gamemeneger.EndGame();
    }
}
