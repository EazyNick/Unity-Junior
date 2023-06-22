using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveforward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //앞으로 speed값만큼 이동
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
