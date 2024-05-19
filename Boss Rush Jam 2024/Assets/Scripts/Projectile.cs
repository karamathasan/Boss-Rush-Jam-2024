using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Projectile 
{
    void Shoot();
    void Collide();
    void OutOfBounds();
}
