using UnityEngine;

public struct Damage 
{

    public Vector3 origin;
    public int damageAmount;
    public float pushForce;
    public Collider2D collide;

    public Collider2D getCollide()
    {
        return collide;
    }

}