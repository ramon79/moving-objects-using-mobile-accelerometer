using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float temp = Input.acceleration.x;
        float z = Input.acceleration.z;
        Debug.Log(temp);
        transform.Translate(0, 0, - z * speed * Time.deltaTime);
        transform.Rotate(0, 0, -temp * speed);
        
        

        
    }
}
