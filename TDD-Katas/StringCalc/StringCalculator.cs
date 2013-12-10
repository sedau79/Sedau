namespace StringCalc
{
    public class StringCalculator
    {
        private const string DELIMITER_PREFIX = "//";

        public int Add(string numbersText)
        {

            if ( string.IsNullOrEmpty(numbersText))
                return 0;

            string delimiter = ",";
            int delimmiterIdx = numbersText.IndexOf(DELIMITER_PREFIX, System.StringComparison.Ordinal);
            int startOfNumbersIdx = 0;
            if (delimmiterIdx >= 0)
            {
                delimiter = numbersText.Substring(delimmiterIdx + DELIMITER_PREFIX.Length, 1);
                startOfNumbersIdx = (delimmiterIdx + DELIMITER_PREFIX.Length+1);
            }

            var splitText = numbersText.Substring(startOfNumbersIdx).Split(delimiter.ToCharArray()[0]);
            int sum = 0;

            foreach (var s in splitText)
            {
                sum +=  int.Parse(s);
            }
            return sum;
        }
    }
}