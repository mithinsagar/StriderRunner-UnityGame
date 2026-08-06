// -----------------------------------------------------------------------------
// Strider Runner
// File   : QuitMenu.cs
// Module : Quit Menu
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using UnityEditor;
using UnityEngine;

public class QuitMenu : MonoBehaviour
{
    public void Quit()
    {
#if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE) 
    Application.Quit();
#elif (UNITY_WEBGL)
    Application.OpenURL("about:blank");
#endif
    }
}
