using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionScript : MonoBehaviour
{
    public int randNumber_1;
    public int randNumber_2;
    public GameObject animal1;
    public GameObject animal2;
    public GameObject animal3;
    public GameObject animal4;
    public GameObject animal5;
    public GameObject animal6;
    public GameObject animal7;
    public GameObject animal8;
    public GameObject animal9;
    public GameObject animal_2_1;
    public GameObject animal_2_2;
    public GameObject animal_2_3;
    public GameObject animal_2_4;
    public GameObject animal_2_5;
    public GameObject animal_2_6;
    public GameObject animal_2_7;
    public GameObject animal_2_8;
    public GameObject animal_2_9;

    void Start()
    {
        randNumber_1 = Random.Range(1, 9);
        Debug.Log("Random Number: " + randNumber_1);
        DisplayAnimals1();

        randNumber_2 = Random.Range(1, 9);

        
        while (randNumber_1!= 0)
        {
            Start();
            int sum = randNumber_1 + randNumber_2;
        }
    }

   

    
    void SubmitAnswer() {

    }

    //testing, will do loop later
    //don't look it's ugly
    void DisplayAnimals1() {
        switch (randNumber_1)
        {
            case 1:
                animal1.SetActive(true);
                animal2.SetActive(false);
                animal3.SetActive(false);
                animal4.SetActive(false);
                animal5.SetActive(false);
                animal6.SetActive(false);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 2:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(false);
                animal4.SetActive(false);
                animal5.SetActive(false);
                animal6.SetActive(false);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 3:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(false);
                animal5.SetActive(false);
                animal6.SetActive(false);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 4:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(false);
                animal6.SetActive(false);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 5:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(true);
                animal6.SetActive(false);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 6:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(true);
                animal6.SetActive(true);
                animal7.SetActive(false);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 7:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(true);
                animal6.SetActive(true);
                animal7.SetActive(true);
                animal8.SetActive(false);
                animal9.SetActive(false);
                break;
            case 8:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(true);
                animal6.SetActive(true);
                animal7.SetActive(true);
                animal8.SetActive(true);
                animal9.SetActive(false);
                break;
            case 9:
                animal1.SetActive(true);
                animal2.SetActive(true);
                animal3.SetActive(true);
                animal4.SetActive(true);
                animal5.SetActive(true);
                animal6.SetActive(true);
                animal7.SetActive(true);
                animal8.SetActive(true);
                animal9.SetActive(true);
                break;
        }
    }

    void DisplayAnimal2() {
        switch (randNumber_2)
        {
            case 1:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(false);
                animal_2_3.SetActive(false);
                animal_2_4.SetActive(false);
                animal_2_5.SetActive(false);
                animal_2_6.SetActive(false);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 2:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(false);
                animal_2_4.SetActive(false);
                animal_2_5.SetActive(false);
                animal_2_6.SetActive(false);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 3:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(false);
                animal_2_5.SetActive(false);
                animal_2_6.SetActive(false);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 4:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(false);
                animal_2_6.SetActive(false);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 5:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(true);
                animal_2_6.SetActive(false);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 6:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(true);
                animal_2_6.SetActive(true);
                animal_2_7.SetActive(false);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 7:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(true);
                animal_2_6.SetActive(true);
                animal_2_7.SetActive(true);
                animal_2_8.SetActive(false);
                animal_2_9.SetActive(false);
                break;
            case 8:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(true);
                animal_2_6.SetActive(true);
                animal_2_7.SetActive(true);
                animal_2_8.SetActive(true);
                animal_2_9.SetActive(false);
                break;
            case 9:
                animal_2_1.SetActive(true);
                animal_2_2.SetActive(true);
                animal_2_3.SetActive(true);
                animal_2_4.SetActive(true);
                animal_2_5.SetActive(true);
                animal_2_6.SetActive(true);
                animal_2_7.SetActive(true);
                animal_2_8.SetActive(true);
                animal_2_9.SetActive(true);
                break;
        }
    }
}
