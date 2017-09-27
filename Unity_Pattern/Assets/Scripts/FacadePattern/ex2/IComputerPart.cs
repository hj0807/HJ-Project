using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern.ex2
{
    /// <summary>
    /// 각 부품별 공통 메소드를 정의한 인터페이스
    /// </summary>
    public interface IComputerPart
    {
        void Operation();
    }

    /// <summary>
    /// SubSystem 클래스
    /// 기능 구현
    /// </summary>
    public class Bios : IComputerPart
    {
        public void Operation()
        {
            Debug.Log("바이오스 구동중...");
        }
    }

    /// <summary>
    /// SubSystem 클래스
    /// 기능 구현
    /// </summary>
    public class CPU : IComputerPart
    {
        public void Operation()
        {
            Debug.Log("CPU 처리중...");
        }
    }

    /// <summary>
    /// SubSystem 클래스
    /// 기능 구현
    /// </summary>
    public class Memory : IComputerPart
    {
        public void Operation()
        {
            Debug.Log("메모리 로딩중...");
        }
    }

    /// <summary>
    /// SubSystem 클래스
    /// 기능 구현
    /// </summary>
    public class HDD : IComputerPart
    {
        public void Operation()
        {
            Debug.Log("하드 디스크 로딩중...");
        }
    }

    /// <summary>
    /// Facade 클래스 역할
    /// 각 부품들을 작동시키기 위해 필요한 부품들을 가지고 있는다.
    /// </summary>
    public class Computer
    {
        private Bios bios;
        private CPU cpu;
        private Memory memory;
        private HDD hdd;

        public Computer()
        {
            bios = new Bios();
            cpu = new CPU();
            memory = new Memory();
            hdd = new HDD();
        }

        //필요한 여러 부품들을 작동시킨다.
        public void Booting()
        {
            Debug.Log("== 컴퓨터 부팅 시작 ==");

            bios.Operation();
            cpu.Operation();
            memory.Operation();
            hdd.Operation();
        }
    }
}