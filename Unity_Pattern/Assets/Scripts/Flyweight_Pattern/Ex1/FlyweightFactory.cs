using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex1
{
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        //public FlyweightFactory()
        //{
        //    flyweights.Add("X", new ConcreteFlyweight());
        //    flyweights.Add("Y", new ConcreteFlyweight());
        //    flyweights.Add("Z", new ConcreteFlyweight());
        //}

        public IFlyweight GetFlyweight(string key)
        {
            IFlyweight weight = (IFlyweight)flyweights[key];

            if (weight == null) { 
                weight = new ConcreteFlyweight();
                flyweights.Add(key, weight);
            }

            return (IFlyweight)flyweights[key];
        }

        //Flyweight pattern : 
        //리소스등을 관리하다보면 중복되어 생성되는 리소스가 생기기 마련이다. 
        //이러한 구조에서 체중을 줄여 Flyweight급으로 만들어주는 패턴이 Flyweight pattern이다.


        /*
        흔히 Flyweight pattern을 설명할때 '공유의 관점'을 언급한다.
        공유의 관점에는 논리적인 관점에서의 공유와 구현의 관점에서 공유가 있는데, 
        Flyweight로 만들기 위해 구현의 관점에서 퍼포먼스를 위한 공유를 생각한다.
        
        이를 통해 컴퓨터의 리소스를 보다 효율적으로 사용하도록 구조화 하여 프로그램을 날래게 만들어준다.



        풀(Pool)은 컴퓨터의 리소스를 효율적으로 사용할 수 있는 좋은 방법이다.반복되어 사용되는 객체를 미리 만들어 풀에 담아둔 후 필요한곳에 사용하고, 필요에 따라서 다 쓴 객체는 다시 풀에 반환하게 할 수 있다.



       그래픽컬한 리소스의 경우 동일한 리소스를 반복적으로 사용할때가 많은 만큼, 필요한 리소스를 미리 만들어두고 요청하는 리소스의 레퍼런스를 반환해 주는 방법으로 효율성을 높일 수 있다.
            */



       //출처: http://alleysark.tistory.com/189 [앨리삵]
    }
}