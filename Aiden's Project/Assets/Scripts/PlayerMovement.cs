using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveForward(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
