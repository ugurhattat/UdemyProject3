using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Movements;
using UdemyProject3.Controllers;
using UnityEngine;

namespace UdemyProject3.Movements
{
    public class MoverWithTranslate : IMover
    {
        PlayerController _playerController;
        float moveSpeed = 3f;
        public MoverWithTranslate(PlayerController playerController)
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

