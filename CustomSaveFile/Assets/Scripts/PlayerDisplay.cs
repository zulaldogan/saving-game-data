using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class PlayerDisplay : MonoBehaviour
{
    public Text level, healt, attack, defense;
    public Player player;
    
    void Awake()
    {
        player = GetComponent<Player>();
    }
   
    void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        level.text=player.level.ToString();
        healt.text = player.healt.ToString();
        attack.text = player.attack.ToString();
        defense.text = player.defense.ToString();
    }
}
