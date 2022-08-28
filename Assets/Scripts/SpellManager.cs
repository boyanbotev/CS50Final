using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class SpellManager : MonoBehaviour
{
    [SerializeField]
    Transform spellArea;
    TextMeshProUGUI[] spellSlots;
    int slotNum;

    private void Awake()
    {
        spellSlots = spellArea.GetComponentsInChildren<TextMeshProUGUI>();
    }
    public void RegisterButton()
    {
        // Get Pressed Button text
        GameObject button = EventSystem.current.currentSelectedGameObject;
        string buttonText = button.GetComponentInChildren<TextMeshProUGUI>().text;
        Debug.Log("Button Pressed = " + buttonText);

        // Change Button Text
        spellSlots[slotNum].text = buttonText;

        // Increment Slot Num
        if(slotNum == 2)
        {
            slotNum = 0;
        }
        else
        {
            slotNum++;
        }
    }

    


}
