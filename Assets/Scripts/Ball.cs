using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 _randomBetweenConstants;
    [SerializeField] private float _force;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float offSetX = 0;
        while (offSetX == 0)
            offSetX = Mathf.Round(Random.Range(_randomBetweenConstants.x, _randomBetweenConstants.y));

        var direction = new Vector2(offSetX, 0);
        AddForce(direction * _force);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Force);
    }
}
