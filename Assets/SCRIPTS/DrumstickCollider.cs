using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumstickCollider : MonoBehaviour
{
    public GameObject drumLeft;
    public GameObject drumRight;
    private AudioSource masterSound;
    public AudioClip drumRightSFX;
    public AudioClip drumLeftSFX;
    private int[] patternDesired = new int[] {1,-1,1,1}; //general paradiddle drum pattern
    private int[] patternConducting =  new int[] {0,0,0,0}; //the pattern you make
    private string firstDrumHit = null; //this just defaults a specific drum to be the main drum you hit
    private bool startedNewPattern; 
    private int drumNumber = -1; //this is what drum you're on in the pattern
   

    void Start()
    {
        masterSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {

        drumNumber++;// move to the next drum in the pattern
        if (!startedNewPattern){
            startedNewPattern = true;
            firstDrumHit = other.gameObject.name;
        }

        if (other.gameObject.name == firstDrumHit){//if the drum you hit is the main drum you need to hit
            patternConducting[drumNumber] = 1;
        } else {
            patternConducting[drumNumber] = -1;
        }
       
       if (other.gameObject == drumLeft){
        Debug.Log(gameObject);
        masterSound.PlayOneShot(drumLeftSFX, 1.5f);
       }
       if (other.gameObject == drumRight){
        Debug.Log(gameObject);
        masterSound.PlayOneShot(drumRightSFX, 1.5f);
       }
       
        comparePatterns();
    }
   
   void comparePatterns() //code that checks to see if you hit the drums right or not
    {
        int desiredDrum = patternDesired[drumNumber];//get the value of the drum you're supposed to hit
        int actualDrum = patternConducting[drumNumber];//get the value of the drum you hit
        
        if (desiredDrum == actualDrum){
            Debug.Log("Good Job"); //if the drum you hit is the one you're supposed to, good job. Otherwise you need to start over
            if (drumNumber == 3){
                victory();
            }
        } else if (desiredDrum != actualDrum) {
            Debug.Log("Bad Job");
            startOverPattern();
        }
    }

    void startOverPattern(){
        for (int i = 0; i < 4; i++){
            patternConducting[i] = 0; //reset the pattern conducting thing
        }
        drumNumber = -1;
        startedNewPattern = false;//reset the first / main drum
        firstDrumHit = null;
        Debug.Log("Pattern Reset");
    }

    void victory (){
        //add more stuff here that'll happen when you do a good job IG
        Debug.Log("YOU WIN!!!!");
        startOverPattern();
    }
}
