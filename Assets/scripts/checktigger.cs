using System.Runtime.CompilerServices;
using UnityEngine;

public class checktigger : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    { }

        private void OnTiggerEnter(Collider other)
        {
        if (other.CompareTag("Animal")) 
        { 
        }
            Destroy(other.gameObject);
            Destroy(gameObject);


        }
        
    }
