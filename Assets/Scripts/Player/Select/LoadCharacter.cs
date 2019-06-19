using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    void Start()
    {
        if (SelectCharacter.chosenCharacter != null)
        {
            GameObject clone = Instantiate(SelectCharacter.chosenCharacter, new Vector3(-13f, -1.25f, -2f), Quaternion.identity);
            clone.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            SelectCharacter.chosenCharacter = null;
            SelectCharacter.Bye();
        }
    }
}
