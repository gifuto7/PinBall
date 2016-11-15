using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointexpression : MonoBehaviour {

    // Use this for initialization
    int ai;
    private GameObject pointtext;
    string mozi = "POINT";
    private GameObject ball;
    
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {
        this.pointtext = GameObject.Find("PointText");
        this.ball = GameObject.Find("Ball"); //s
        int point = ball.GetComponent<pointget>().poi; //s


        
        
            this.pointtext.GetComponent<Text>().text = mozi + point.ToString();
        
	}
}
