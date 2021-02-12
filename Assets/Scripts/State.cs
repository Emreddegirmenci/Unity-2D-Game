using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;



    public string GetStateStory() // GetStateStory adında herkese açık bir metot oluşturuldu.
    {
        return storyText;  // Bu sınıf kullanıldığında bana storytext'teki şeyi döndür(getir)
    }
    public State[] GetNextStates()
    {
        return nextStates; 
    }
}
