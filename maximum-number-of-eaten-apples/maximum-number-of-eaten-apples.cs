public class Solution 
{
  public int EatenApples(int[] apples, int[] days)
  {
      var basket = new SortedList<int, int>();
      int eaten = 0, day = 0;
      while (true)
      {
          int shelfLife = 0;
          if (day < days.Length && days[day] != 0)
              shelfLife = day + days[day] - 1;
          if(shelfLife != 0)
              if (!basket.ContainsKey(shelfLife))
                  basket.Add(shelfLife, apples[day]);
              else
                  basket[shelfLife] += apples[day];
          if (basket.Count == 0 && day > days.Length)
              break;
          if(basket.Count > 0)
          {
              int zeroth = basket.Keys[0];
              if (zeroth >= day)
              {
                  eaten++;
                  basket[zeroth]--;                    
              }
              if (basket[zeroth] == 0)
                  basket.Remove(zeroth); 
          }
          day++;
          while(basket.Count>0 && basket.Keys[0]<day)
              basket.Remove(basket.Keys[0]);
      }
      return eaten;
  }
}