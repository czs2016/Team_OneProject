using UnityEngine;
using System.Collections;

public class AssassinHashIDs : MonoBehaviour
{
    public static int HashID_isRun;
    public static int HashID_isAttack;
    public static int HashID_IsInSkillState;

    public static int HashID_isReady_Skill01;
    public static int HashID_Skill01_PlaySpeed;
    public static int HashID_Skill01_Trigger;

    public static int HashID_isReady_Skill02;
    public static int HashID_Skill02_Trigger;

    public static int HashID_isReady_Skill03;
    public static int HashID_Skill03_Trigger;

    public static int HashID_isReady_Skill04;
    public static int HashID_Skill04_Trigger;

    public void Awake () {
        HashID_isRun = Animator.StringToHash ("IsRun");
        HashID_isAttack = Animator.StringToHash ("IsAttack");
        HashID_IsInSkillState = Animator.StringToHash ("IsInSkillState");

        HashID_isReady_Skill01 = Animator.StringToHash ("IsReady_Skill01");
        HashID_Skill01_PlaySpeed = Animator.StringToHash ("Skill01_PlaySpeed");
        HashID_Skill01_Trigger = Animator.StringToHash ("Skill01_Trigger");

        HashID_isReady_Skill02 = Animator.StringToHash ("IsReady_Skill02");
        HashID_Skill02_Trigger = Animator.StringToHash ("Skill02_Trigger");

        HashID_isReady_Skill03 = Animator.StringToHash ("IsReady_Skill03");
        HashID_Skill03_Trigger = Animator.StringToHash ("Skill03_Trigger");

        HashID_isReady_Skill04 = Animator.StringToHash ("IsReady_Skill04");
        HashID_Skill04_Trigger = Animator.StringToHash ("Skill04_Trigger");
    }
}
