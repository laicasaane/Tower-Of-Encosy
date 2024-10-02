#if UNITY_UGUI

using System;
using Module.Core.Extended.Mvvm.ViewBinding.Unity;
using Module.Core.Mvvm.ViewBinding;
using UnityEngine;
using UnityEngine.UI;

namespace Module.Core.Extended.Mvvm.ViewBinding.Binders.UnityUI
{
    [Serializable]
    [Label("Raw Image", "UI")]
    public sealed partial class RawImageBinder : MonoBinder<RawImage>
    {
    }

    [Serializable]
    [Label("Color", "Raw Image")]
    public sealed partial class RawImageBindingColor : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetColor(Color value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].color = value;
            }
        }
    }

    [Serializable]
    [Label("Texture", "Raw Image")]
    public sealed partial class RawImageBindingTexture : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetTexture(Texture value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].texture = value;
            }
        }
    }

    [Serializable]
    [Label("Texture (Native Size)", "Raw Image")]
    public sealed partial class RawImageBindingTextureNativeSize : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetTextureNativeSize(Texture value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                var target = targets[i];
                target.texture = value;
                target.SetNativeSize();
            }
        }
    }

    [Serializable]
    [Label("Material", "Raw Image")]
    public sealed partial class RawImageBindingMaterial : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaterial(Material value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].material = value;
            }
        }
    }

    [Serializable]
    [Label("Raycast Target", "Raw Image")]
    public sealed partial class RawImageBindingRaycastTarget : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetRaycastTarget(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].raycastTarget = value;
            }
        }
    }

    [Serializable]
    [Label("Maskable", "Raw Image")]
    public sealed partial class RawImageBindingMaskable : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaskable(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].maskable = value;
            }
        }
    }

    [Serializable]
    [Label("UV Rect", "Raw Image")]
    public sealed partial class RawImageBindingUVRect : MonoPropertyBinding<RawImage>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetUVRect(Rect value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].uvRect = value;
            }
        }
    }
}

#endif
