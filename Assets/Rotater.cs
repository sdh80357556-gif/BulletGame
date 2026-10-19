using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public float rotSpeed = 360f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0f, rotSpeed * Time.deltaTime, 0f);
    }
}
