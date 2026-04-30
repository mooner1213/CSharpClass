using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool isR = false;

        isR = (i == 3) && (j != 3);
        Debug.Log($"isR : {isR}"); // true

        isR = (i != 3) || (j == 3);
        Debug.Log($"isR : {isR}"); // false

        isR = (i >= 5);
        Debug.Log($"isR : {isR}"); // false

        Debug.Log((1 == 1) || (1 != 1)); // true

        Debug.Log(!(1 == 1)); // false
    }
}
