#if UNITY_COLLECTIONS

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Module.Core.Jobs
{
    [BurstCompile]
    public partial struct TrySetCapacityListJob<TData> : IJob
        where TData : unmanaged
    {
        public int capacity;
        public NativeList<TData> set;

        [BurstCompile]
        public void Execute()
        {
            if (capacity > set.Capacity)
            {
                set.Capacity = capacity;
            }
        }
    }

    [BurstCompile]
    public partial struct ClearListJob<TData> : IJob
        where TData : unmanaged
    {
        [WriteOnly] public NativeList<TData> list;

        [BurstCompile]
        public void Execute()
        {
            list.Clear();
        }
    }
}

#endif
