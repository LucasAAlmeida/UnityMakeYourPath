using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This represents the different 'States' of the game.
 * They are cards that hold the text of that moment in the game,
 * and references to the player's next possible choices
 * 
 * They are created using Unity Editor with a custom menu of name "State".
 * Just right click 
 */
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    /* Text for this moment in the game */
    [SerializeField] [TextArea(10,14)] string storyText;
    /* Next possible player choices */
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
