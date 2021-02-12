using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour 
{
    [SerializeField] Text textComponent; // Denetçide(Inspector) elimizde bu var ve bunu değiştirebiliriz.
    [SerializeField] State startingState; // Starting State adında bir State oluşturur. 
  


    State state; // Mavi yazılı state state sınıfınının state'idir. Siyah yazılı state ise değişkendir Mavi state public state'e ulaşmayı sağlar

   

    // Start is called before the first frame update
    void Start()
    {
        state = startingState; // Başlangıçta state = startingState olur.
        textComponent.text = state.GetStateStory();  // Starting state'de yer alan yazı, getstate story metoduyla birlikte buraya işlenir  
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for(int index=0; index<nextStates.Length; index++) // Döngü ile yazmak oluşabilecek hataları önler
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        
       /* if (Input.GetKeyDown(KeyCode.Alpha1)) => Böyle teker teker yazılabilir ancak döngü ile yazmak daha doğrudur.
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        } */
        textComponent.text = state.GetStateStory(); // Bu kod sayesinde tuşlara basıldığında geçiş yapılır!!
    }
}
