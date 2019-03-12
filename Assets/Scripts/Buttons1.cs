using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons1 : MonoBehaviour {
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
        sentences.Enqueue("Peter Parker: Hey you're the Ant thing that grows big and small");
        anim1 = GetComponent<Animator>();
    }
    public void onClick1 () {

        b1.SetActive(true);
        if (t1.text == "I'm from another time frame, need help")
        {
            sentences.Enqueue("Ant Man: " + t1.text);

            t4.text = "Peter Parker: We've fought on opposition sides, how can I trust you?";
            sentences.Enqueue(t4.text);
            t5.text = "Ant Man:";
            t1.text = "There is an attack coming";
            t2.text = "Avengers need to help";
            t3.text = "Okay, I'll do it myself";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "There is an attack coming")
        {
            sentences.Enqueue("Ant Man: " + t1.text);
            t4.text = "";
            t1.text = "Everyone you know will be dead";
        }
        else if (t1.text == "Everyone you know will be dead")
        {
            sentences.Enqueue("Ant Man: " + t1.text);

            t1.text = "You have to find Dr. Strange and timestone";
        }
        
        else if(t1.text =="You have to find Dr. Strange and timestone")
        {
            t4.text = "We'll go to the S.T first";
            sentences.Enqueue(t4.text);
            t1.text = "No, there's no time";
        }
        else if (t1.text == "No, there's no time")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: "+t1.text);
            t1.text = "I'll got to them";
        }
        else if (t1.text == "I'll got to them")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);
            t1.text = "You get Hulk";
        }
        else if (t1.text == "You get Hulk")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);
            //t1.text = "He'll know where Dr. Strange is";
            t1.text = "He is at Luminescence Lab (AC005)";
        }
        else if (t1.text == "He is at Luminescence Lab (AC005)")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);
            t1.text = "He'll know where Dr. Strange is";

        }
        else if (t1.text == "There's no time")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);
            t1.text = "Can't let my daughter die again";

        }
        else if (t1.text == "Can't let my daughter die again")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);

            t4.text = "Peter Parker: Hey you're the Ant thing that grows big and small";
            t5.text = "Ant Man:";
            t1.text = "I'm from another time frame, need help";
            t2.text = "Bingo! Now I have to find Dr. Strange";
            t3.text = "Okay, I'll do it myself";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "You find Dr. Banner")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            sentences.Enqueue("Ant Man: " + t1.text);
            t1.text = "He is at Luminescence Lab (AC005)";
            //t1.text = "He'll know where Dr. Strange is";
        }
        else if (t1.text == "We need to go to Mr. Stark")
        {
            t5.text = "";
            t4.text = "Peter Parker: ";
            sentences.Enqueue("Peter Parker " + t1.text);
            t1.text = "Otherwise, I'll take you by force";
        }
        else if (t1.text == "Otherwise, I'll take you by force")
        {
            sentences.Enqueue("Peter Parker " + t1.text);

            t4.text = "Peter Parker: We've fought on opposition sides, how can I trust you?";
            sentences.Enqueue(t4.text);
            t5.text = "Ant Man:";
            t1.text = "There is an attack coming";
            t2.text = "Avengers need to help";
            t3.text = "Okay, I'll do it myself";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }

        else if (t1.text == "He'll know where Dr. Strange is")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            t1.text = "All the best Kid";
            sentences.Enqueue("Ant Man: " + t1.text);
        }
        else if (t1.text == "All the best Kid")
        {
            t4.text = "";
            t5.text = "Ant Man: ";
            t1.text = "Please save the world and my kid";
            sentences.Enqueue("Ant Man: " + t1.text);
        }
        else if(t1.text=="No time kid")
        {
            sentences.Enqueue("Ant Man: " + t1.text);
            t4.text = "";
            t5.text = "Ant Man: ";
            t1.text = "Can't let my daughter die again";
        }
        else if (t1.text == "Please save the world and my kid")
        {
            SceneManager.LoadScene(3);
        }
        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick2()
    {


        if (t2.text == "Bingo! Now I have to find Dr. Strange")
        {
            t4.text = "Peter Parker: I'll need you to come to Mr. Stark";
            sentences.Enqueue("Ant Man: " + t2.text);
            sentences.Enqueue(t4.text);
            t5.text = "Ant Man: ";
            t1.text = "No time kid";
        }

        else if (t2.text == "Avengers need to help")
        {
            t4.text = "";
            t5.text = "Ant Man:";
            sentences.Enqueue("Ant Man: " + t2.text);
            //sentences.Enqueue(t4.text);
            t1.text = "You find Dr. Banner";

        }



        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick3()
    {

        b1.SetActive(true);
        if (t3.text == "No time, I'll have to save the world")
        {
            sentences.Enqueue("Ant Man: " + t3.text);
            t4.text = "Peter Parker: ";
            t5.text="";
            t1.text = "We need to go to Mr. Stark";
        }
        if (t3.text == "Okay, I'll do it myself")
        {
            t4.text = "Peter Parker: Hey you're the Ant thing that grows big and small";
            t5.text = "Ant Man:";
            t1.text = "I'm from another time frame, need help";
            t2.text = "Bingo! Now I have to find Dr. Strange";
            t3.text = "No time, I'll have to save the world";
            b2.SetActive(true);
            b3.SetActive(true);
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

            t6.text += sentence + "\n\n";
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
    void Update()
    {

    }
}
