using UnityEngine;
using System.Collections;

public class pointget : MonoBehaviour
{
    public int poi = 0;
    int LageStar;
    int SmallStar;
    int LageCloud;
    int SmallCloud;

    void Start()
    {

    }
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            poi += 10;

        }else if(other.gameObject.tag == "LageStarTag")
        {
            poi += 20;

        }else if(other.gameObject.tag == "SmallCloudTag")
        {
            poi += 30;

        }else if(other.gameObject.tag == "LageCloudTag")
        {
            poi += 40;

        }
    }
}