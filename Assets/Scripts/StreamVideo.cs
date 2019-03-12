using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class StreamVideo : MonoBehaviour {

    public RawImage rawImage;
    public VideoPlayer videoPlayer;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    //   public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        //button4.SetActive(false);
    }

    // Update is called once per frame
    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        //button4.SetActive(true);
        // audioSource.Play();


    }
}
