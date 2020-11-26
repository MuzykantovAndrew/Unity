using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    public GameObject target; //cant't be bothered to do any commments
    public float moveSpeed;
    public float rotationSpeed = 3;
    public float range = 100f;
    public float range2 = 120f;
    public float stop = 10f;
    public GameObject bullet;
    public float speed = 50f;
    public bool isFire = false;

    public void Awake()
    {

    }

    void Start()
    {
        target = GameObject.FindWithTag("Player");
        StartCoroutine(Fire());
    }

    void Update()
    {
        //rotate to look at the player
        //var distance = Vector3.Distance(transform.position, target.position);
        //if (distance < range2 && distance > range)
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation,
        //    Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
        //}


        //else if (distance < range && distance > stop)
        //{

        //    //move towards the player
        //    transform.rotation = Quaternion.Slerp(transform.rotation,
        //    Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
        //    transform.position += transform.forward * moveSpeed * Time.deltaTime;
        //}
        //else if (distance < stop)
        //{
        //    transform.position += target.position - Vector3.back;
        //}
        var distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < 20f && distance > 3f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);
            isFire = true;
        }
        else if (distance < 2f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, -moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);
        }
        else
        {
            isFire = false;
        }
    }
     
    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (isFire)
            {
                GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                Rigidbody instBulletRigitBody = instBullet.GetComponent<Rigidbody>();
                instBulletRigitBody.AddForce(transform.forward * speed, ForceMode.Impulse);
            }
        }
    }
}


