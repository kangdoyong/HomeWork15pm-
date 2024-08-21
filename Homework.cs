using System;
using System.Collections;
using UnityEngine;

namespace NowonUnity1.ClassAndObject
{
    public class Homework : MonoBehaviour
    {
        void Start()
        {
            Pratice1();
        }

        /* 1. 두 실수(float)와 하나의 정수(int)를 인자로 입력받고,
         * 입력받은 정수의 값에 따라 두 실수의 사칙연산 결과를 실수(float)로 반환하는 함수 CalculateTwoFloat를 작성하시오.
         *  - 매개변수: float, float, int
         *  - 반환형: float
         *  - 정수 인자의 값에 따른 사칙연산
         *    - 0: 더하기
         *    - 1: 빼기
         *    - 2: 곱하기
         *    - 3: 나누기
         *    - 그 외: -1을 반환하고 종료
         *- 예시: CalculateTwoFloat(3.2f, 6.1f, 2) = 3.2 * 6.1 = 19.52
         */

        void Pratice1()
        {
            Debug.Log(CalculateTwoFloat(3.2f, 6.1f, 0));    // 0: 더하기
            Debug.Log(CalculateTwoFloat(3.2f, 6.1f, 1));    // 1: 빼기
            Debug.Log(CalculateTwoFloat(3.2f, 6.1f, 2));    // 2: 곱하기
            Debug.Log(CalculateTwoFloat(3.2f, 6.1f, 3));    // 3: 나누기
            Debug.Log(CalculateTwoFloat(3.2f, 6.1f, 4));    // 그 외
        }

        float CalculateTwoFloat(float num1, float num2, int num3)
        {
            switch (num3)
            {
                case 0:
                    return num1 + num2;
                    break;
                case 1:
                    return num1 - num2;
                    break;
                case 2:
                    return num1 * num2;
                    break;
                case 3:
                    return num1 / num2;
                    break;
                default:
                    return -1;
                    break;
            }
        }

        /* 2. 작성한 CalculateTwoFloat로 다음 코드를 작성했을 때 오류 없이 동작하는 코드와 오류가 발생하는 코드를 분류하고,
         *    이유를 설명하시오.
         *  1. float result = CalculateTwoFloat(2, 1.4f, 0);
         *  2. int result = CalculateTwoFloat(-2.2f, .7f, 3);
         *  3. var result = CalculateTwoFloat(1.7, -2.5, 1);
         *  4. float result = CalculateTwoFloat(-7.5f, 3.1f, 0.2f);
         *
         * 오류 없이 동작하는 코드
         * 1번: 2는 int타입이지만 float타입으로 인식됨
         * 
         * 오류 발생하는 코드
         *  2번: CalculateTwoFloat함수는 float 타입이기에 int가 잘못됨
         *  3번: 1.7과 -2.5는 float타입이 아닌 double타입
         *  4번: 0.2f가 float 타입이라 잘못됨
         */

    }
}