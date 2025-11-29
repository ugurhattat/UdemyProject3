using System.Collections;
using System.Collections.Generic;
using UdemyProject3.Abstracts.Animations;
using UdemyProject3.Controllers;
using UnityEngine;

namespace UdemyProject3.Animations
{
    public class CharacterAnimation : IMyAnimation
    {
        Animator _animator;

        public CharacterAnimation(Animator animator)
        {
            _animator = animator;
        }

        public void MoveAnimation(float moveSpeed)
        {
            _animator.SetFloat("moveSpeed", Mathf.Abs(moveSpeed));
        }
    }
}

