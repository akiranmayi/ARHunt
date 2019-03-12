using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Buttons5 : MonoBehaviour {
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

    public GameObject menu1;
    public GameObject menu2;
    private bool isShowing=false;

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        sentences = new Queue<string>();
        sentences.Enqueue("Harry: Hello Professor! Good to see you!");
        sentences.Enqueue("Dumbledore: Hello Mr. Potter ");
    }
    public void onClick1 () {

        b1.SetActive(true);

        if (t1.text == "May I know the reason of your arrival?")
        {
            sentences.Enqueue("Dumbledore: "+t1.text);
            t4.text = "Harry: ";
            t5.text = "";
            t1.text = "I need information about the horcruxes,Sir";
            t2.text = "Nothing professor, just came here to meet you";
            t3.text = "Professor, I wanted to know if you could help me find the last horcrux";
            b2.SetActive(true);
            b3.SetActive(true);
            return;
        }
        else if(t1.text == "I need information about the horcruxes,Sir")
        {
            sentences.Enqueue("Harry Potter: "+t1.text);
            t4.text = "";
            t5.text = "Dumbledore: Voldemort diverted his soul into 7 horcruxes which accidently resulted in 8. ";
            t1.text = "You are the horcrux he accidently created";
            sentences.Enqueue(t5.text + t1.text);
        }
        else if (t1.text == "You are the horcrux he accidently created")
        {
            t4.text = "Harry: 5 out of 8 have been destroyed. I need to find the last one";
            sentences.Enqueue(t4.text);
            t5.text = "Dumbledore: Harry, Snape being a double agent could know ";
            t1.text = "I suggest you to see him";
            sentences.Enqueue("Dumbledore: " + t5.text + t1.text);
        }
        else if (t1.text == "You are the horcrux he accidently created")
        {
            t4.text = "Harry: 5 out of 8 have been destroyed. I need to find the last one";
            sentences.Enqueue(t4.text);
            t5.text = "Dumbledore: Harry, Snape being a double agent could know ";
            t1.text = "I suggest you to see him";
            sentences.Enqueue("Dumbledore: " + t5.text + t1.text);
        }

        b2.SetActive(false);
        t2.text = "";
        b3.SetActive(false);
        t3.text = "";


    }

    public void onClick2()
    {
        

        if (t2.text == "Professor just came here to meet you")
        {
            sentences.Enqueue("Harry: " + t2.text);
            t4.text = "Dumbledore: Well, well Harry.If there's something troubling you let me know...";
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
