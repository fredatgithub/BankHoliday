namespace JoursFeries
{
  class NonWorkingDay
  {
    public string Country { get; set; }
    public byte Day { get; set; }
    public byte Month { get; set; }

    public NonWorkingDay(string country = "France", byte day = 1, byte month = 1)
    {
      Country = country;
      Day = day;
      Month = month;
    }
  }
}