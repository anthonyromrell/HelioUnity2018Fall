using UnityEngine;
using UnityEngine.Events;

public class TestId : MonoBehaviour
{
    public NameId Id;
    public UnityEvent OnMatch;

    void OnTriggerEnter(Collider letterId)
    {
        if (Id == letterId.GetComponent<HoldId>().Id)
        {
            OnMatch.Invoke();
        }
    }
}