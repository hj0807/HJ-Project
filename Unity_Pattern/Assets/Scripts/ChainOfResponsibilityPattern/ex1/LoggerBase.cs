using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//==== http://www.dofactory.com/net/chain-of-responsibility-design-pattern

//ex1 https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern
//ex2 https://www.codeproject.com/Articles/41786/Chain-of-Responsibility-Design-Pattern

namespace ChainOfResponsibilityPattern.ex1
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Info = 1,
        Debug = 2,
        Warning = 4,
        Error - 8,
        FuctionalMessage = 16,
        FuctionalError = 32,
        All = 63
    }

    public abstract class LoggerBase
    {
        protected LogLevel logMask;

        protected LoggerBase next;

        public LoggerBase(LogLevel logMask)
        {
            this.logMask = logMask;
        }

        public LoggerBase SetNext(LoggerBase nextLogger)
        {
            next = nextLogger;

            return nextLogger;
        }

        public void Message(string msg, LogLevel level)
        {
            if(logMask && level)
            {

            }
        }
    }
}