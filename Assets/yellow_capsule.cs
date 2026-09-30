using UnityEngine;

public class yellow_capsule : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(2, 0, 0);
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Loop: " + (i + 1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
