using UnityEngine;

public class food : MonoBehaviour

   
{


    public float speed;
    public float rangeX;
    //public GameObject foodPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //move player
        transform.Translate(Vector3.right * horizontalInput, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *  speed *Time.deltaTime);
        
    }
}
