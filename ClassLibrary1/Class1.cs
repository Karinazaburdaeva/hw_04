namespace Model
{
    public enum ErrorCode
    {
     None = 0,
     Unknown = -1,
     ConnectionLost = 200
    }

    [Flags]
    public enum Days
    {
        None = 0,
        Monday = 0b_0000_0001, // 1,
        Tuesday = 0b_0000_0010, // 1,
        Wednesday = 0b_0000_0100, // 1,
        Thursday = 0b_0001_0000, // 1,
        Friday = 0b_0010_0000, // 1,
        Saturday = 0b_0000_0001, // 1,
        Sunday = 0b_0100_0000, // 1,
        Weekend = Saturday | Sunday // ИЛИ

        

    }
}