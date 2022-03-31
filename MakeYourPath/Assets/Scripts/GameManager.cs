using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        storyText.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (AcceptedInputPressed(nextStates)) {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                state = nextStates[0];
            } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
                state = nextStates[1];
            } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
                state = nextStates[2];
            }
            storyText.text = state.GetStateStory();
        }
    }

    private static bool AcceptedInputPressed(State[] nextStates)
    {
        return Input.GetKeyDown(KeyCode.Alpha1)
            || (Input.GetKeyDown(KeyCode.Alpha2) && nextStates.Length > 1)
            || (Input.GetKeyDown(KeyCode.Alpha3) && nextStates.Length > 2);
    }
}
