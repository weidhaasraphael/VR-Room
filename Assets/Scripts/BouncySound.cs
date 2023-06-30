using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BouncySound : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;

    [SerializeField] private AudioClip bounceSound;
    private float volumeSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        //code to get the velocity magnitude and convert to volume sound
        volumeSound = rb.velocity.magnitude; //maginitude converts velocity (Vector3) to a float. Refer to Unity API for more info
        //Debug.Log(volumeSound); //optional test

        audioSource.PlayOneShot(bounceSound, volumeSound);

    }
}

//Step 1: Attach the script to the Ball

//STEP 2: Go to the script and add a desired Audioclip (AudioSource does not need a clip)

//STEP3: Attach an AudioSource to the ball (if not already attached). Attach Colliders to surfaces you want to bounce against (especially furniture - the room already has colliders attached).
//(Note: if you don't attach colliders, onCollisionEnter will not work)

//STEP 4: Go to AudioSource and select 3D on spatial blend. You can then fiddle the 3D sound settings to your liking. 
//Mine had min distance 0.1 and 1 for max. (Impt: Do not put 0 as min distance as it would prevent this from working. Just look at the little chart generated below when you tweak the sound settings and you'll see what I mean).

//This step is optional, but I think it adds realism to how sound works; if you allow it to be at 2D sound, then the sound will be the same volume even if you threw the ball far away from you. In reality, sounds further away from you are softer, and tweaking the 3D settings allows you to mirror that.

//NOTE: The optional debug.log test in my code allows you to check the values going into PlayOneShot. PlayOneShot's magnitude (second argument - check Unity API for ref) only takes float values 0-1. 
