#if UNITY_UGUI

using System;
using Module.Core.Extended.Mvvm.ViewBinding.Unity;
using Module.Core.Mvvm.ViewBinding;
using UnityEngine;
using UnityEngine.UI;

namespace Module.Core.Extended.Mvvm.ViewBinding.Binders.UnityUI
{
    [Serializable]
    [Label("Grid Layout Group", "UI")]
    public sealed partial class GridLayoutGroupBinder : MonoBinder<GridLayoutGroup>
    {
    }

    [Serializable]
    [Label("Cell Size", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingCellSize : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetCellSize(Vector2 value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].cellSize = value;
            }
        }
    }

    [Serializable]
    [Label("Cell Width", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingCellWidth : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetCellWidth(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                var target = targets[i];
                target.cellSize = new Vector2(value, target.cellSize.y);
            }
        }
    }

    [Serializable]
    [Label("Cell Height", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingCellHeight : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetCellHeight(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                var target = targets[i];
                target.cellSize = new Vector2(target.cellSize.x, value);
            }
        }
    }

    [Serializable]
    [Label("Spacing Width", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingSpacingWidth : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetSpacingWidth(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                var target = targets[i];
                target.spacing = new Vector2(value, target.spacing.y);
            }
        }
    }

    [Serializable]
    [Label("Spacing Height", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingSpacingHeight : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetSpacingHeight(float value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                var target = targets[i];
                target.spacing = new Vector2(target.spacing.x, value);
            }
        }
    }

    [Serializable]
    [Label("Start Corner", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingStartCorner : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetStartCorner(GridLayoutGroup.Corner value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].startCorner = value;
            }
        }
    }

    [Serializable]
    [Label("Start Axis", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingStartAxis : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetStartAxis(GridLayoutGroup.Axis value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].startAxis = value;
            }
        }
    }

    [Serializable]
    [Label("Child Alignment", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingChildAlignment : MonoPropertyBinding<GridLayoutGroup>, IBinder
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
    [Label("Constraint", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingConstraint : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetConstraint(GridLayoutGroup.Constraint value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].constraint = value;
            }
        }
    }

    [Serializable]
    [Label("Constraint Count", "Grid Layout Group")]
    public sealed partial class GridLayoutGroupBindingConstraintCount : MonoPropertyBinding<GridLayoutGroup>, IBinder
    {
        [BindingProperty]
        [field: HideInInspector]
        private void SetConstraintCount(int value)
        {
            var targets = Targets;
            var length = targets.Length;

            for (var i = 0; i < length; i++)
            {
                targets[i].constraintCount = value;
            }
        }
    }
}

#endif
