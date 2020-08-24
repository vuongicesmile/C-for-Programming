using System;
using System.Linq;

class Time1
{
    public int Hour { get; set; }

    public int Minutes { get; set; }

    public int Second { get; set; }

    public void SetTime(int hour, int minutes, int second)
    {
        if((hour  < 0 || hour >23 ) ||(minutes <0 || minutes >59) || (second < 0 || second >59)) 
            {
                throw new ExecutionEngineException();
            }//end if

        Hour = hour;
        Minutes = minutes;
        Second = second;
    }
    public string ToUniversalString() => $"{Hour:D2} : {Minutes:D2} : {Second:D2}";
    public override string ToString() =>
        // chuyen he gio 24 gio thanh 12h
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        $"{Minutes:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";


}