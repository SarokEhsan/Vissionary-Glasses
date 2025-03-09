using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsManager : MonoBehaviour
{
    int tap = 0;

    private AudioSource audioSource;
    public Button soundButton;
    public Sprite Volume100;
    public Sprite Volume50;
    public Sprite VolumeOff;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackgroundSoundVolume()
    {
        tap++;
        int x = tap % 3;
        audioSource.volume -= 0.5f;

        switch (x){
            case 1:
                soundButton.image.sprite = Volume50;
                break;
            case 2:
                soundButton.image.sprite = VolumeOff;
                break;
            default:
                soundButton.image.sprite = Volume100;
                audioSource.volume += 1;
                tap = 0;
                break;
        }
        Debug.Log(audioSource.volume);
    }
}
