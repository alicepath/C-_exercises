// https://zh.wikipedia.org/wiki/%E8%92%99%E5%9C%B0%E5%8D%A1%E7%BE%85%E6%96%B9%E6%B3%95
// https://zh.wikipedia.org/wiki/%E8%92%99%E7%89%B9%E5%8D%A1%E6%B4%9B%E6%A0%91%E6%90%9C%E7%B4%A2
//在面積為1的正方形中有1/4正圓，亂數選擇點位置，點在兩者面積比值
//1:pi/4 = 全部點數量:圓內點數量  =>  pi = 圓內/全部 *4

public double cal_pi()
    {
    Random rnd = new Random();
    double d1 = new double();
    double d2 = new double();

    double count = 0;
    int total = 100000;
    for(int i =0; i<total; i++)
    {
        d1 = rnd.NextDouble();
        d2 = rnd.NextDouble();
        if(d1*d1 + d2*d2 <= 1) count += 1;
    }
    return count/total*4;
    }
Console.Write(cal_pi());