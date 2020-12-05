using UnityEngine;

namespace Coloseum.Systems.ViewModel
{
    public interface IViewObject
    {
        Vector2 Position { get; set; }

        void MoveTo(in Vector2 vector2);
        void Destroy();
    }
}