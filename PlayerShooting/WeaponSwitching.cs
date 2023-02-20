using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
   public int selectedWeapon = 0;

   void Start()
   {
    SelectedWeapon();
   }

   void Update()
   {
    int previousSelectedweapon = selectedWeapon;

    if(Input.GetKeyDown(KeyCode.Alpha1))
    {
        selectedWeapon = 0;
    }
    if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)

    {
        selectedWeapon = 1;
    }
    if(Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >=3)
    {
        selectedWeapon = 2;
    }

    if(previousSelectedweapon != selectedWeapon)
    {
        SelectedWeapon();
    }
   }

   void SelectedWeapon()
   {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if(i==selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
   }
}
