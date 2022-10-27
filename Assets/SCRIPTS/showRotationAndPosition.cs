using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showRotationAndPosition : MonoBehaviour
{
    public GameObject myGameObject;
    public TextMeshProUGUI textPositionRotation;
    private double[] ghostInfoArray;
    public bool collectingInfo;
    private Vector3 p;
    private Vector3 r;
    private double xR;
    private double yR;
    private double zR;
    private double xP;
    private double yP;
    private double zP;
    private string xRString;
    private string yRString;
    private string zRString;
    private string xPString;
    private string yPString;
    private string zPString;

    private string rString;
    private string pString;
    private string info;


    // Start is called before the first frame update
    void Start()
    {
        textPositionRotation = textPositionRotation.GetComponent<TextMeshProUGUI>();
    }
  
    void collectInfo()
    {
       // while (collectingInfo)
        //{
            p = new Vector3(myGameObject.transform.position.x, myGameObject.transform.position.y, myGameObject.transform.position.z);
            r = new Vector3(myGameObject.transform.rotation.x, myGameObject.transform.rotation.y, myGameObject.transform.rotation.z);
            xR = Math.Round(r.x, 2);
            yR = Math.Round(r.y, 2);
            zR = Math.Round(r.z, 2);
            xP = Math.Round(p.x, 2);
            yP = Math.Round(p.y, 2);
            zP = Math.Round(p.z, 2);

            xRString = xR.ToString();
            yRString = yR.ToString();
            zRString = zR.ToString();
            xPString = xP.ToString();
            yPString = yP.ToString();
            zPString = zP.ToString();
            rString = "X: " + xRString + ", Y: " + yRString + ", Z: " + zRString;
            pString = "X: " + xPString + ", Y: " + yPString + ", Z: " + zPString;
            info = "Position: " + pString + " Rotation: " + rString;
            textPositionRotation.text = info;
        //}
       
    }



// Update is called once per frame
    void Update()
    {
        collectInfo();
    }
}