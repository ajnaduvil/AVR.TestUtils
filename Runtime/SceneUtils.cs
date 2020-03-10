using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AVR.TestUtils
{
    public static class SceneUtils
    {
        /// <summary>
        /// Loads the scene with the name <paramref name="sceneName"/> additively. The scene must be added in build settings
        /// </summary>
        /// <param name="sceneName"></param>
        /// <returns></returns>
        public static IEnumerator LoadSceneAdditive(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }

        /// <summary>
        /// Unloads the scene with the name <paramref name="sceneName"/> additively. The scene must be loaded already
        /// </summary>
        /// <param name="sceneName"></param>
        /// <returns></returns>
        public static IEnumerator UnloadSceneAsync(string sceneName)
        {
            yield return SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}