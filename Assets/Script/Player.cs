using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Mover
{
    protected override void Start()
    {
        base.Start();
        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));
    }

    public void SwapSprite(int skinId)
    {
        GetComponent<SpriteRenderer>().sprite = GameManager.instance.playerSprite[skinId];
    }
    public void OnLevelUp()
    {
        maxHitPoint += 2;
        hitPoint = maxHitPoint;
    }
    public void SetLevel(int level)
    {
        for (int i = 0; i < level; i++)
            OnLevelUp();
    }
    public void Heal(int healingAmount)
    {
        if(hitPoint == maxHitPoint)
        {
            return;
        }
        hitPoint += healingAmount;
        if(hitPoint > maxHitPoint)
        {
            hitPoint = maxHitPoint;
        }

        GameManager.instance.ShowText("+" + healingAmount.ToString() + "hp", 25, Color.blue, transform.position, Vector3.up * 30, 0.7f);
        
    }

}
