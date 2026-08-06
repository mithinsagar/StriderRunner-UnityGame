// -----------------------------------------------------------------------------
// Strider Runner
// File   : CharacterLoader.cs
// Module : Character Loader
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private PlayerMovement playerMovement;

    [Header("Assets")] 
    [SerializeField] private CharacterDataSO charData;

    void Awake()
    {
        if (playerMovement == null)
            playerMovement = GetComponent<PlayerMovement>();
    }

    void OnEnable()
    {
        int charIndex = PlayerPrefs.GetInt("Character", 0);
        
        playerMovement.SetData(charData.characterData[charIndex]);
    }
}
