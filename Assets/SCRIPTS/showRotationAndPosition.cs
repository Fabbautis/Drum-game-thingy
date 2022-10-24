using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showRotationAndPosition : MonoBehaviour
{
    public GameObject myGameObject;
    
    private Vector3 p;
    private Vector3 r;
    
    private float xR;
    private float yR;
    private float zR;
    private float xP;
    private float yP;
    private float zP;

    private string xRString;
    private string yRString;
    private string zRString;
    private string xPString;
    private string yPString;
    private string zPString;

    private string rString;
    private string pString;
    public string info;

    // Start is called before the first frame update
    void Start()
    {
    }

    void showInfo()
    {
        p = new Vector3(myGameObject.transform.position.x, myGameObject.transform.position.y, myGameObject.transform.position.z);
        r = new Vector3(myGameObject.transform.rotation.x, myGameObject.transform.rotation.y, myGameObject.transform.rotation.z);
        xR = r.x;
        yR = r.y;
        zR = r.z;
        xP = p.x;
        yP = p.y;
        zP = p.z;
        xRString = xR.ToString();
        yRString = yR.ToString();
        zRString = zR.ToString();
        xPString = xP.ToString();
        yPString = yP.ToString();
        zPString = zP.ToString();
        rString = "X: " + xRString + ", Y: " + yRString + ", Z: " + zRString;
        pString = "X: " + xPString + ", Y: " + yPString + ", Z: " + zPString;
        info = "Position: " + pString + " Rotation: " + rString;
        Debug.Log(info);
    }

// Update is called once per frame
    void Update()
    {
        showInfo();
    }
}