using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
