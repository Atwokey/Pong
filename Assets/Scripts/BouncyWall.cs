using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyWall : MonoBehaviour
{
    [SerializeField] private float _bouncyStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.TryGetComponent(out Ball ball))
        {
            Vector2 normal = collision.GetContact(0).normal;

            ball.AddForce(-normal * _bouncyStrength);
        }
    }
}
