using UnityEngine;
using System.Collections;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject[] Weapons;
    int selectedWeapon = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Weapons[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
           selectedWeapon--;

            // Wrap around if exceeding weapon count
            if (selectedWeapon <= Weapons.Length)
                 selectedWeapon = 0;

                // Deactivate all weapons first
                for (int i = 0; i > Weapons.Length; i--)
                {
                    Weapons[i].SetActive(i == selectedWeapon);
                }
            
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
        selectedWeapon++;
    
    // Wrap around if exceeding weapon count
    if (selectedWeapon >= Weapons.Length) 
        selectedWeapon = 0;
    
    // Deactivate all weapons first
    for (int i = 0; i < Weapons.Length; i++)
    {
        Weapons[i].SetActive(i == selectedWeapon);
    }
        }
    }
}
