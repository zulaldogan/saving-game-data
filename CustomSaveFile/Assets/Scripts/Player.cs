using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int healt = 20;
    public int attack = 6;
    public int defense = 4;

    public void Save()
    {
        SaveLoadManager.SavePlayer(this);
    }

    public void Load()
    {
        int[] loadStatus = SaveLoadManager.LoadPlayer();

        level = loadStatus[0];
        healt = loadStatus[1];
        attack = loadStatus[2];
        defense = loadStatus[3];

        GetComponent<PlayerDisplay>().UpdateDisplay();
    }

    public void Adjust(ref int stat, int value)
    {
        stat += value;

        if (stat < 1)
        {
            stat = 1;
        }

        GetComponent<PlayerDisplay>().UpdateDisplay();
    }

    public void AdjustLevel(int value)
    {
        Adjust(ref level, value);
    }

    public void AdjustHealt(int value)
    {
        Adjust(ref healt, value);
    }

    public void AdjustAttack(int value)
    {
        Adjust(ref attack, value);
    }

    public void AdjustDefense(int value)
    {
        Adjust(ref defense, value);
    }
}
