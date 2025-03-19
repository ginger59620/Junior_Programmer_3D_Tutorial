using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectControllerProjTwo : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }
}
