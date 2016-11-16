using UnityEngine;
using System.Collections;

public class pointget : MonoBehaviour
{
    public int poi = 0;

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

        }else if(other.gameObject.tag == "LargeStarTag")
        {
            poi += 20;

        }else if(other.gameObject.tag == "SmallCloudTag")
        {
            poi += 30;

        }else if(other.gameObject.tag == "LargeCloudTag")
        {
            poi += 40;

        }
    }
}