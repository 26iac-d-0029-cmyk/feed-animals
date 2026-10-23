using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed;
    public float rangex;
    public GameObject foodPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //move player
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);


        //limit movement range
        if (transform.position.x > rangex)
        {
            transform.position =
                new Vector3(rangex, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -rangex)
        {
            transform.position =
                new Vector3(-rangex, transform.position.y, transform.position.z);

            //Throw food
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(foodPrefab, transform.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            Debug.Log("Game over");
        }
    }
}