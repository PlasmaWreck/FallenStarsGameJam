using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//hi
public class PushScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Box;
    public float speed = 6f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Box.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
