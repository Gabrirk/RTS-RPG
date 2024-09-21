using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : BaseHero
{
    private GameObject attack01_Hitbox = default;

    private GameObject attack02_Hitbox_1 = default;
    private GameObject attack02_Hitbox_1c = default;
    private GameObject attack02_Hitbox_2 = default;
    private GameObject attack02_Hitbox_2c = default;
    private GameObject attack02_Hitbox_3 = default;
    private GameObject attack02_Hitbox_3c = default;

    private GameObject attack03_Hitbox = default;


    private void Start()
    {
        attack01_Hitbox = transform.GetChild(0).gameObject;

        attack02_Hitbox_1 = transform.GetChild(1).gameObject;
        attack02_Hitbox_1c = transform.GetChild(2).gameObject;
        attack02_Hitbox_2 = transform.GetChild(3).gameObject;
        attack02_Hitbox_2c = transform.GetChild(4).gameObject;
        attack02_Hitbox_3 = transform.GetChild(5).gameObject;
        attack02_Hitbox_3c = transform.GetChild(6).gameObject;

        attack03_Hitbox = transform.GetChild(7).gameObject;
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


    //ATTACK02-1

    private void EnableAttack02_1()
    {
        attack02_Hitbox_1.SetActive(true);
        attack02_Hitbox_1c.SetActive(true);
    }

    private void DisableAttack02_1()
    {
        attack02_Hitbox_1.SetActive(false);
        attack02_Hitbox_1c.SetActive(false);
    }

    //ATTACK02-2

    private void EnableAttack02_2()
    {
        attack02_Hitbox_2.SetActive(true);
        attack02_Hitbox_2c.SetActive(true);
    }

    private void DisableAttack02_2()
    {
        attack02_Hitbox_2.SetActive(false);
        attack02_Hitbox_2c.SetActive(false);
    }

    //ATTACK02-3

    private void EnableAttack02_3()
    {
        attack02_Hitbox_3.SetActive(true);
        attack02_Hitbox_3c.SetActive(true);
    }

    private void DisableAttack02_3()
    {
        attack02_Hitbox_3.SetActive(false);
        attack02_Hitbox_3c.SetActive(false);
    }

    //ATTACK3

    private void EnableAttack03()
    {
        attack03_Hitbox.SetActive(true);
    }

    private void DisableAttack03()
    {
        attack03_Hitbox.SetActive(false);
    }








}
