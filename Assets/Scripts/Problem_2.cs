using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
            //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
            //Your return values should be a List<int> that holds {1,3,5,7,9}
            void Start()
    {
        var a = OnlyOddOnes(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        foreach(int i in a)
        {
            print(i);
        }
           

            //Create a function called OnlyOddOnes that takes in an int array as a parameter and returns 
            //a List of integers that were odd inside the array
            
    }

    private List<int> OnlyOddOnes(int[] array)
    {
        List<int> et = new List<int>();
        foreach(int i in array)
        {
            if(i % 2 == 1)
            {
                et.Add(i);
            }
        }
        return (et);
    }
}
