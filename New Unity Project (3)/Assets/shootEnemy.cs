using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootEnemy : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < 10f && distance > 3f)
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody instBulletRigitBody = instBullet.GetComponent<Rigidbody>();
            instBulletRigitBody.AddForce(transform.forward * speed, ForceMode.Impulse);
            
        }
    }
}
