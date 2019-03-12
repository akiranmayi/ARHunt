using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons : MonoBehaviour {
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
        sentences.Enqueue("Stark: Hey Pete, what brings you here?");
        anim1 = GetComponent<Animator>();
    }
    public void onClick1 () {

        b1.SetActive(true);

        if (t1.text == "Happy you asked me to meet you")
        {
            sentences.Enqueue("Peter: "+t1.text);
            t4.text = "Stark: Ah, yeah I forgot. I have some work for you. ";
            sentences.Enqueue(t4.text);

            t1.text = "What sort of?";
            t2.text = "Cool let's go save the world";
            t3.text = "Just give me the details and forget it";
            t5.text = "Peter:";
            return;
        }
        if (t1.text=="What sort of?")
        {
            sentences.Enqueue("Peter: "+t1.text);
            t4.text = "Stark: Actually there is some unusual activity happening on the ground";
            sentences.Enqueue(t4.text);

            t5.text = "Peter: ";
            t1.text = "Okay, what should I do there?";
            t2.text = "Cool, shall I take care of the enemies?";
            t3.text = "Can you give me some more details or insights?";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "Okay, what should I do there?")
        {
            sentences.Enqueue("Peter: " + t1.text);
            t4.text = "Stark: Just go there and check what happened";
            sentences.Enqueue(t4.text);
            t5.text = "Peter: ";
            t1.text = "Yeah, sure will be on it.";
        }
        else if (t1.text == "Yeah, sure will be on it.")
        {
            sentences.Enqueue("Peter: " + t1.text);
            //t4.text = "Stark:";
            //sentences.Enqueue(t4.text);
            t5.text = "";
            t1.text = "Hey Pete, if you have doubts come back to me";

        }

        else if (t1.text == "Hey Pete, if you have doubts come back to me")
        {
            SceneManager.LoadScene(2);

        }
        else if(t1.text== "Kid, you should learn a few things first")
        {
            t4.text = "Stark: Ah, yeah I forgot. I have some work for you. ";
            sentences.Enqueue("Peter: " + t1.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter:";
            t1.text = "What sort of?";
            t2.text = "Cool let's go save the world";
            t3.text = "Just give me the details and forget it";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }

        else if (t1.text == "Can you give me some more insights?")
        {
            t4.text = "Stark: Yeah, it happened near the basketball court to be precise ";
            sentences.Enqueue("Peter: " + t1.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter:";
            t1.text = "Okay then, I'll take care of it";

            return;
        }
        else if (t1.text == "Okay then, I'll take care of it")
        {
            SceneManager.LoadScene(2);

            return;
        }

        else if (t1.text == "Doing well, thought I would have work here.")
        {
            t4.text = "Stark: Ah, yeah I forgot. I have some work for you. ";
            sentences.Enqueue("Peter: " + t1.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter:";
            t1.text = "What sort of?";
            t2.text = "Cool let's go save the world";
            t3.text = "Just give me the details and forget it";
            b2.SetActive(true);
            b3.SetActive(true);

            return;
        }

        else if (t1.text == "Ah kid! Complete your academics")
        {
            t4.text = "Stark: Hey Pete, what brings you here?";
            sentences.Enqueue("Peter: " + t1.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter:";
            t1.text = "Happy you asked me to meet you";
            t2.text = "Just came here to meet you";
            t3.text = "Here to help you save the world";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }


        else if(t1.text == "Just go check the ground area.")
        {
            SceneManager.LoadScene(2);
        }


        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick2()
    {
        

        if (t2.text == "Just came here to meet you")
        {
            t4.text = "Stark: So, what's up. How are you doing?";
            sentences.Enqueue("Peter: " + t2.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter: ";
            t1.text = "Doing well, thought I would have work here.";
        }

        else if (t2.text == "Cool let's go save the world")
        {
            t4.text = "Stark:";
            sentences.Enqueue("Peter: " + t2.text);
            //sentences.Enqueue(t4.text);
            t5.text = "";
            t1.text = "Kid, you should learn a few things first";

        }
        else if(t2.text=="Cool, shall I take care of the enemies?")
        {
            t4.text = "Stark: Kid, did I say that? Control yourself!";
            sentences.Enqueue("Peter: " + t2.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter: ";
            t1.text = "Can you give me some more insights?";
        }
        else if (t2.text == "Thought of saving the world, here to help")
        {
            t4.text = "Stark: ";
            sentences.Enqueue("Peter: " + t2.text);
            //sentences.Enqueue(t4.text);
            t5.text = "";
            t1.text = "Ah kid! Complete your academics";
        }


        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick3()
    {

        b1.SetActive(true);
        if (t3.text == "Thought of saving the world, here to help")
        {
            t4.text = "Stark: ";
            sentences.Enqueue("Peter: " + t3.text);

            t5.text = "";
            t1.text = "Ah kid! Complete your academics";
        }

        else if (t3.text == "Can you give me some more details or insights?")
        {
            t4.text = "Stark: Yeah, it happened near the basketball court to be precise ";
            sentences.Enqueue("Peter: " + t3.text);
            sentences.Enqueue(t4.text);
            t5.text = "Peter:";
            t1.text = "Okay then, I'll take care of it";

        }
        if (t3.text == "Just give me the details and forget it")
        {
            t4.text = "Stark:  ";
            sentences.Enqueue("Peter: " + t3.text);
            //sentences.Enqueue(t4.text);
            t5.text = "";
            t1.text = "Just go check the ground area.";
        }


        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    

    public void LoadScene2()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(0);
    }

    public void Testing()
    {
        foreach (string sentence in sentences)
        {
            
            t6.text += sentence+"\n\n";
        }

    }

    public void Delay()
    {
        for (long i = 0; i < 100000; i++) ;
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
