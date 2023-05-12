using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    private int currentAge = 30;
    public int addedAge = 1;

    public bool pureOfHeart = True;
    public bool hasSecretIncantation = False;
    public string rareItem = "map";

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    public int currentGold = 50;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(30 + 1);

        //Debug.Log(currentAge + 1);
        OpenTreasureChamber();

        ComputeAge();

        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        //Debug.Log(firstName * pi);

        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));

        newMethod(5);

        if (currentGold > 50)
        {
            Debug.Log("More than fifty");
        }
        else if (currentGold < 15)
        {
            Debug.Log("Less than fifteen");
        }
        else
        {
            Debug.Log("Sweet spot");
        }




    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }

    public void newMethod(int num)
    {
        Debug.Log(num);
    }

    public void OpenTreasureChamber(){
        if(pureOfHeart && (rareItem == "map")){
            if (!hasSecretIncantation) {
                Debug.LogFormat("Characetr has no secret incantation");
            }
            else
            {
                Debug.LogFormat("Character is pure of heart and has a map");
            }
    }
}
