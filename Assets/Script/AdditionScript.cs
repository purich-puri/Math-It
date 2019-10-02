using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdditionScript : MonoBehaviour
{
    public int randNumber_1;
    public int randNumber_2;
    public int answer;
    public int yourAnswer;
    int levelNumber = 1;
    public Text levelText;
    public Text yourAnswerText;
    public Text leftText;
    public Text rightText;

    public Text gameOverText;
    public GameObject mainMenu;
    public GameObject popUp;
    
    public GameObject animal1;
    public GameObject animal2;
    public GameObject animal3;
    public GameObject animal4;
    public GameObject animal5;
    public GameObject animal6;
    public GameObject animal7;
    public GameObject animal8;
    public GameObject animal9;
    public GameObject animal10;
    public GameObject animal11;
    public GameObject animal12;
    public GameObject animal13;
    public GameObject animal14;
    public GameObject animal15;
    public GameObject animal_2_1;
    public GameObject animal_2_2;
    public GameObject animal_2_3;
    public GameObject animal_2_4;
    public GameObject animal_2_5;
    public GameObject animal_2_6;
    public GameObject animal_2_7;
    public GameObject animal_2_8;
    public GameObject animal_2_9;
    public GameObject animal_2_10;
    public GameObject animal_2_11;
    public GameObject animal_2_12;
    public GameObject animal_2_13;
    public GameObject animal_2_14;
    public GameObject animal_2_15;

    void Start()
    {
        mainMenu.SetActive(false);
        DisplayLevel();

        randNumber_1 = Random.Range(1, 3);
        DisplayAnimals1();
        randNumber_2 = Random.Range(1, 3);
        DisplayAnimals2();

        DisplayHeaderNumber();
        answer = randNumber_1 + randNumber_2;
    }

    void DisplayLevel() {
        levelText.text = "LEVEL: " + levelNumber;
        yourAnswerText.text = "0";
        
        Debug.Log(levelText.text);
    }

    void DisplayHeaderNumber() {
        leftText.text = randNumber_1.ToString();
        rightText.text = randNumber_2.ToString();
    }

    IEnumerator PupUpText() {
        popUp.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.SetActive(false);
    }

//BUTTONS
    public void AddAnswerCount() {
        if (yourAnswer < 99)
        {
            yourAnswer++;
            yourAnswerText.text = yourAnswer.ToString();
        }
    }

    public void MinusAnswerCount() {
        if (yourAnswer >= 1) {
            yourAnswer--;
            yourAnswerText.text = yourAnswer.ToString();
        }
    }

    public void ChangeScene() {
        SceneManager.LoadScene(0);
    }

    public void SubmitAnswer() {
        if (answer == yourAnswer)
        {
            if (levelNumber < 10)
            {
                levelNumber++;
                yourAnswer = 0;
                DisplayLevel();
                StartCoroutine(PupUpText());

                randNumber_1 = randNumber_1 + Random.Range(0, 3);
                randNumber_2 = randNumber_2 + Random.Range(0, 3);
                DisplayAnimals1();
                DisplayAnimals2();
                DisplayHeaderNumber();
                answer = randNumber_1 + randNumber_2;
            }
            else {
                Debug.Log("WINNER");
                gameOverText.text = "YOU WON!";
                mainMenu.SetActive(true);
            }
        }
        else {
            Debug.Log("WRONG ANSWER");
            gameOverText.text = "WRONG!";
            mainMenu.SetActive(true);
        }
    }

    //testing, will do loop later
    //don't look it's ugly
    void DisplayAnimals1() {
        if (randNumber_1 >= 1)
        {
            animal1.SetActive(true);
            animal2.SetActive(false);
            animal3.SetActive(false);
            animal4.SetActive(false);
            animal5.SetActive(false);
            animal6.SetActive(false);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 2)
        {
            animal2.SetActive(true);
            animal3.SetActive(false);
            animal4.SetActive(false);
            animal5.SetActive(false);
            animal6.SetActive(false);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 3)
        {
            animal3.SetActive(true);
            animal4.SetActive(false);
            animal5.SetActive(false);
            animal6.SetActive(false);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 4)
        {
            animal4.SetActive(true);
            animal5.SetActive(false);
            animal6.SetActive(false);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 5)
        {
            animal5.SetActive(true);
            animal6.SetActive(false);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 6)
        {
            animal6.SetActive(true);
            animal7.SetActive(false);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 7)
        {
            animal7.SetActive(true);
            animal8.SetActive(false);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 8)
        {
            animal8.SetActive(true);
            animal9.SetActive(false);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 9)
        {
            animal9.SetActive(true);
            animal10.SetActive(false);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 10)
        {
            animal10.SetActive(true);
            animal11.SetActive(false);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 11)
        {
            animal11.SetActive(true);
            animal12.SetActive(false);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 12)
        {
            animal12.SetActive(true);
            animal13.SetActive(false);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 13)
        {
            animal13.SetActive(true);
            animal14.SetActive(false);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 14)
        {          
            animal14.SetActive(true);
            animal15.SetActive(false);
        }
        if (randNumber_1 >= 15)
        {          
            animal15.SetActive(true);
        }
    }

    void DisplayAnimals2() {
        if (randNumber_2 >= 1)
        {
            animal_2_1.SetActive(true);
            animal_2_2.SetActive(false);
            animal_2_3.SetActive(false);
            animal_2_4.SetActive(false);
            animal_2_5.SetActive(false);
            animal_2_6.SetActive(false);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 2)
        {
            animal_2_2.SetActive(true);
            animal_2_3.SetActive(false);
            animal_2_4.SetActive(false);
            animal_2_5.SetActive(false);
            animal_2_6.SetActive(false);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 3)
        {
            animal_2_3.SetActive(true);
            animal_2_4.SetActive(false);
            animal_2_5.SetActive(false);
            animal_2_6.SetActive(false);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 4)
        {
            animal_2_4.SetActive(true);
            animal_2_5.SetActive(false);
            animal_2_6.SetActive(false);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 5)
        {
            animal_2_5.SetActive(true);
            animal_2_6.SetActive(false);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 6)
        {
            animal_2_6.SetActive(true);
            animal_2_7.SetActive(false);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 7)
        {
            animal_2_7.SetActive(true);
            animal_2_8.SetActive(false);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 8)
        {
            animal_2_8.SetActive(true);
            animal_2_9.SetActive(false);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 9)
        {
            animal_2_9.SetActive(true);
            animal_2_10.SetActive(false);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 10)
        {
            animal_2_10.SetActive(true);
            animal_2_11.SetActive(false);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 11)
        {
            animal_2_11.SetActive(true);
            animal_2_12.SetActive(false);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 12)
        {
            animal_2_12.SetActive(true);
            animal_2_13.SetActive(false);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 13)
        {
            animal_2_13.SetActive(true);
            animal_2_14.SetActive(false);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 14)
        {
            animal_2_14.SetActive(true);
            animal_2_15.SetActive(false);
        }
        if (randNumber_2 >= 15)
        {
            animal_2_15.SetActive(true);
        }
    }
}
