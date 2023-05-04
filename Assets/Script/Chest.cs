using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int moneyAmount = 5;


    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Get " + moneyAmount + " dollars");
            GameManager.instance.ShowText("+" + moneyAmount + " dollars!", 25, new Color(166,172,180), transform.position, Vector3.up * 25, 0.8f);
        }
    }
}
