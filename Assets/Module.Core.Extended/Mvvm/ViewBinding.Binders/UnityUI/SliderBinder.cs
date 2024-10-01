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
    [Label("Slider", "UI")]
    public sealed partial class SliderBinder : MonoBinder<Slider>
    {
    }

    [Serializable]
    [Label("Value", "Slider")]
    public sealed partial class SliderBindingValue : MonoPropertyBinding<Slider>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetValue(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].SetValueWithoutNotify(value);
            }
        }
    }

    [Serializable]
    [Label("Interactable", "Slider")]
    public sealed partial class SliderBindingInteractable : MonoPropertyBinding<Slider>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetInteractable(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].interactable = value;
            }
        }
    }

    [Serializable]
    [Label("On Value Changed", "Slider")]
    public sealed partial class SliderBindingOnValueChanged : MonoCommandBinding<Slider>, IBinder
    {
        private readonly UnityAction<float> _command;

        public SliderBindingOnValueChanged()
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
        partial void OnValueChanged(float value);
    }

    [Serializable]
    [Label("Min Value", "Slider")]
    public sealed partial class SliderBindingMinValue : MonoPropertyBinding<Slider>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMinValue(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].minValue = value;
            }
        }
    }
    
    [Serializable]
    [Label("Max Value", "Slider")]
    public sealed partial class SliderBindingMaxValue : MonoPropertyBinding<Slider>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaxValue(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].maxValue = value;
            }
        }
    }

    [Serializable]
    [Label("Whole Numbers", "Slider")]
    public sealed partial class SliderBindingWholeNumbers : MonoPropertyBinding<Slider>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetWholeNumbers(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].wholeNumbers = value;
            }
        }
    }
}

#endif
