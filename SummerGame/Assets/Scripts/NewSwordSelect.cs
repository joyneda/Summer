using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSwordSelect : MonoBehaviour {

    public GameObject[] sword;

	void Awake()
    {
        if (SwordSelected.nextSword == 0) return;

        sword[0].SetActive(false);
        sword[SwordSelected.nextSword].SetActive(true);
        Destroy(this);
    }
}
