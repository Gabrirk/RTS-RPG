using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : BaseHero
{
    private GameObject attack01_Hitbox = default;
    private GameObject attack02_Hitbox = default;
    private GameObject attack03_Hitbox = default;


    private void Start()
    {
        attack01_Hitbox = transform.GetChild(0).gameObject;
        attack02_Hitbox = transform.GetChild(1).gameObject;
        attack03_Hitbox = transform.GetChild(2).gameObject;
    }

    //ATTACK01
    private void EnableAttack01()
    {
        attack01_Hitbox.SetActive(true);
    }

    private void DisableAttack01()
    {
        attack01_Hitbox.SetActive(false);
    }
    //ATTACK02
    private void EnableAttack02()
    {
        attack02_Hitbox.SetActive(true);
    }

    private void DisableAttack02() 
    {
        attack02_Hitbox.SetActive(false);
    }
    //ATTACK03
    private void EnableAttack03()
    {
        attack03_Hitbox.SetActive(true);
    }
    private void DisableAttack03()
    {
        attack03_Hitbox.SetActive(false);
    }


}
