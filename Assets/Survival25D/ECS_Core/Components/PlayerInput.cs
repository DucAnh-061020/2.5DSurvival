using Unity.Entities;
using Unity.Mathematics;

namespace Survial.ECS_Core.Components
{
    public struct PlayerInput : IComponentData
    {
        public float2 movementInput;
        public float2 lookInput;
    }
}