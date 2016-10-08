using UnityEngine;
using System.Collections;

public class PlayerSkillsAttackScript : MonoBehaviour
{
    //冲刺动作的移动速度
    public float sprintSpeed = 10;
    
    //动画
    Animator anim;

    void Start () {
        anim = GetComponent<Animator> ();
    }

    void Update () {
        Skill01Attack ();
    }

    void Skill01Attack () {
        anim.speed = 1;
        if (Input.GetKeyDown (KeyCode.Alpha1)) {
            anim.SetBool (AssassinHashIDs.HashID_isReady_Skill01, true);
            anim.SetTrigger (AssassinHashIDs.HashID_Skill01_Trigger);
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
        }

        if (anim.GetBool (AssassinHashIDs.HashID_isReady_Skill01) == true) {
            if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Skill01_2")) {
                anim.speed = anim.GetFloat (AssassinHashIDs.HashID_Skill01_PlaySpeed);
                transform.Translate (Vector3.forward * anim.GetFloat (AssassinHashIDs.HashID_Skill01_PlaySpeed) * Time.deltaTime * sprintSpeed);
            }
        }
    }

    //动画播放完后，触发的动画事件
    public void Skill01_IsOver () {
        anim.SetBool ("IsReady_Skill01", false);
        sprintSpeed = 10;
    }


    //开始冲刺动作
    public void SprintStart () {
        
    }

    //结束冲刺动作
    public void SprintEnd () {
        sprintSpeed = 0;
    }





















































































}
