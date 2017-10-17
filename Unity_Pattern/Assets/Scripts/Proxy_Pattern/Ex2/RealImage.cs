using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex2
{
    /// <summary>
    /// Real Subject 역할.
    /// Proxy가 나타내는 실제 객체를 정의.
    /// </summary>
    public class RealImage : IImage
    {
        private string fileName;

        //생성자를 통해 파일명을 전달.
        public RealImage(string fileName)
        {
            this.fileName = fileName;

            LoadImageFromDisk();
        }

        //디스크에서 이미지를 로드한다.
        private void LoadImageFromDisk()
        {
            Debug.Log("Loading Image... " + fileName);
        }

        //이미지를 보여준다.
        public void DisplayImage()
        {
            Debug.Log("Display Image... " + fileName);
        }
    }
}