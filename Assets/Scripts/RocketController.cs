using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        if (transform.position.y > 3.5f)
            transform.position = new Vector2(transform.position.x, 3.5f);
        if (transform.position.y < -3.6f)
            transform.position = new Vector2(transform.position.x, -3.6f);

        var direction = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, direction * _speed * Time.deltaTime, 0));
    }
}
