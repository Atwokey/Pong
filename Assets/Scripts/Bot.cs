using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _speed;

    private void Update()
    {
        if (transform.position.y > 3.5f)
            transform.position = new Vector2(transform.position.x, 3.5f);
        if (transform.position.y < -3.6f)
            transform.position = new Vector2(transform.position.x, -3.6f);

        if (_ball.transform.position.x > 0 && _ball.transform.position.x < transform.position.x)
        {
            var target = new Vector3(transform.position.x, _ball.transform.position.y, 0);
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
        }
    }
}
