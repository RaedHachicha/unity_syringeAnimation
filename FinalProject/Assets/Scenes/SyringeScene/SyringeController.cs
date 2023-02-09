using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeController : MonoBehaviour
{

    Animator animator;
    Animator glassAnimator;
    GameObject syringeGlass;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        glassAnimator = GameObject.FindGameObjectWithTag("Liquid").GetComponent<Animator>();
        syringeGlass = GameObject.FindGameObjectWithTag("Glass");
    }

    // Update is called once per frame
    void Update()
    {
        detectAnimation();

    }

    void detectAnimation() {

        if (Input.GetMouseButton(0)) {
            syringeGlass.SetActive(false);
            animator.SetBool("syringePulled",true);
            glassAnimator.SetBool("liquidPulled",true);
        }
    }
}
