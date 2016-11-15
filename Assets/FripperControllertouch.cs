using UnityEngine;
using System.Collections;

public class FripperControllertuch : MonoBehaviour
{

    private HingeJoint myHingeJoynt;

    private float defaultAngle = 20;
    private float flickAngle = -20;
    // Use this for initialization
    void Start()
    {

        this.myHingeJoynt = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            var id = Input.touches[i].fingerId;
            var pos = Input.touches[i].position;

            if (pos.x > 0 && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            } else if (pos.x < 0 && tag == "RightFripperTag") {
                SetAngle(this.flickAngle);

            } else if (pos.x > 0 || pos.x < 0)
            {
                SetAngle(this.defaultAngle);

            } else if (pos.x > 0 && pos.x < 0)
            {
                SetAngle(this.flickAngle);
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

 
