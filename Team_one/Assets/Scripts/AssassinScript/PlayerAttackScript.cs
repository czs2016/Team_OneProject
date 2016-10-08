using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour
{
    //动画
    Animator anim;

    TrailRenderer trail;

    void Start () {
        anim = GetComponent<Animator> ();
        trail = transform.FindChild ("weapon").GetChild (0).GetComponent<TrailRenderer> ();
    }

    void Update () {
        NormalAttack ();
    }

    void NormalAttack () {
        if (Input.GetMouseButtonUp (1)) {
            anim.SetBool (AssassinHashIDs.HashID_isAttack, true);
            
        }
        if (anim.GetBool (AssassinHashIDs.HashID_isAttack) == true && anim.GetBool (AssassinHashIDs.HashID_isRun) == true) {
            anim.SetBool (AssassinHashIDs.HashID_isAttack, false);
            trail.enabled = false;
        }
        if (anim.GetBool (AssassinHashIDs.HashID_isAttack)==true) {
            trail.enabled = true;
        }

    }

}
