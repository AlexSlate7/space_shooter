﻿using Code.Infractructure.Services;
using UnityEngine;

namespace Code.Services.Input
{
    public interface IInputService : IService
    {
        Vector2 Axis { get; }

    }
}