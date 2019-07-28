using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int stars;

    // Start is called before the first frame update
    public void AddStars(int numberofStars)
    {
        stars += numberofStars;
     }
}
