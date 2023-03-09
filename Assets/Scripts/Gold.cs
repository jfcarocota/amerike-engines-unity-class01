using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Gold : MonoBehaviour
    {
        [SerializeField] 
        private int _points;

        public int GetPoints => _points;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if(!col.CompareTag("Player")) return;
            GameManager.Instance.Score.AddPoints(_points);
            GameManager.Instance.GetMainUI.UpdateScore(GameManager.Instance.Score);
            Destroy(gameObject);
        }
    }
}