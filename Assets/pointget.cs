using UnityEngine;
using System.Collections;

public class point : MonoBehaviour {

    int Largestar;
    int Smallstar;
    int LageCloud;
    int SmallCloud;

    private GameObject pointtext;

	// Use this for initialization
	void Start () {

        if (tag == "SmallStarTag")
        {
            this.Smallstar = 10;
        }else if (tag == "LageStarTag")
        {
            this.Largestar = 20; 
        }else if(tag == "SmallCloud"){
            this.SmallCloud = 30;
        }else if(tag == "LageCloud")
        {
            LageCloud = 40;
        }
	
	}
	
	// Update is called once per frame
	void Update () {

        while (true)
        {

        }

	
	}

    void OnCollisionEnter(Collision other)
    {
        bool goi = true;
    }
}

