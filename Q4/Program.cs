﻿using Q4;

ArrIntManager service = new ArrIntManager();
int sum = service.sumOfArray();
Console.WriteLine(sum);

Console.WriteLine(service.sumOfPrimes());

service.getTrio();

service.longestSubArray(50);