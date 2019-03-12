using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons3 : MonoBehaviour {
    //public Button b1;
    //public Button b2;
    //public Button b3;

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;

    public Text t1;
    public Text t2;
    public Text t3;
    public Text t4;
    public Text t5;
    public Text t6;

    public static Queue<string> sentences;
    private Animator anim1;
    private Animation anim;
    public GameObject menu1;
    public GameObject menu2;
    private bool isShowing=false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
        Screen.orientation = ScreenOrientation.Portrait;
        sentences = new Queue<string>();
        sentences.Enqueue("Wong: How dare you enter my sanctum?");
        anim1 = GetComponent<Animator>();
    }
    public void onClick1 () {

        b1.SetActive(true);
        if (t1.text == "Sir, Mr. Banner sent me")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);

            t4.text = "Wong: I don't trust the big green guy or you";
            sentences.Enqueue(t4.text);
            t5.text = "Peter Parker:";
            t1.text = "Please help me find Dr. Strange";
            t2.text = "Please help me find timestone";
            t3.text = "Please help me";
            b2.SetActive(true);
            b3.SetActive(true);
            return;

        }
        else if (t1.text == "Please help me find Dr. Strange")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);
            t4.text = "Wong: Master is at ";
            t5.text = "";
            t1.text = "The most advanced part of atheneum";
        }
        else if (t1.text == "The most advanced part of atheneum")
        {
            sentences.Enqueue("Wong: " + t1.text);
            t4.text = "";
            t5.text = "Peter Parker: ";
            t1.text = "What?";
        }

        else if (t1.text == "What?")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);
            t4.text = "Wong: ";
            t5.text = "";
            t1.text = "You'll figure if you're worthy";
            sentences.Enqueue(t4.text + t1.text);
        }
        else if (t1.text == "There is no time to explain")
        {
            sentences.Enqueue("Peter Parker: "+t1.text);
            t4.text = "";
            t5.text = "Peter Parker: ";
            t1.text = "Please help me find Dr. Strange";
            t2.text = "Where can I find the stone?";
            b2.SetActive(true);
            return;
        }
        else if(t1.text =="Please leave at once")
        {
            sentences.Enqueue("Wong: "+t1.text);
            t4.text = "Wong: How dare you enter my sanctum?";
            t5.text = "Peter Parker: ";
            t1.text = "Sir, Mr. Banner sent me";
            t2.text = "Need to find Dr.Strange at once";
            t3.text = "Half the universe is going to perish";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if(t1.text == "Such insolence is intolerable")
        {
            sentences.Enqueue("Wong: "+t1.text);
            t4.text = "";
            t5.text = "Peter Parker: ";
            t1.text = "Please Listen!";
        }
        else if(t1.text == "Please Listen!")
        {
            sentences.Enqueue("Peter Parker: ");
            t4.text = "Please remove yourself from the sanctum";
            t5.text = "";
            t1.text = "Otherwise, I'll chop your head";
        }
        else if(t1.text == "Otherwise, I'll chop your head")
        {
            sentences.Enqueue("Wong: ");
            t4.text = "Wong: How dare you enter my sanctum?";
            t5.text = "Peter Parker: ";
            t1.text = "Sir, Mr. Banner sent me here";
            t2.text = "Need to find Dr.Strange at once";
            t3.text = "Half the universe is going to perish";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "You'll figure if you're worthy")
        {
            SceneManager.LoadScene(5);
        }
        
        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick2()
    {
        

        if (t2.text == "Please help me find timestone")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);
            t4.text = "Bruce Banner: How do you know about timestone? ";
            t5.text = "Peter Parker: ";
            t1.text = "There is no time to explain";
        }

        else if (t2.text == "Need to find Dr.Strange at once")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);
            t4.text = "Wong: Master Strange is busy protecting the sanctum";
            t5.text = "";
            
            t1.text = "Please leave at once";

        }
        else if (t2.text == "Where can I find the stone?")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);

            t5.text = "";
            t4.text = "Wong: How do you know about the stone? ";
            sentences.Enqueue(t4.text);
            t1.text = "Such insolence is intolerable";

        }



        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick3()
    {

        b1.SetActive(true);
        if (t3.text == "Half the universe is going to perish")
        {
            sentences.Enqueue("Peter Parker: " + t3.text);
            t5.text = "";
            t4.text = "Wong: How do you know about the stone? ";
            t1.text = "Such insolence is intolerable";
        }
        if (t3.text == "Where can I find timestone?")
        {
            sentences.Enqueue("Peter Parker: "+t3.text);
            t4.text = "Bruce Banner: ";
            t5.text = "";
            t1.text = "Wong is at the Workshop";

            return;
        }


        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
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
