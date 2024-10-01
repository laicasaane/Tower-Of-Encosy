#if UNITY_TEXTMESHPRO

using System;
using Module.Core.Extended.Mvvm.ViewBinding.Unity;
using Module.Core.Mvvm.ViewBinding;
using TMPro;
using UnityEngine;

namespace Module.Core.Extended.Mvvm.ViewBinding.Binders.UnityUI.TextMeshPro
{
    [Serializable]
    [Label("TMP Text", "TextMeshPro")]
    public sealed partial class TMP_TextBinder : MonoBinder<TMP_Text>
    {
    }

    [Serializable]
    [Label("Text", "TMP Text")]
    public sealed partial class TMP_TextBindingText : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetText(string value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].text = value;
            }
        }
    }

    [Serializable]
    [Label("Color", "TMP Text")]
    public sealed partial class TMP_TextBindingColor : MonoPropertyBinding<TMP_Text>, IBinder
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
    [Label("Color Gradient", "TMP Text")]
    public sealed partial class TMP_TextBindingColorGradient : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetColorGradient(VertexGradient value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].colorGradient = value;
            }
        }
    }

    [Serializable]
    [Label("Max Visible Characters", "TMP Text")]
    public sealed partial class TMP_TextBindingMaxVisibleCharacters : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaxVisibleCharacters(int value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].maxVisibleCharacters = value;
            }
        }
    }

    [Serializable]
    [Label("Max Visible Words", "TMP Text")]
    public sealed partial class TMP_TextBindingMaxVisibleWords : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaxVisibleWords(int value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].maxVisibleWords = value;
            }
        }
    }

    [Serializable]
    [Label("Max Visible Lines", "TMP Text")]
    public sealed partial class TMP_TextBindingMaxVisibleLines : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetMaxVisibleLines(int value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].maxVisibleLines = value;
            }
        }
    }

    [Serializable]
    [Label("Font Asset", "TMP Text")]
    public sealed partial class TMP_TextBindingFontAsset : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetFontAsset(TMP_FontAsset value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].font = value;
            }
        }
    }

    [Serializable]
    [Label("Font Size", "TMP Text")]
    public sealed partial class TMP_TextBindingFontSize : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetFontSize(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].fontSize = value;
            }
        }
    }

    [Serializable]
    [Label("Auto Sizing", "TMP Text")]
    public sealed partial class TMP_TextBindingAutoSizing : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetAutoSizing(bool value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].enableAutoSizing = value;
            }
        }
    }

    [Serializable]
    [Label("Font Size Min", "TMP Text")]
    public sealed partial class TMP_TextBindingFontSizeMin : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetFontSizeMin(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].fontSizeMin = value;
            }
        }
    }

    [Serializable]
    [Label("Font Size Max", "TMP Text")]
    public sealed partial class TMP_TextBindingFontSizeMax : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetFontSizeMax(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].fontSizeMax = value;
            }
        }
    }

    [Serializable]
    [Label("Raycast Target", "TMP Text")]
    public sealed partial class TMP_TextBindingRaycastTarget : MonoPropertyBinding<TMP_Text>, IBinder
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
    [Label("Maskable", "TMP Text")]
    public sealed partial class TMP_TextBindingMaskable : MonoPropertyBinding<TMP_Text>, IBinder
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
    [Label("Wrapping Mode", "TMP Text")]
    public sealed partial class TMP_TextBindingWrappingMode : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetWrappingMode(TextWrappingModes value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].textWrappingMode = value;
            }
        }
    }

    [Serializable]
    [Label("Overflow Mode", "TMP Text")]
    public sealed partial class TMP_TextBindingOverflowMode : MonoPropertyBinding<TMP_Text>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetOverflowMode(TextOverflowModes value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].overflowMode = value;
            }
        }
    }
}

#endif
