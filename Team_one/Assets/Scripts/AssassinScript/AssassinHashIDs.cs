using UnityEngine;
using System.Collections;

public class AssassinHashIDs : MonoBehaviour
{
    public static int HashID_isRun;
    public static int HashID_isAttack;
    public static int HashID_isReady_Skill01;
    public static int HashID_Skill01_PlaySpeed;
    public static int HashID_Skill01_Trigger;

    public void Awake () {
        HashID_isRun = Animator.StringToHash ("IsRun");
        HashID_isAttack = Animator.StringToHash ("IsAttack");
        HashID_isReady_Skill01 = Animator.StringToHash ("IsReady_Skill01");
        HashID_Skill01_PlaySpeed = Animator.StringToHash ("Skill01_PlaySpeed");
        HashID_Skill01_Trigger = Animator.StringToHash ("Skill01_Trigger");
    }
}
