namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
		    var countStr = count.ToString();
		    var countLength = int.Parse(countStr[countStr.Length - 1].ToString()); ;
            var countLength2 = 0;
            if (countStr.Length > 1)
		    {
		        countLength2 = int.Parse(countStr[countStr.Length - 2].ToString() + countLength);
            }
            
            if (countLength2 >= 10 && countLength2 <= 20) return "рублей";

            if (countLength == 1) return "рубль";
		    if (countLength > 1 && countLength <= 4) return "рубля";
            if (countLength > 4 || countLength == 0) return "рублей";
            return "руб.";
		}
	}
}