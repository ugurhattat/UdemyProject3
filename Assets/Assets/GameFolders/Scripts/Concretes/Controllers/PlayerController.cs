using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Inputs;
using UdemyProject3.Abstracts.Movements;
using UdemyProject3.Inputs;
using UdemyProject3.Movements;
using UnityEngine;

namespace UdemyProject3.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        IPlayerInput _input;
        IMover _mover;

        float _horizontal;

        private void Awake()
        {
            _input = new PcInput();
            _mover = new Mover(this);
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;
        }

        private void FixedUpdate()
        {
            _mover.Tick(_horizontal);
        }
    }
}

