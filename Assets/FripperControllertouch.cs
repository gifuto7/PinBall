using UnityEngine;
using System.Collections;

public class FripperControllertouch : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoynt;
    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;


    void Start()
    {
        //HinjiJointコンポーネント取得
        this.myHingeJoynt = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        //スマートフォンのマルチタッチに対応する
        for (int i = 0; i < Input.touchCount; i++)
        {
            //タッチした座標を取得
            var pos = Input.touches[i].position;
            Touch t = Input.GetTouch(i);
            switch (t.phase)
            {
                case TouchPhase.Began:

                    if (pos.x < (Screen.width / 2) && tag == "LeftFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }
                    else if (pos.x > (Screen.width / 2) && tag == "RightFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }
                    
                    break;

                case TouchPhase.Ended:

                    SetAngle(this.defaultAngle);

                    break;


                    
            }
        }            

    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoynt.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoynt.spring = jointSpr;
    }

        }

 
