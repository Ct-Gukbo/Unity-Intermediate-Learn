using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu (menuName = "Profile/Card")]
public class SO_Card : ScriptableObject
{
    [Header("Character Infos")]
    public string Name;
    public string Description;
    public Type Elementaltype;


    [Header("Character Stats")]
    public int Health;
    public int ATK;
    public int Cost;

    [Space, ShowAssetPreview]
    public Sprite CharacterImage;
}

public enum Type
{
    Fire,
    Ice,
    Wind,
    Lighting,
    Earth,
    Water,

}