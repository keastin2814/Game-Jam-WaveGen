using UnityEngine;
using UnityEditor;
using System.Collections;

public class WaveTest : MonoBehaviour
{
    public float waveLth;

    RaycastHit ray;
    RaycastHit hit;
    Vector3 start, waveMvnt = new Vector3(1,0,0);
    float theta;

    public struct RayWave
    {
        public Vector3 start;
        public float length;

        public RayWave(Vector3 spwnPnt, float lgth)
        {
            this.length = lgth;
            this.start = spwnPnt;
        }
    }
	
	void Update ()
    {
        
            RayWave smallray = new RayWave(start, waveLth);
            waveMvnt = new Vector3(0,Mathf.Sin(theta),0);
            start += new Vector3(.1f, 0f,0);
            theta += Mathf.Sin(.01f);
            //if (Physics.Raycast(start,waveMvnt,waveLth))
                //print("The ray " );
            Debug.DrawRay(start,waveMvnt, Color.green,waveLth);
        
    }
}
