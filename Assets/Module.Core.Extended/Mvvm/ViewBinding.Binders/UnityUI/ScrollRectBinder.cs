#if UNITY_UGUI

using System;
using Module.Core.Extended.Mvvm.ViewBinding.Unity;
using Module.Core.Mvvm.ViewBinding;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Module.Core.Extended.Mvvm.ViewBinding.Binders.UnityUI
{
    [Serializable]
    [Label("Scroll Rect", "UI")]
    public sealed partial class ScrollRectBinder : MonoBinder<ScrollRect>
    {
    }

    [Serializable]
    [Label("On Value Changed", "Scroll Rect")]
    public sealed partial class ScrollRectBindingOnValueChanged : MonoCommandBinding<ScrollRect>, IBinder
    {
        private readonly UnityAction<Vector2> _command;

        public ScrollRectBindingOnValueChanged()
        {
            _command = OnValueChanged;
        }

        protected override void OnBeforeSetTargets()
        {
            var targets = Targets;
            var length = targets.Length;
            var command = _command;

            for (var i = 0; i < length; i++)
            {
                targets[i].onValueChanged.RemoveListener(command);
            }
        }

        protected override void OnAfterSetTargets()
        {
            var targets = Targets;
            var length = targets.Length;
            var command = _command;

            for (var i = 0; i < length; i++)
            {
                targets[i].onValueChanged.AddListener(command);
            }
        }

        [BindingCommand]
        [field: HideInInspector]
        partial void OnValueChanged(Vector2 value);
    }

    [Serializable]
    [Label("Elasticity", "Scroll Rect")]
    public sealed partial class ScrollRectBindingElasticity : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetElasticity(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].elasticity = value;
            }
        }
    }

    [Serializable]
    [Label("Inertia", "Scroll Rect")]
    public sealed partial class ScrollRectBindingInertia : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetInertia(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].inertia = value;
            }
        }
    }

    [Serializable]
    [Label("Deceleration Rate", "Scroll Rect")]
    public sealed partial class ScrollRectBindingDecelerationRate : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetDecelerationRate(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].decelerationRate = value;
            }
        }
    }

    [Serializable]
    [Label("Scroll Sensitivity", "Scroll Rect")]
    public sealed partial class ScrollRectBindingScrollSensitivity : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetScrollSensitivity(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].scrollSensitivity = value;
            }
        }
    }

    [Serializable]
    [Label("Movement Type", "Scroll Rect")]
    public sealed partial class ScrollRectBindingMovementType : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMovementType(ScrollRect.MovementType value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].movementType = value;
            }
        }
    }

    [Serializable]
    [Label("Vertical", "Scroll Rect")]
    public sealed partial class ScrollRectBindingVertical : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetVertical(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].vertical = value;
            }
        }
    }

    [Serializable]
    [Label("Vertical Scrollbar Visibility", "Scroll Rect")]
    public sealed partial class ScrollRectBindingVerticalScrollbarVisibility : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetVerticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].verticalScrollbarVisibility = value;
            }
        }
    }

    [Serializable]
    [Label("Vertical Normalized Position", "Scroll Rect")]
    public sealed partial class ScrollRectBindingVerticalNormalizedPosition : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetVerticalNormalizedPosition(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].verticalNormalizedPosition = value;
            }
        }
    }

    [Serializable]
    [Label("Horizontal", "Scroll Rect")]
    public sealed partial class ScrollRectBindingHorizontal : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetHorizontal(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].horizontal = value;
            }
        }
    }

    [Serializable]
    [Label("Horizontal Scrollbar Visibility", "Scroll Rect")]
    public sealed partial class ScrollRectBindingHorizontalScrollbarVisibility : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetHorizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].horizontalScrollbarVisibility = value;
            }
        }
    }

    [Serializable]
    [Label("Horizontal Normalized Position", "Scroll Rect")]
    public sealed partial class ScrollRectBindingHorizontalNormalizedPosition : MonoPropertyBinding<ScrollRect>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetHorizontalNormalizedPosition(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].horizontalNormalizedPosition = value;
            }
        }
    }
}

#endif
