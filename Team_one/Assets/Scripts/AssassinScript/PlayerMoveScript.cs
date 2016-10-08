using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour
{

    //移动速度
    public float moveSpeed;
    //旋转速度
    public float rotateSpeed;

    //动画
    Animator anim;

    //水平轴，垂直轴
    float hor, ver;


    void Start () {
        anim = GetComponent<Animator> ();

    }

    void Update () {
        Move ();

    }

    public void Move () {
        hor = Input.GetAxis ("Horizontal");
        ver = Input.GetAxis ("Vertical");

        if (ver != 0) {
            transform.Translate (ver * Vector3.forward * moveSpeed * Time.deltaTime);
            anim.SetBool (AssassinHashIDs.HashID_isRun, true);
        }
        else if (ver == 0) {
            anim.SetBool (AssassinHashIDs.HashID_isRun, false);
        }

        if (hor != 0) {
            transform.Rotate (Vector3.up, rotateSpeed * hor * Time.deltaTime);
        }
    }



}
