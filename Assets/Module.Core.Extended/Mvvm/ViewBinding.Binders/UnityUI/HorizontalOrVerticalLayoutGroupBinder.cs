#if UNITY_UGUI

using System;
using Module.Core.Extended.Mvvm.ViewBinding.Unity;
using Module.Core.Mvvm.ViewBinding;
using UnityEngine;
using UnityEngine.UI;

namespace Module.Core.Extended.Mvvm.ViewBinding.Binders.UnityUI
{
    [Serializable]
    [Label("Horizontal Or Vertical Layout Group", "UI")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBinder : MonoBinder<HorizontalOrVerticalLayoutGroup>
    {
    }

    [Serializable]
    [Label("Spacing", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingSpacing : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetSpacing(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].spacing = value;
            }
        }
    }

    [Serializable]
    [Label("Child Alignment", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingChildAlignment : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetChildAlignment(TextAnchor value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childAlignment = value;
            }
        }
    }

    [Serializable]
    [Label("Reverse Arrangement", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingReverseArrangement : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetReverseArrangement(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].reverseArrangement = value;
            }
        }
    }

    [Serializable]
    [Label("Control Child Width", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingControlChildWidth : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetControlChildWidth(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childControlWidth = value;
            }
        }
    }

    [Serializable]
    [Label("Control Child Height", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingControlChildHeight : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetControlChildHeight(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childControlHeight = value;
            }
        }
    }

    [Serializable]
    [Label("Use Child Scale Width", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingUseChildScaleWidth : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetUseChildScaleWidth(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childScaleWidth = value;
            }
        }
    }

    [Serializable]
    [Label("Use Child Scale Height", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingUseChildScaleHeight : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetUseChildScaleHeight(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childScaleHeight = value;
            }
        }
    }

    [Serializable]
    [Label("Child Force Expand Width", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingChildForceExpandWidth : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetChildForceExpandWidth(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childForceExpandWidth = value;
            }
        }
    }

    [Serializable]
    [Label("Child Force Expand Height", "Horizontal Or Vertical Layout Group")]
    public sealed partial class HorizontalOrVerticalLayoutGroupBindingChildForceExpandHeight : MonoPropertyBinding<HorizontalOrVerticalLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetChildForceExpandHeight(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].childForceExpandHeight = value;
            }
        }
    }
}

#endif
