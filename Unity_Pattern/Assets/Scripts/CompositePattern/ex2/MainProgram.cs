using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 참고 사이트
/// 검색 : 컴포지트 패턴 entry, c# composite pattern directory 구현
/// http://jellyms.kr/596
/// http://lilyiu.tistory.com/entry/%EB%94%94%EC%9E%90%EC%9D%B8%ED%8C%A8%ED%84%B4%EC%BB%B4%ED%8F%AC%EC%A7%80%ED%8A%B8Composite%ED%8C%A8%ED%84%B4
/// https://01ympus.wordpress.com/2014/06/18/composite-pattern/
/// 
/// </summary>
namespace CompositePattern.ex2
{

    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Folder rootFolder = new Folder("root");

            Folder binFolder = new Folder("bin");
            Folder tempFolder = new Folder("temp");
            Folder userFolder = new Folder("user");

            rootFolder.Add(binFolder);
            rootFolder.Add(tempFolder);
            rootFolder.Add(userFolder);

            binFolder.Add(new File("file_1", 100));
            binFolder.Add(new File("file_2", 200));

            rootFolder.Print();

            Folder folder1 = new Folder("folder1");
            Folder folder2 = new Folder("folder2");
            Folder folder3 = new Folder("folder3");

            rootFolder.Add(folder1);
            rootFolder.Add(folder2);
            rootFolder.Add(folder3);

            folder1.Add(new File("file_1", 100));
            folder2.Add(new File("file_2", 200));
            folder3.Add(new File("file_3", 300));

            Folder subFolder1 = new Folder("subFolder_1");
            Folder subFolder2 = new Folder("subFolder_2");

            folder1.Add(subFolder1);
            folder1.Add(subFolder2);

            subFolder1.Add(new File("sub_File_1", 100));
            subFolder1.Add(new File("sub_File_2", 200));
            subFolder1.Add(new File("sub_File_3", 300));

            subFolder1.Print();
        }
    }
}