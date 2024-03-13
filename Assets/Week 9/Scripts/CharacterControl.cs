using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public GameObject findText;
    public static TextMeshProUGUI selected;
    void Start()
    {
        findText = GameObject.Find("findText");
        selected = findText.GetComponent<TextMeshProUGUI>();
    }

    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        selected.SetText(villager.CanOpen().ToString());
    }

}
