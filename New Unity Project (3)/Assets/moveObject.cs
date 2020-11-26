using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.right * Input.GetAxis("Vertical");
        transform.RotateAround(gameObject.transform.position, transform.up, Input.GetAxis("Horizontal") * 10 * Time.deltaTime);
    }
}
