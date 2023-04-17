using System.Collections.Generic;

namespace PingPong.Models
{
  public class Number
  {
    public int userInput;

    public Number(int userInput)
    {
        this.userInput = userInput;
    }
    public List<string> CreatePingPongList()
    {
        List<string> pingPongList = new List<string>();
    
        for (int i = 1; i <= userInput; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                pingPongList.Add("ping-pong");
            }
            else if (i % 3 == 0)
            {
                pingPongList.Add("ping");
            }
            else if (i % 5 == 0)
            {
                pingPongList.Add("pong");
            }
            else
            {
                pingPongList.Add(i.ToString());
            }
        }
    
        return pingPongList;
    }
  }
}