using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBox
{
    internal class RandomNumbersViewModel
    {
        private Random _random = new Random();

        public int Number1 { get; } = 485628; // 초기값
        public int Number2 { get; } = 5171698; // 초기값

        public RandomNumbersViewModel()
        {
            // 랜덤 값으로 초기화 (예시)
            Number1 = _random.Next(100000, 999999); // 100000부터 999999까지의 랜덤 정수
            Number2 = _random.Next(100000, 999999); // 1000000부터 9999999까지의 랜덤 정수
        }
    }
}