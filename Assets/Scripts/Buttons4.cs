using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons4 : MonoBehaviour {
    //public Button b1;
    //public Button b2;
    //public Button b3;

    public GameObject b1;
    public GameObject b2;
 

    public Text t1;
    public Text t2;

    public Text t4;
    public Text t5;
    public Text t6;

    public static Queue<string> sentences;

    public GameObject menu1;
    public GameObject menu2;
    private bool isShowing=false;

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        sentences = new Queue<string>();
        sentences.Enqueue("Dr. Strange: Spiderman, I see you've solved Wong's riddle");
    }
    public void onClick1 () {

        b1.SetActive(true);
        if (t1.text == "I've met someone from another timeperiod")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);

            t4.text = "Dr Strange: I did detect a pulse from quantum realm";
            sentences.Enqueue(t4.text);

            t5.text = "Peter Parker: There's an attack coming from outerspace";
            t1.text = "They are after the timestone";
        }
        else if (t1.text == "They are after the timestone")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);
            t4.text = "Dr. Strange: ";
            t5.text = "";
            t1.text = "What do we do?";
        }
        else if (t1.text == "What do we do?")
        {
            sentences.Enqueue("Dr. Strange: " + t1.text);
            t5.text = "";
            t4.text = "Peter Parker: We have to take the timestone to StarkTower";
            t1.text = "Immediately!";
        }

        else if (t1.text == "Immediately!")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);
            t4.text = "Dr. Strange: I have to take care of some things ";
            t5.text = "I'll tell you the location of timestone ";
            t1.text = "If you answer my question";
            sentences.Enqueue(t4.text + t5.text + t1.text);
        }
        else if(t1.text == "You may leave")
        {
            t4.text = "Dr. Strange: Spiderman, I see you've solved Wong's riddle";
            t5.text = "Peter Parker: ";
            t1.text = "I've met someone from another timeperiod";
            t2.text = "Mr. Strange, please tell me location of timestone";
            b2.SetActive(true);
            return;
        }
        else if (t1.text == "If you answer my question")
        {
            sentences.Enqueue("Peter Parker: "+t1.text);
            SceneManager.LoadScene(6);
            return;
        }
        
        b2.SetActive(false);
        t2.text = "";


    }

    public void onClick2()
    {
        

        if (t2.text == "Mr. Strange, please tell me location of timestone")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);
            t4.text = "Dr. Strange: It is well protected ";
            t5.text = "";
            t1.text = "You may leave";
        }

        else if (t2.text == "Need to find Dr.Strange at once")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);
            t4.text = "Wong: Master Strange is busy protecting the sanctum";
            t5.text = "";
            
            t1.text = "Please leave at once";

        }
        


        b2.SetActive(false);
        t2.text = "";

  
    }

    

    

    public void Testing()
    {
        foreach (string sentence in sentences)
        {
            
            t6.text += sentence+"\n\n";
        }

    }

    public void Toggle()
    {
        menu1.SetActive(isShowing);
        isShowing = !isShowing;
        menu2.SetActive(isShowing);
        
    }
 
        // Update is called once per frame
    void Update () {
		
	}
}
