using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour
{
    //text
    public Text levelText, hitpointText, moneyText, upgradeCostText, xpText;

    //logic
    private int currentCharacterSelection = 0;
    public Image characterSelectionSprite;
    public Image weaponSprite;
    public RectTransform xpBar;

    //character select
    public void OnArrowClick(bool right)
    {
        if (right)
        {
            currentCharacterSelection++;

            if (currentCharacterSelection == GameManager.instance.playerSprite.Count)
                currentCharacterSelection = 0;

            OnSelectionChanged();
        }
        else
        {
            currentCharacterSelection--;

            if (currentCharacterSelection < 0)
                currentCharacterSelection = GameManager.instance.playerSprite.Count - 1;

            OnSelectionChanged();
        }

    }

    private void OnSelectionChanged()
    {
        characterSelectionSprite.sprite = GameManager.instance.playerSprite[currentCharacterSelection];
    }

    //weapon upgrade
    public void OnUpgradeClick()
    {
        //
    }

    //update info
    public void UpdateMenu()
    {
        //weapon
        weaponSprite.sprite = GameManager.instance.weaponSprite[0];
        upgradeCostText.text = "No Implement";
        //info
        hitpointText.text = GameManager.instance.player.hitPoint.ToString();
        moneyText.text = GameManager.instance.dollars.ToString();
        levelText.text = "No Implement";
        //xp bar
        xpText.text = "No Implement";
        xpBar.localScale = new Vector3(0.5f, 0, 0);


    }

}
