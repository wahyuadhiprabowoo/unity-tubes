using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public AudioClip sound;
    // Start is called before the first frame update

    private Button button{get {return GetComponent<Button>();}}
    private AudioSource source{get {return GetComponent<AudioSource>();}}
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        button.onClick.AddListener (() => PlaySound ());
    }

    // Update is called once per frame
    void PlaySound()
    {
        source.PlayOneShot (sound);
    }
}