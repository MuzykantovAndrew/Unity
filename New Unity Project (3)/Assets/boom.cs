using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject prefab = Resources.Load("explode") as GameObject;
        GameObject fire = Instantiate(prefab) as GameObject;
        fire.transform.position = transform.position;
        FindObjectOfType<AudioSource>().Play();
        Destroy(gameObject);
    }
}
