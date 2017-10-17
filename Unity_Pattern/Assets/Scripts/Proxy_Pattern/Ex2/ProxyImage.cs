using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex2
{
    /// <summary>
    /// Proxy 역할.
    /// Real Subject를 참조하고 있으며, 클라이언트가 메소드 호출을 하면 프록시는 적절한 행동을 취한다.
    /// 실제 객체에 액세스할 수 있도록하는 참조를 유지 관리.
    /// </summary>
    public class ProxyImage : IImage
    {
        //실제 객체를 참조한다.
        private RealImage image;

        private string fileName;

        /// <summary>
        /// 생성자를 통해 파일명을 전달받는다.
        /// 실제 객체 생성시 필요.
        /// </summary>
        /// <param name="fileName"></param>
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void DisplayImage()
        {
            //객체의 생성은 1번만 하도록하고, 이후는 재사용하도록.
            if (image == null)
                image = new RealImage(fileName);

            image.DisplayImage();
        }
    }
}