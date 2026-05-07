using UnityEngine;

public class boxScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
