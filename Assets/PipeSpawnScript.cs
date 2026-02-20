using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
           timer += Time.deltaTime;
        }
        else
        {
            
            timer = 0f;
            SpawnPipe();
        }
        
    }
    void SpawnPipe()
    {

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-1, 5), 0), transform.rotation);
        
    }
}
