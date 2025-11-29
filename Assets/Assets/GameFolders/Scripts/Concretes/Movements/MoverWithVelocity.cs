using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Movements;
using UdemyProject3.Controllers;
using UnityEngine;

namespace UdemyProject3.Movements
{
    public class MoverWithVelocity : IMover
    {
        Rigidbody2D _rigidbody2D;

        float _moveSpeed = 3f;

        public MoverWithVelocity(PlayerController playerController)
        {
            _rigidbody2D = playerController.GetComponent<Rigidbody2D>();    
        }
        public void Tick(float horizontal)
        {
            //if (_rigidbody2D.velocity.magnitude >= 5f) return;

            Vector2 velocity = _rigidbody2D.velocity;
            velocity.x = horizontal * _moveSpeed;

            _rigidbody2D.velocity = velocity;
        }
    }
}

