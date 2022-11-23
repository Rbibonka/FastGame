using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected abstract void GiveDamage();

    protected abstract void TakeExperience();

    protected abstract void RaiseLevel();

    protected abstract void Dead();
}
