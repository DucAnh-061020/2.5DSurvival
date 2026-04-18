using Unity.Entities;
using Unity.Mathematics;

namespace Survial.ECS_Core.Components
{
    public struct ControlSetting : IComponentData
    {
        public float TrackpadSensitivity;
        public float MouseSensitivity;
        public float AimAssistanceSensitivity;
        public float2 AccelerationRange;
        public bool InverseLookHorizontal;
        public bool InverseLookVertical;
    }
}
