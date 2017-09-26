using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// c# chain of responsibility best example
// http://www.dofactory.com/net/chain-of-responsibility-design-pattern

namespace ChainOfResponsibilityPattern.ex1
{
    public abstract class Handler
    {
        protected Handler successor;

        /// <summary>
        /// 고리로 묶을 다음 객체를 설정한다.
        /// </summary>
        /// <param name="successor">다음 연쇄 객체</param>
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// 해당 객체에서 요청을 처리할 수 없을 경우, 다음 객체에 요청을 전달.
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandlerRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Debug.Log(string.Format("{0} handler request {1}", this.GetType().Name, request));
            }
            else if(successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Debug.Log(string.Format("{0} handler request {1}", this.GetType().Name, request));
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Debug.Log(string.Format("{0} handler request {1}", this.GetType().Name, request));
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}