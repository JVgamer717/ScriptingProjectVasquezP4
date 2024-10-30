using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTempature = 70.0f;
    float coldLimitTempature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {

        if (coffeeTemperature > hotLimitTempature)  
        {

            print("Coffe is too hot.");
        }

        else if (coffeeTemperature < coldLimitTempature)
        {

            print("Coffe is too cold.");
        }

        else
        {

            print("Coffee is just right.");
        }
    }
}
