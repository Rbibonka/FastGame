using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected abstract void TakeExperience(float experience);

    protected abstract void RaiseLevel();

    protected abstract void Dead();
}
