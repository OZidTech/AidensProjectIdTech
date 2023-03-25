using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void MoveForward(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void MoveBack(float speed)
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    public void RotateLeft(float speed)
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
    public void RotateRight(float speed)
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    public void Fire(GameObject bulletPrefab)
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
