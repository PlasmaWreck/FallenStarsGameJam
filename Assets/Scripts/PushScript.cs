using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//hi
public class PushScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Box;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Box.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
