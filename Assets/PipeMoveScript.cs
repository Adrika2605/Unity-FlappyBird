using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float deadZone = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
