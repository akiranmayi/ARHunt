using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons2 : MonoBehaviour {
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
        sentences.Enqueue("Bruce Banner: Alien! Get out otherwise Hulk will smash you!");
        anim1 = GetComponent<Animator>();
    }
    public void onClick1 () {

        b1.SetActive(true);
        if (t1.text == "Mr. Stark sent me")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);

            t4.text = "Bruce: Tony sent you? For what purpose?";
            sentences.Enqueue(t4.text);
            t5.text = "Peter Parker:";
            t1.text = "Actually, another guy sent me";
            t2.text = "There is no time to explain";
            t3.text = "I need you to help find timestone";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "Actually, another guy sent me")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);
            t4.text = "";
            t5.text = "Peter Parker: ";
            t1.text = "Half the people are going to die";
        }
        else if (t1.text == "Half the people are going to die")
        {
            sentences.Enqueue("Peter Parker: " + t1.text);

            t4.text = "Bruce Banner: ";
            t1.text = "Another guy? I don't trust you!";
            sentences.Enqueue(t4.text + t1.text);
            t5.text = "";
        }

        else if (t1.text == "Another guy? I don't trust you!")
        {
            t4.text = "Bruce Banner: ";
            t1.text = "I cant hold Hulk any longer";
            sentences.Enqueue(t4.text + t1.text);
            t5.text = "";
        }
        else if (t1.text == "I cant hold Hulk any longer")
        {
            t4.text = "Bruce Banner: ";
            t1.text = "Grrrrrrrrrrrrrrrr";
            sentences.Enqueue(t4.text + t1.text);
            t5.text = "";
        }
        else if (t1.text == "Grrrrrrrrrrrrrrrr")
        {
            t4.text = "Bruce Banner: Alien! Get out otherwise Hulk will smash you!";
            sentences.Enqueue(t4.text);
            t5.text = "Peter Parker: ";
            t1.text = "Mr. Stark sent me";
            t2.text = "I'm an avenger too, need help";
            t3.text = "I'm spiderman, you know me";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "There is no time to explain")
        {
            t4.text = "";
            t5.text = "Peter Parker: ";
            sentences.Enqueue("Peter Parker: " + t1.text);
            //t1.text = "He'll know where Dr. Strange is";
            t1.text = "Where can I find Dr. Strange?";
        }
        else if (t1.text == "Where can I find Dr. Strange?")
        {
            sentences.Enqueue("Peter Parker: "+t1.text);
            t4.text = "Bruce Banner: ";
            t5.text = "";
            t1.text = "He is cutting metal at workshop";

        }
        else if (t1.text == "He is cutting metal at workshop")
        {
            t4.text = "Bruce Banner: ";
            sentences.Enqueue("Bruce Banner: " + t1.text);
            
            t5.text = "";
            t1.text = "I'll join you later";
        }
        else if (t1.text == "I'll join you later")
        {
            t4.text = "Bruce Banner: ";
            t5.text = "";
            sentences.Enqueue("Bruce Banner: " + t1.text);

            SceneManager.LoadScene(4);
        }
        else if (t1.text == "Even then, I am doing an experiment")
        {
            t4.text = "Bruce Banner: ";
            t5.text = "";
            sentences.Enqueue("Bruce Banner: " + t1.text);
            t1.text = "Get Out! Grrrrrrrr";
            //t1.text = "He'll know where Dr. Strange is";
        }
        else if (t1.text == "Get Out! Grrrrrrrr")
        {
            sentences.Enqueue("Bruce Banner: " + t1.text);

            t4.text = "Bruce Banner: Alien! Get out otherwise Hulk will smash you!";
            t5.text = "Peter Parker: ";
            t1.text = "Mr. Stark sent me";
            t2.text = "I'm an avenger too, need help";
            t3.text = "I'm spiderman, you know me";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if (t1.text == "Otherwise, I'll take you by force")
        {
            t4.text = "Peter Parker: ";
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
            t1.text = "Save the world and my kid";
            sentences.Enqueue("Ant Man: " + t1.text);
        }
        else if(t1.text == "Never heard of you")
        {
            t4.text = "Bruce Banner";
            t5.text = "";
            sentences.Enqueue("Bruce Banner: "+t1.text);

            t1.text = "Get Out! Grrrrrrrr";

        }
        else if(t1.text == "Wong is at the Workshop")
        {
            sentences.Enqueue("Bruce Banner: "+t1.text);
            t4.text = "Bruce Banner";
            t5.text = "";
            t1.text = "He'll help you find timestone";
        }
        else if(t1.text == "He'll help you find timestone")
        {
            sentences.Enqueue("Bruce Banner: "+t1.text);
            t4.text = "Bruce Banner: ";
            t5.text = "";
            t1.text = "I'll join you later";

        }
        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick2()
    {
        

        if (t2.text == "I'm an avenger too, need help")
        {
            sentences.Enqueue("Peter Parker: " + t2.text);
            t5.text = "";
            t4.text = "Bruce Banner: ";
            t1.text = "Even then, I am doing an experiment";
        }

        else if (t2.text == "There is no time to explain")
        {
            t4.text = "";
            t5.text = "Peter Parker: ";
            sentences.Enqueue("Peter Parker: " + t2.text);
            t1.text = "Where can I find Dr. Strange?";

        }
        


        b2.SetActive(false);
        t2.text = "";

        b3.SetActive(false);
        t3.text = "";
    }

    public void onClick3()
    {

        b1.SetActive(true);
        if (t3.text == "I'm spiderman, you know me")
        {
            sentences.Enqueue("Peter Parker: " + t3.text);
            t5.text = "";
            t4.text = "Bruce Banner: ";
            t1.text = "Never heard of you";
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
