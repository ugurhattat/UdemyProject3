using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Movements;
using UdemyProject3.Controllers;
using UnityEngine;

namespace UdemyProject3.Movements
{
    public class Mover : IMover
    {
        PlayerController _playerController;
        float moveSpeed = 3f;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void Tick(float horizontal)
        {
            if (horizontal == 0f) return;

            _playerController.transform.Translate(Vector2.right * horizontal * Time.deltaTime * moveSpeed);
        }
    }
}

