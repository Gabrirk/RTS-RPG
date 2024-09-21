using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : BaseEnemy
{
    private GameObject attack01_Hitbox = default;
    private GameObject attack02_Hitbox = default;

    private void Start()
    {
        attack01_Hitbox = transform.GetChild(0).gameObject;
        attack02_Hitbox = transform.GetChild(1).gameObject;
    }

    //ATTACK-01
    private void EnableAttack01()
    {
        attack01_Hitbox.SetActive(true);
    }
    private void DisableAttack01() 
    {
        attack01_Hitbox.SetActive(false);
    }

    //ATTACK-02
    private void EnableAttack02()
    {
        attack02_Hitbox.SetActive(true);
    }
    private void DisableAttack02()
    {
        attack02_Hitbox.SetActive(false);
    }

}
