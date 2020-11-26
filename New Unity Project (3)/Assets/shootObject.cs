using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootObject : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody instBulletRigitBody = instBullet.GetComponent<Rigidbody>();
            instBulletRigitBody.AddForce(transform.right * speed, ForceMode.Impulse);
        }
    }
}
