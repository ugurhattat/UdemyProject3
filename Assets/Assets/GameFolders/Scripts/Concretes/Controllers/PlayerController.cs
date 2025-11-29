using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Animations;
using UdemyProject3.Abstracts.Controllers;
using UdemyProject3.Abstracts.Inputs;
using UdemyProject3.Abstracts.Movements;
using UdemyProject3.Animations;
using UdemyProject3.Inputs;
using UdemyProject3.Movements;
using UnityEngine;

namespace UdemyProject3.Controllers
{
    public class PlayerController : MonoBehaviour, IEntityController
    {
        IPlayerInput _input;
        IMover _mover;
        IMyAnimation _animation;
        IFlip _flip;

        float _horizontal;
        bool _isRunning;

        private void Awake()
        {
            _input = new PcInput();
            _mover = new MoverWithTranslate(this);
            _animation = new CharacterAnimation(GetComponent<Animator>());
            _flip = new FlipWithTransform(this);
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;
            _isRunning = _input.IsRunning;

            float speedParam = Mathf.Abs(_horizontal);

            if (!_isRunning)
            {
                speedParam = Mathf.Clamp(speedParam, 0f, 0.2f);
            }
            else
            {

            }

                _animation.MoveAnimation(speedParam);
        }

        private void FixedUpdate()
        {
            _flip.FlipCharacter(_horizontal);
            float speedMultiplier = _isRunning ? 1.5f : 1f;
            _mover.Tick(_horizontal * speedMultiplier);
        }
    }
}

