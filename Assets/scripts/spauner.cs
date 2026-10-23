using UnityEngine;

public class spawner : MonoBehaviour
{

   public GameObject[] objects;
    public float rangeX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Create object every second
        InvokeRepeating(nameof(spawnerObject), 0,1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnerObject()
    {
        int index = UnityEngine.Random.Range(0, objects.Length);
        float randonX = UnityEngine.Random.Range(-rangeX, rangeX);

        Instantiate
            (objects[index],
            new Vector3(randonX, 0, 25),
            Quaternion.Euler(0, 180, 0)
            );
    }
}
