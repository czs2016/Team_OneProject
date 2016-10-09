using UnityEngine;
using System.Collections;
using System;

public class PlayerSkillsAttackScript : MonoBehaviour
{
    //冲刺动作的移动速度
    public float sprintSpeed = 10;

    //动画
    Animator anim;

    //拖尾效果
    TrailRenderer trail;

    PlayerMoveScript playerMoveScript;


    void Start () {
        anim = GetComponent<Animator> ();
        trail = transform.FindChild ("weapon").GetChild (0).GetComponent<TrailRenderer> ();
        playerMoveScript = GetComponent<PlayerMoveScript> ();

    }

    void Update () {
        Skill01Attack ();
        Skill02Attack ();
        Skill03Attack ();
        Skill04Attack ();
    }


    //技能1
    void Skill01Attack () {
        anim.speed = 1;
        //按下num1键 并且 技能状态为false时，触发技能1动画
        if (Input.GetKeyDown (KeyCode.Alpha1) 
            && anim.GetBool (AssassinHashIDs.HashID_IsInSkillState)==false) {

            anim.SetBool (AssassinHashIDs.HashID_isReady_Skill01, true);
            anim.SetTrigger (AssassinHashIDs.HashID_Skill01_Trigger);
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
            anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, true);
        }
        //触发技能1动画时，根据动画曲线向前移动，并激活拖尾效果，同时角色不能移动（即原地释放技能）
        if (anim.GetBool (AssassinHashIDs.HashID_isReady_Skill01) == true) {

            if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Skill01_2")) {
                anim.speed = anim.GetFloat (AssassinHashIDs.HashID_Skill01_PlaySpeed);
                transform.Translate (Vector3.forward * anim.GetFloat (AssassinHashIDs.HashID_Skill01_PlaySpeed) * Time.deltaTime * sprintSpeed);
            }
            //trail.enabled = true;
            playerMoveScript.moveSpeed = 0;
        }
    }

    //技能2
    void Skill02Attack () {
        if (Input.GetKeyDown (KeyCode.Alpha2) 
            && anim.GetBool (AssassinHashIDs.HashID_IsInSkillState) == false) {

            anim.SetBool (AssassinHashIDs.HashID_isReady_Skill02, true);
            anim.SetTrigger (AssassinHashIDs.HashID_Skill02_Trigger);
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
            anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, true);
        }

        if (anim.GetBool(AssassinHashIDs.HashID_isReady_Skill02)==true) {
            playerMoveScript.moveSpeed = 0;
        }
    }

    //技能3
    private void Skill03Attack () {
        if (Input.GetKeyDown (KeyCode.Alpha3)
            && anim.GetBool (AssassinHashIDs.HashID_IsInSkillState) == false) {

            anim.SetBool (AssassinHashIDs.HashID_isReady_Skill03, true);
            anim.SetTrigger (AssassinHashIDs.HashID_Skill03_Trigger);
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
            anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, true);
        }

        if (anim.GetBool (AssassinHashIDs.HashID_isReady_Skill03) == true) {
            playerMoveScript.moveSpeed = 0;
        }
    }

    //技能4
    private void Skill04Attack () {
        if (Input.GetKeyDown (KeyCode.Alpha4)
            && anim.GetBool (AssassinHashIDs.HashID_IsInSkillState) == false) {

            anim.SetBool (AssassinHashIDs.HashID_isReady_Skill04, true);
            anim.SetTrigger (AssassinHashIDs.HashID_Skill04_Trigger);
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
            anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, true);
        }

        if (anim.GetBool (AssassinHashIDs.HashID_isReady_Skill04) == true) {
            playerMoveScript.moveSpeed = 0;
        }
    }

    //技能1动画播放完后，触发的动画事件
    //把动画标志设为false，重置冲刺速度，恢复角色移动速度，关闭拖尾效果
    public void Skill01_IsOver () {
        anim.SetBool (AssassinHashIDs.HashID_isReady_Skill01, false);
        sprintSpeed = 10;
        playerMoveScript.moveSpeed = playerMoveScript.originSpeed;
        anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, false);
    }


    //开始冲刺动作
    public void SprintStart () {
        trail.enabled = true;
    }

    //结束冲刺动作
    public void SprintEnd () {
        sprintSpeed = 0;
        trail.enabled = false;
    }

    //技能2播放结束时，触发的动画事件
    public void Skill02_IsOver () {
        anim.SetBool (AssassinHashIDs.HashID_isReady_Skill02, false);
        playerMoveScript.moveSpeed = playerMoveScript.originSpeed;
        anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, false);
    }

    //技能3播放结束时，触发的动画事件
    public void Skill03_IsOver () {
        anim.SetBool (AssassinHashIDs.HashID_isReady_Skill03, false);
        playerMoveScript.moveSpeed = playerMoveScript.originSpeed;
        anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, false);
    }

    //技能3播放结束时，触发的动画事件
    public void Skill04_IsOver () {
        anim.SetBool (AssassinHashIDs.HashID_isReady_Skill04, false);
        playerMoveScript.moveSpeed = playerMoveScript.originSpeed;
        anim.SetBool (AssassinHashIDs.HashID_IsInSkillState, false);
    }



}
