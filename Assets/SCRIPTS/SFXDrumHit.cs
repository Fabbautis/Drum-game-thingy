using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXDrumHit : MonoBehaviour
{
    private AudioSource audioManager;
    public AudioClip drumSFX;
    public GameObject drum;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Drumstick")){
            if (drum.name == "DrumLeft"){
                Debug.Log("Left Drum hit");
            }
            if (drum.name == "DrumRight"){
                Debug.Log("Right Drum hit");
            }
        }
    }
}
