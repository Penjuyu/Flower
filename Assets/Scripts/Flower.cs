using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    Animator anim;
    bool isClose = false;
	
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}

    private void OnMouseDown()
    {
        isClose = !isClose;
        anim.SetBool("IsClose", isClose);
    }




}
