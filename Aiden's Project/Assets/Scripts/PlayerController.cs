using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent onMoveForward;
    public UnityEvent onMoveBack;
    public UnityEvent onRotateLeft;
    public UnityEvent onRotateRight;
    public UnityEvent onFire;

    float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            onMoveForward.Invoke();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            onMoveBack.Invoke();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            onRotateLeft.Invoke();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            onRotateRight.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            onFire.Invoke();
        }
    }
}
