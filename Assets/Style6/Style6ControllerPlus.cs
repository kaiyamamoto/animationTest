﻿using UnityEngine;
using System.Collections;

namespace AnimatorLikeAnimation.Style6
{
    public class Style6ControllerPlus : MonoBehaviour
    {
        int currentAnimation;
        [SerializeField] DynamicAnimator target;

        [SerializeField]
        string state;

        void Awake()
        {
            target.Setup();
        }

        public void PlayNextAnimation()
        {
            target.CrossFadeInFixedTime(state);
        }
    }
}